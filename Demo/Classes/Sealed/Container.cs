namespace Demo.Classes.Sealed
{
    public class Container
    {
        public class Parent
        {
            public float Age { get; set; }
            public string Name { get; set; }
            public virtual void Print()
            {
                Console.WriteLine("I am the parent class");
            }
        }
        public class Child : Parent
        {
            public virtual string Gene { get; set; }
            public sealed override void Print()
            {
                Console.WriteLine("I am the child class");
            }
        }
        public class GrandChild : Child
        {
            public sealed override string Gene { get => "Blue Eyes"; set { } }
            ////Not valid as method is sealed
            //public override void Print()
            //{
            //    Console.WriteLine("I am the child class");
            //}
        }
    }
}
