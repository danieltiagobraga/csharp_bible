// C# program to illustrate the concept
// of the extension methods
using System;
 
namespace Extensions {
    class Scaler 
    {
        public void M1() 
        {
            Console.WriteLine("M1");
        }

        public void M2() 
        {
            Console.WriteLine("M2");
        }
    }

    static partial class ScalerExtensions // By convention the name of the class need to be the same of the class + Extensions
    {
        
        // Method 3
        public static void M3(this Scaler s)
        {
            Console.WriteLine("M3");
        }
        
        // Method 5
        public static void M4(this Scaler s)
        {
            Console.WriteLine("M4");
        }
    }
 
    static partial class ScalerExtensions 
    {
        
        // Method 5
        public static void M5(this Scaler s)
        {
            Console.WriteLine("M5");
        }
    }



    // Now we create a new class in which
    // Scaler class access all the five methods
    public static class TestExtensions 
    {
        // Main Method
        public static void Run()
        {
            Scaler s = new Scaler();
            s.M1();
            s.M2();
            s.M3();
            s.M4();
            s.M5();
        }
    }
}