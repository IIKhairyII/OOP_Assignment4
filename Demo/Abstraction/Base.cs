namespace Demo.Abstraction
{
    public abstract class Base : Shape
    {
        public Base(float dim1, float dim2) : base(dim1, dim2)
        {
        }
        public override double CalcArea()
        {
            return Dim1 * Dim2;
        }
    }
}
