using System;
public class Point2D
{
    private float x = 0.0f;
    private float y = 0.0f;

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float GetX() => x;
    public void SetX(float value) => x = value;

    public float GetY() => y;
    public void SetY(float value) => y = value;

    public override string ToString() => $"({x}, {y})";
}


public class Point3D : Point2D
{
    private float z = 0.0f;

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public float GetZ() => z;
    public void SetZ(float value) => z = value;

    public override string ToString() => $"({GetX()}, {GetY()}, {z})";
}



class Program
{
    static void Main()
    {
        Point2D point2D = new Point2D(0.0f, 0.0f);
        Console.WriteLine($"2D Point: {point2D}");

        Point3D point3D = new Point3D(0.0f, 0.0f, 0.0f);
        Console.WriteLine($"3D Point: {point3D}");
    }
}
