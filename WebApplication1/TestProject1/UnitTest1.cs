namespace TestProject1;
using WebApplication1.Classes;
public class Tests
{
    [Test]
    public void TestClockWiseRotation()
    {
        Direction n = new Direction(Compass.N);
        n.RotateClockWise();
        Assert.That(Compass.E, Is.EqualTo(n.Position) );
        n.RotateClockWise();
        Assert.That(Compass.S, Is.EqualTo(n.Position) );
        n.RotateClockWise();
        Assert.That(Compass.W, Is.EqualTo(n.Position) );
        n.RotateClockWise();
        Assert.That(Compass.N, Is.EqualTo(n.Position) );
    }
    
    [Test]
    public void TestCounterClockWiseRotation()
    {
        Direction n = new Direction(Compass.N);
        n.RotateCounterClockWise();
        Assert.That(Compass.W, Is.EqualTo(n.Position) );
        n.RotateCounterClockWise();
        Assert.That(Compass.S, Is.EqualTo(n.Position) );
        n.RotateCounterClockWise();
        Assert.That(Compass.E, Is.EqualTo(n.Position) );
        n.RotateCounterClockWise();
        Assert.That(Compass.N, Is.EqualTo(n.Position) );
    }
    
    [Test]
    public void TestDirectionToString()
    {
        Direction n = new Direction(Compass.N);
        Assert.That("N", Is.EqualTo(n.Position.ToString()) );
    }
    
    [Test]
    public void TestPosition()
    {
        Position p = new Position(0, 0);
        
        p.IncrementVertical();
        Assert.That(1, Is.EqualTo(p.NorthPoint) );
        p.DecrementVertical();
        Assert.That(0, Is.EqualTo(p.NorthPoint) );
        p.IncrementHorizontal();
        Assert.That(1, Is.EqualTo(p.EastPoint) );
        p.DecrementHorizontal();
        Assert.That(0, Is.EqualTo(p.EastPoint) );
    }
    
    
    
}