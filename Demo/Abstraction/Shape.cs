namespace Demo.Abstraction
{
    public abstract class Shape
    {
        public float Dim1 { get; set; }
        public float Dim2 { get; set; }
        public Shape(float dim1, float dim2)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }
        public abstract double Perimeter { get;}
        public abstract double CalcArea();
    }
}
