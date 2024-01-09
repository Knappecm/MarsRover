# MarsRover
Mars Rover DealerOn Application Code Assignment

# Behavior
This C# .Net Application will pull up a Swagger API when run. Please use the /mapArea API Endpoint when testing.
The /mapArea Endpoint requests data as the following:
"X boundary Y Boundary,X Rover Position Y Rover Position Rover Direction,Instructions"
i.e.
"5 5,1 2 N,LMLMLMLMM,3 3 E,MMRMMRMRRM"

the endpoint will return the results as:
"1 3 N
 5 1 E"
