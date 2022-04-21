public class Program
{
    public static void Main()
    {
        try { 
        Console.WriteLine("Please enter the length of your Classroom: ");
        string length = Console.ReadLine();
        Console.WriteLine("Please enter the width of your Classroom: ");
        string width = Console.ReadLine();
        Console.WriteLine("please enter in the height of your Classroom: ");
        string height = Console.ReadLine();
        double l = double.Parse(length);
        double w = double.Parse(width);
        double h = double.Parse(height);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("I dont understand that input");
        }
        
        
       


        Console.WriteLine($"the area of your Classroom is: {GetArea(l, w)} feet");
        Console.WriteLine($"the perimeter of your Classroom is: {GetPerimeter(l, w)} feet");
        Console.WriteLine($"The surface area of your Classroom is: {GetSurfaceArea(l, w, h)} feet");
        Console.WriteLine($"The volume of your Classroom is: {getVolume(l, w, h)} feet");
        
        if (area <= 250)
        {
            Console.WriteLine("This is a small room");
        }
        else if(area <= 650 && area > 250)
        {
            Console.WriteLine("This is a medium sized room");
        }
        else
        {
            Console.WriteLine("This is a large room");
        }
    }
    public static double GetArea(double l, double w)
    {
        double area = l * w;
        return area;
    }
    public static double GetPerimeter(double l, double w)
    {
        double perimeter = l * 2 + w * 2;
        return perimeter;
    }
    public static double GetSurfaceArea(double l, double w, double h)
    {
        double surfaceArea = 2 * w * l + 2 * h * l + 2 * h * w;
        return surfaceArea;
    }
    public static double getVolume(double l, double w, double h)
    {
        double volume = l * w * h;
        return volume;
    }
}