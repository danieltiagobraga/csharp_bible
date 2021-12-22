/*

    With PARTIAL modifier we can define partial classes or partial methods

*/
namespace modifiers_partial 
{
    /*
        With partial classes we can define the same class in different files and it's an easy way to extend the behaviour of a class  
    */
    partial class A {
        public int Prop01 { get; set; }
        void Method01() {}
    }

    partial class A {
        // public int Prop01 { get; set; }  !!! COMPILATION ERROR !!! WE CAN'T DEFINE THE SAME PROPERTY
        // void Method01() {}               !!! COMPILATION ERROR !!! WE CAN'T DEFINE THE SAME METHOD

        void Method02() {
            // IMPLEMENTATION HERE
            (int x, int y) = point;

        }
    }



    /*
        With partial method we can define a method in a class a the implementation in other 
    */
    partial class B {
        partial void Method01();
    }

    partial class B {
        partial void Method01() {
            // IMPLEMENTATION HERE
        }
    }
}
