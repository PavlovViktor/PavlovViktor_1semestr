using System;
using System.Collections.Generic;
using System.Linq;

public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public double DistanceFromOrigin()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

class Program
{
    static void Main(string[] args)
    {

        List<Point3D> points = new List<Point3D>
        {
            new Point3D(1, 2, 3),
            new Point3D(-4, 5, 6),
            new Point3D(7, 8, 9),
            new Point3D(-10, -11, -12)
        };

        var sortedPoints = points.OrderBy(p => p.DistanceFromOrigin()).ToList();

        Console.WriteLine("Точки отсортированы по удаленности от центра:");
        foreach (var point in sortedPoints)
        {
            Console.WriteLine(point.ToString());
        }

        double minDistance = Double.PositiveInfinity;
        double maxDistance = Double.NegativeInfinity;

        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                double distance = CalculateDistance(points[i], points[j]);

                if (distance < minDistance)
                    minDistance = distance;

                if (distance > maxDistance)
                    maxDistance = distance;
            }
        }

        Console.WriteLine($"Минимальное расстояние между точками: {minDistance}");
        Console.WriteLine($"Максимальное расстояние между точками: {maxDistance}");
    }

    private static double CalculateDistance(Point3D p1, Point3D p2)
    {
        double dx = p1.X - p2.X;
        double dy = p1.Y - p2.Y;
        double dz = p1.Z - p2.Z;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}