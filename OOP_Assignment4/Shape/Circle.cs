using OOP_Assignment4.Shape.Interfaces;

namespace OOP_Assignment4.Shape
{
    internal class Circle : ICircle
    {
        public Circle(double radius)
        {
            Area = Math.PI * Math.Pow(radius, 2);
        }
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Circle and its area = {Area}");
        }
    }
}
