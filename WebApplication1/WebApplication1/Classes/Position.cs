namespace WebApplication1.Classes;

public class Position(int x, int y)
{
    public int EastPoint { get; set; } = x;
    public int NorthPoint { get; set; } = y;
    

    public void IncrementHorizontal()
    {
        EastPoint++;
    }
    
    public void IncrementVertical()
    {
        NorthPoint++;
    }
    
    public void DecrementHorizontal()
    {
        EastPoint--;
    }
    
    public void DecrementVertical()
    {
        NorthPoint--;
    }
}