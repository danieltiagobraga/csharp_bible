namespace modifiers_readonly
{
    /*
        The readonly keyword is a modifier that can be used in four contexts:

        In a field declaration, readonly indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class. 
        A readonly field can be assigned and reassigned multiple times within the field declaration and constructor.

        In a readonly struct type definition, readonly indicates that the structure type is immutable

        


        NOTE:

        The readonly keyword is different from the const keyword. A const field can only be initialized at the declaration of the field. 
        
        A readonly field can be assigned multiple times in the field declaration and in any constructor. 
        
        Therefore, readonly fields can have different values depending on the constructor used. 
        
        Also, while a const field is a compile-time constant, the readonly field can be used for run-time constants as in the following example:
    */
    class A {
        private readonly int _year = 2000; 

        A() {
            _year = 2020;
        }

        void DoStuffs() {
            // _year = 2021;    !!! COMPILATION ERROR !!! WE CAN ONLY CHANGE THE VALUE IN THE PROPERTY OR CONSTRUTOR
        }
    }
}