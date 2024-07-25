using OOP_Assignment4.Shape.Interfaces;

namespace OOP_Assignment4.Shape
{
    internal class Rectangle : IRectangle
    {
        public Rectangle(double length, double width)
        {
            Area = length * width;
        }
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Rectangle and its area = {Area}");
        }
    }
}
