namespace WebApplication1.Classes;

public class Boundary(String x, String y)
{
    public int EastBoundary { get; set; } = int.Parse(x);
    public int NorthBoundary { get; set; } = int.Parse(y);
    

    public bool CheckBoundary(Position p)
    {
        return p.EastPoint >= 0 && p.EastPoint <= EastBoundary && p.NorthPoint >= 0 && p.NorthPoint <= NorthBoundary;
    }

}