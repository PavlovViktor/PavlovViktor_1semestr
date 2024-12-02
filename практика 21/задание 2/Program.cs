using System;

public class Circle
{

    public int X { get; set; }
    public int Y { get; set; }
    public int Radius { get; set; }


    public Circle()
    {
        X = 0;
        Y = 0;
        Radius = 0;
    }

    public Circle(int radius)
    {
        X = 0;
        Y = 0;
        Radius = radius;
    }


    public Circle(int x, int y)
    {
        X = x;
        Y = y;
        Radius = 0;
    }

   
    public Circle(int x, int y, int radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Центр круга: ({X}, {Y}), Радиус: {Radius}");
    }
}