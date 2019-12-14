using System;

namespace classes_2_1
{
    class Rectangle
{
    private double side1;
    private double side2;
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public double AreaCalculator()
    {
        double Area = side1 * side2;
        return Area;
    }
    public double PerimeterCalculator()
    {
        double Perimeter = (side1 + side2) * 2;
        return Perimeter;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строны прямоугольника");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(side1, side2);
        Console.WriteLine($"площадь прямоугольника равна {rectangle.AreaCalculator()}");
        Console.WriteLine($"периметр прямоугольника равен {rectangle.PerimeterCalculator()}");
        Console.ReadLine();
    }
}
}
