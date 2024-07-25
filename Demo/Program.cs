using Demo.Abstraction;
using Demo.Classes.Static;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            Square square = new(10);
            Rectangle rectangle = new(10, 20);
            Circle circle = new(15);
            Triangle triangle = new(10, 20, 30);
            Console.WriteLine($"The squre with side = {square.Dim1} has area = {square.CalcArea()} and perimeter {square.Perimeter}");
            Console.WriteLine($"The rectangle with sides = {rectangle.Dim1} and {rectangle.Dim2} has area = {rectangle.CalcArea()} and perimeter {rectangle.Perimeter}");
            Console.WriteLine($"The circle with radius = {circle.Dim1} has area = {circle.CalcArea()} and perimeter {circle.Perimeter}");
            Console.WriteLine($"The triangle with sides = {triangle.Dim1}, {triangle.Dim2} and {triangle.Dim3} has area = {triangle.CalcArea()} and perimeter {triangle.Perimeter}");
            #endregion
            Console.WriteLine("<=======================================================>");
            #region static class
            Console.WriteLine(ConverterCalculator.CalculateCircleArea(10));
            Console.WriteLine(ConverterCalculator.ConvertFromUsdToEgp(10));
            Console.WriteLine(ConverterCalculator.ConvertFromCmToMm(10));
            #endregion
        }
    }
}