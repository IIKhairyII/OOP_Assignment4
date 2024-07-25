namespace Demo.Abstraction
{
    internal class Square : Base
    {
        public Square(float dim1) : base(dim1, dim1)
        {
        }

        public override double Perimeter { get => Dim1 * 4; }
    }
}
