public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the length of your Classroom: ");
        string length = Console.ReadLine();
        Console.WriteLine("Please enter the width of your Classroom: ");
        string width = Console.ReadLine(); 
        double l = double.Parse(length);
        double w = double.Parse(width);
        double area = l * w;
        double perimeter = l * 2 + w * 2;

        Console.WriteLine($"the area of your classroom is: {area}");
        Console.WriteLine($"the perimeter of your classroom is: {perimeter}");

    }
}