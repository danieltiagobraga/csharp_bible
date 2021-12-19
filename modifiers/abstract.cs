namespace modifiers_abstract 
{
    /*
        Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own.
    */
    public abstract class A {}

    public class B {
        public B() {
            // var a = new A(); !!! COMPILATION ERROR !!! WE CAN'T INSTANCIATE A ABSTRACT METHOD
        }
    }

    public class C : A {}

    /*
        Use the abstract modifier in a method or property declaration to indicate that the method or property does not contain implementation.
    */
    public abstract class D {    
        public abstract void Method01(); // {}  !!! COMPILATION ERROR !!! WE CAN'T DEFINE ThE IMPLEMENTATION OF AN ABSTRACT METHOD
    }
}