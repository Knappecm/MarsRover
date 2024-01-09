using Microsoft.OpenApi.Extensions;

namespace WebApplication1.Classes;

public enum Compass
{
    N,
    E,
    S,
    W   
}


public class Direction(Compass d)
{
    public Compass Position { get; set; } = d;

    public void RotateClockWise()
    {
        switch (Position)
        {
            case Compass.N:
                Position = Compass.E;
                break;
            case Compass.E:
                Position = Compass.S;
                break;
            case Compass.S:
                Position = Compass.W;
                break;
            case Compass.W:
                Position = Compass.N;
                break;
        }
    }

    public void RotateCounterClockWise()
    {
        switch (Position)
        {
            case Compass.N:
                Position = Compass.W;
                break;
            case Compass.E:
                Position = Compass.N;
                break;
            case Compass.S:
                Position = Compass.E;
                break;
            case Compass.W:
                Position = Compass.S;
                break;
        }
    }

    public override string ToString()
    {
        return Position.GetDisplayName();
    }
    
}