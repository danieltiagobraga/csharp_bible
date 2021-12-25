/*
    Constant variables are declared and initialized at compile time. The value can’t be changed afterward.

    Read-only is used only when we want to assign the value at run time.

*/

namespace const_readonly
{
    class const_readonly {
        const int NUMBER_OF_DAYS = 10;
        readonly int NumberOfDays = 10;

        const_readonly() {
            // NUMBER_OF_DAYS = 200;    // !!! COMPILATION ERROR !!! WE ONLY CAN INITIALIZE A CONSTANT IN THE DECLARATION
            NumberOfDays = 20;          // WE CAN INITIALIZE A READONLY IN THE DECLARATION AND IN THE CONSTRUCTORES
        }

        void Method01() {
            //NumberOfDays = 30;        // !!! COMPILATION ERROR !!! WE CAN'T INITIALIZE A READONLY IN A METHOD THAT IS NOT A CONSTRUCTOR
        }
    }   
}
