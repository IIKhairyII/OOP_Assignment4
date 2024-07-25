namespace Demo.Abstraction
{
    public class Rectangle : Base
    {
        public Rectangle(float dim1, float dim2) : base(dim1, dim2)
        {
        }

        public override double Perimeter { get => (Dim1 + Dim2) * 2; }
    }
}
