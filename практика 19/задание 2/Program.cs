using System;
using System.Collections.Generic;
using System.Linq;

public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class Polygon
{
    private readonly List<Point> _vertices;

    public Polygon(List<Point> vertices)
    {
        _vertices = vertices;
    }

    private bool Intersect(Point a, Point b, Point c, Point d)
    {
        double denom = (b.X - a.X) * (d.Y - c.Y) - (b.Y - a.Y) * (d.X - c.X);
        if (denom == 0) return false; // Параллельные линии

        double nume_a = (b.Y - a.Y) * (a.X - c.X) + (b.X - a.X) * (c.Y - a.Y);
        double nume_b = (d.Y - c.Y) * (a.X - c.X) + (d.X - c.X) * (c.Y - a.Y);

        if (denom < 0)
        {
            if (nume_a > 0 || nume_b > 0) return false;
            if (nume_a < denom || nume_b < denom) return false;
        }
        else
        {
            if (nume_a < 0 || nume_b < 0) return false;
            if (nume_a > denom || nume_b > denom) return false;
        }

        return true;
    }

    public bool HasSelfIntersections()
    {
        for (int i = 0; i < _vertices.Count; ++i)
        {
            for (int j = i + 2; j < _vertices.Count; ++j)
            {
                if (Intersect(_vertices[i], _vertices[(i + 1) % _vertices.Count],
                              _vertices[j], _vertices[(j + 1) % _vertices.Count]))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public double Perimeter()
    {
        return _vertices.Sum((p, i) =>
            Math.Sqrt(Math.Pow(p.X - _vertices[(i + 1) % _vertices.Count].X, 2) +
                      Math.Pow(p.Y - _vertices[(i + 1) % _vertices.Count].Y, 2)));
    }

    public double Area()
    {
        return Math.Abs(_vertices.Select((p, i) =>
            p.X * _vertices[(i + 1) % _vertices.Count].Y -
            _vertices[(i + 1) % _vertices.Count].X * p.Y).Sum()) / 2;
    }

    public void ProcessPolygon()
    {
        if (HasSelfIntersections())
        {
            Console.WriteLine("Многоугольник имеет самопересечения.");
        }
        else
        {
            Console.WriteLine($"Периметр многоугольника: {Perimeter()}");
            Console.WriteLine($"Площадь многоугольника: {Area()}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Point> vertices = new List<Point>
        {
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(2, 4),
            new Point(0, 3)
        };

        Polygon polygon = new Polygon(vertices);
        polygon.ProcessPolygon();
    }
}