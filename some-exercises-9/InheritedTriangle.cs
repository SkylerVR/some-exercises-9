namespace some_exercises_9;

public class InheritedTriangle : Shape
{
    public int ThirdParameter { get; set; }

   public InheritedTriangle(int c)
   {
       ThirdParameter = c;
   }
    public override int GetPerimeter(int a, int b)
    {
        return a + b + ThirdParameter;
    }
}
