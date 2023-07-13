using some_exercises_9;

class Program
{
     static int FirstMethod(int a,int b)
    {
        return a * b;
    }
    static double  SecondMethod(double a, double b)
    {
        return a * b;
    }
    public static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        Console.WriteLine(triangle.FirstRect(20,10));
        Console.WriteLine(triangle.secondRect(20,10,10));
        int firstMethod = FirstMethod(20, 10);
        double secondMethod = SecondMethod(20, 10);

        Shape shape = new Shape();
        int shapePerimeter = shape.GetPerimeter(20, 10);
        Console.WriteLine(shapePerimeter);

        InheritedTriangle inheritedTriangletriangle = new InheritedTriangle(30);
        int getTrianglePerimeter = inheritedTriangletriangle.GetPerimeter(20, 10);
        Console.WriteLine(getTrianglePerimeter);
    }
}