using WebApplication1.Classes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/mapArea", (String data) =>
{
    
    // Split instructions by the delimiter "," and ensure there are enough instructions to continue 
    var instructions = data.Split(",");
    if (instructions.Length < 3)
    {
        return "Error: Not enough instructions";
    }
    
    //Ensure the boundary instruction is not malformed 
    var boundary = instructions[0].Split(' ');
    if (boundary.Length < 2 && int.TryParse(boundary[0], out _) && int.TryParse(boundary[1], out _))
    {
        return "Error: Malformed or not enough boundary points";
    }

    //Combine every 2 instructions except the boundary instruction
    List<String> rovers = [];
    for (int i = 1; i < instructions.Length; i += 2)
    {
        rovers.Add(instructions[i]+","+instructions[i+1]);
    }


    Boundary b = new Boundary(boundary[0], boundary[1]);
    List<String> positions = [];
    
    foreach (var rover in rovers)
    {
        //Split the combined instructions and ensure no malformed instructions 
        var instruct = rover.Split(',');
        var initialPoint = instruct[0].Split(' ');
        if (initialPoint.Length < 3
            && int.TryParse(initialPoint[0], out _)
            && int.TryParse(initialPoint[0], out _))
        {
            return "Error: Malformed or not enough initial points";
        }
        
        var compassPoints = Enum.GetNames(typeof(Compass)).ToList();
        if (!compassPoints.Contains(initialPoint[2]))
        {
            return "Error: Initial Position Direction is not Valid";
        }
        
        //Generate the rover
        Compass initialRotation = Compass.N;
        switch (initialPoint[2])
        {
            case "N":
                initialRotation = Compass.N;
                break;
            case "E":
                initialRotation = Compass.E;
                break;
            case "S":
                initialRotation = Compass.S;
                break;
            case "W":
                initialRotation = Compass.W;
                break;
        }
        Rover r = new Rover(initialPoint[0], initialPoint[1], initialRotation, instruct[1].ToCharArray(), b);
        
        //Execute the instructions and add results to the returned list
        if (!r.DoInstruction())
        {
            return "Error: Malformed Instruction";
        }
        
        positions.Add(r.ToString());
    }
    return String.Join("\n", positions.ToArray());
})
.WithName("GetMappedArea")
.WithOpenApi();

app.Run();


