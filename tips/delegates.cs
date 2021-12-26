/*
    A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++. 
    
    Unlike C function pointers, delegates are object-oriented, type safe, and secure. 
    
    The type of a delegate is defined by the name of the delegate. 

*/
namespace DELEGATES
{
    class TestDelegates 
    {
        // Lets declare a delegate named Del that can encapsulate a method that takes a string as an argument and returns void:
        public delegate void Del(string message);

        // Create a method for a delegate. 
        public void DelegateMethod(string message)
        {            
            System.Console.WriteLine(message);
        }

        // Lets use the delegate .. In this example we'll instanciate the delegate objet and call it
        public void UsingDelegateExample1() 
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate
            handler("Hello Delegates Example 1");
        }

        // Lets use the delegate .. In this example we'll pass the delegate objet through an parameter and call it
        public void UsingDelegateExample2(Del handler) 
        {
            // Instantiate the delegate.
            handler = DelegateMethod;

            // Call the delegate
            handler("Hello Delegates Example 2");
        }
    }
}