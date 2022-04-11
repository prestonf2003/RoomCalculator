public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the length of your Classroom: ");
        string length = Console.ReadLine();
        Console.WriteLine("Please enter the width of your Classroom: ");
        string width = Console.ReadLine();
        Console.WriteLine("please enter in the height of your Classroom: ");
        string height = Console.ReadLine();
        double l = double.Parse(length);
        double w = double.Parse(width);
        double h = double.Parse(height);
        double area = l * w;
        double perimeter = l * 2 + w * 2;
        double surfaceArea = 2 * w * l + 2 * h * l + 2 * h * w;
        double volume = l * w * h;


        Console.WriteLine($"the area of your Classroom is: {area} feet");
        Console.WriteLine($"the perimeter of your Classroom is: {perimeter} feet");
        Console.WriteLine($"The surface area of your Classroom is: {surfaceArea} feet");
        Console.WriteLine($"The volume of your Classroom is: {volume} feet");
        Console.WriteLine($"The volume of your Classroom is: {volume} feet");
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
}