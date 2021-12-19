namespace modifiers_sealed 
{

    /*
        When applied to a class, the sealed modifier prevents other classes from inheriting from it. In the following example, class B inherits from class A, but no class can inherit from class B.
    */
    class A {}
    sealed class B : A {}
    class C // : B  (COMPILATION ERROR!!!)
    {}



    /*
        You can also use the sealed modifier on a method or property that overrides a virtual method or property in a base class. 
        
        This enables you to allow classes to derive from your class and prevent them from overriding specific virtual methods or properties.
    */
    public class BaseClass  
    {  
        public virtual void Display()  
        {  
            // Do stuffs
        }  
    }  
    public class DerivedClass : BaseClass  
    {  
        // Now the display method have been sealed and can;t be overridden  
        public override sealed void Display()  
        {  
            // Override and do other  stuffs
        }  
    }  
    public class ThirdClass : DerivedClass  
    {  
        //    public override void Display()  => COMPILING ERROR !!! WE CAN'T OVERRIDE A SEALED METHOD
        //    {  
        //    }  
    } 
}