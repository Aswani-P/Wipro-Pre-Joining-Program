using System;
public class AreaOfSquare
{
    int Side;
    int Area;
    public AreaOfSquare(int side, int area)
    {
        this.Area = area;
        this.Side = side;

    }

    public static void Main()
    {
        Console.WriteLine("Enter the Side of Square: ");
        int Side = Convert.ToInt32(Console.ReadLine());
        int Area = Side * Side;
        Console.WriteLine($"Area of Square with side {Side} is {Area}");
        Console.ReadKey();
    }
}