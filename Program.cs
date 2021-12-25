using System;
using exceptions_examples;
using serialization_desserialization;
using STRUCTS;

namespace csharp_bible
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new Exception_Example01();
            e.Run();

            TestStruct.Run();

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
