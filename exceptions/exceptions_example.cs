/*
    How to define your own exceptions? 

    Can multiple catch blocks be executed?
    No, Multiple catch blocks of similar type can’t be executed. Once the proper catch code executed, the control is transferred to the finally block
    
    
    
*/
using System;

namespace exceptions_examples
{
    /*
        In the example below we're demonstrating that we can't catch different catches
    */
    public class Exception_Example01
    {
        public void Run()
        {
            try
            {
                throw new System.ArgumentException("");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("catch ArgumentException");
            }
            catch (Exception)
            {
                Console.WriteLine("catch Exception");
            }
        }
    }


    /*
        In the example below we're defining our own exception. To do so, we need to create a class that inherits from System.Exception
    */
    [System.Serializable]
    public class MyOwnException : System.Exception
    {
        public MyOwnException() { }
        public MyOwnException(string message) : base(message) { }
        public MyOwnException(string message, System.Exception inner) : base(message, inner) { }
        protected MyOwnException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}