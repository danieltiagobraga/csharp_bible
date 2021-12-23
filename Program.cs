using System;
using exceptions_examples;
using serialization_desserialization;

namespace csharp_bible
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new Exception_Example01();
            e.Run();


            var c1 = new Customer("Daniel Braga", "Los Angeles");
            var c2 = c1;

            c2.Name = "Tiago Rodrigues";
            

            var s = c1.Serialize();

            Console.WriteLine("Hello World!");
        }

        
    }

    interface ITest {
        int MyProperty { get; set; }
    }

    class Test : ITest
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
