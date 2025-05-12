// Factory method , as the name suggests it is like factory
// Factory --> we create something

using System.ComponentModel.DataAnnotations;

public class Point
{
    public double x, y;
    private Point(double x , double y)
    {
        this.x = x;
        this.y = y;
    }

    public static async Task<Point> CreateNewCartesianPoint(double x , double y)
    {
        await Task.Delay(10000);
        return new Point(x, y);
       
    }

    public static Point CreateNewPolarPoint(double rho, double theta)
    {
        return new Point(rho*Math.Cos(theta), rho * Math.Sin(theta));
    }
}
class Program
{
    static void Main(string[] args)
    {
        var cp = Point.CreateNewCartesianPoint(2, 2);
        Console.Write("Object  cp is Created" + cp);
        var cp1 = Point.CreateNewPolarPoint(2, 4);
        Console.Write("Object  cp1 is Created"+cp);

        Console.ReadLine();
    }

}
