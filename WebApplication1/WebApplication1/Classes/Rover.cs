namespace WebApplication1.Classes;

public class Rover(string x, string y, Compass d, Char[] i, Boundary b)
{
    private Direction Direction { get; } = new Direction(d);
    public Position Position { get; set; } = new Position(int.Parse(x), int.Parse(y));
    private Char[] Instruction { get; set; } = i;
    private Boundary bound = b;
    public override string ToString()
    {
        return $"{Position.EastPoint} {Position.NorthPoint} {Direction}";
    }

    public bool DoInstruction()
    {
        foreach (var i in Instruction)
        {
            if (i == 'M')
            {
                Move();
            }else if (i == 'L')
            {
                Direction.RotateCounterClockWise();
            }else if(i == 'R')
            {
                Direction.RotateClockWise();
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    private void Move()
    {
        switch (Direction.Position)
        {
            case Compass.N:
                //Check bounds and increment/decrement the position
                if (bound.NorthBoundary > Position.NorthPoint)
                {
                    Position.IncrementVertical();
                }
                break;
            case Compass.E:
                if (bound.EastBoundary > Position.EastPoint)
                {
                    Position.IncrementHorizontal();
                }
                break;
            case Compass.S:
                if (0 < Position.NorthPoint)
                {
                    Position.DecrementVertical();
                }
                break;
            case Compass.W:
                if (0 < Position.EastPoint)
                {
                    Position.DecrementHorizontal();
                }
                break;
        }
    }


}