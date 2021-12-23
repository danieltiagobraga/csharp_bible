/*
    Static class, defined by the keyword ‘static’ does not allow inheritance. Therefore, you cannot create an object for a static class.
*/
static class A {}

/*
    Sealed class: Sealed classes are classes that cannot be inherited. Use the keyword sealed to restrict access to users to inherit that class. 
*/
sealed class B {}

/*
    Abstract class: Abstract classes are classes that cannot be instantiated where you cannot create objects. 
    
    Abstract classes work on the OOPS concept of abstraction. 
    
    Abstraction helps to extract essential details and hide the unessential ones.
*/
abstract class C {
    public abstract void Method1();

    // Can have methods
    private void Method2() {
        // implementation ...
    }

    // Can have propertys
    public int MyProperty { get; set; }
}

/*
    Partial class: Partial class, defined by the keyword ‘partial’ allows its members to partially divide or share source (.cs) files.
*/
partial class D {}
partial class D {}