namespace Sealed_C_
{
    //Sealed Classes cannot be inherited or it cannnot make a child 
    class A
    {
        public virtual void print()
        {
            Console.WriteLine("Method of class A");
        }
    }

    //Sealed method cannot be further overriden by any other class method of same name
    class B : A 
    {
        public sealed override void print()
        {
            Console.WriteLine("Method of class B");
        }
    }
    class C : B
    {
        public override void print()
        {
            Console.WriteLine("Method of class C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            C obj = new C();
            obj.print();
        }
    }
}