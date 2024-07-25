namespace Demo.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(float dim1) : base(dim1, dim1)
        {
        }

        public override double Perimeter => 2 * Math.PI * Dim1;

        public override double CalcArea()
        {
            return Math.PI * Dim1 * Dim2;
        }
    }
}
