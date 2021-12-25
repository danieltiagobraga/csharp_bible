/*
    The struct is a value type in C# and it inherits from System.Value Type.

    Struct can’t be inherited from other types.

    A structure can't be abstract.

    No need to create an object with a new keyword.


*/
using System;

namespace STRUCTS
{
    struct Person : IPerson {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString() =>
            $"Name: {Name} Age: {Age}";
    }
    interface IPerson {}

    static class TestStruct {
        public static void Run()
        {
            Person p1 = new Person();
            p1.Name = "Daniel Braga";
            p1.Age = 22;

            Person p2 = p1;
            p2.Name = "Tiago Rodrigues";

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}