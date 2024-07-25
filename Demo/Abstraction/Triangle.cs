namespace Demo.Abstraction
{
    internal class Triangle : Shape
    {
        public float Dim3 { get; set; }
        public Triangle(float dim1, float dim2, float dim3) : base(dim1, dim2)
        {
            Dim3 = dim3;
        }

        public override double Perimeter => Dim1 + Dim2 + Dim3;

        public override double CalcArea()
        {
            float semiPerimeter = (Dim1 + Dim2 + Dim3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Dim1) * (semiPerimeter - Dim2) * (semiPerimeter - Dim3));
        }
    }
}
