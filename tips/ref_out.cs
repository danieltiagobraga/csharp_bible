/*
    An argument passed as ref must be initialized before passing to the method 

    Whereas out parameter needs not to be initialized before passing to a method, but we need to initialize it before using him

*/

namespace ref_out
{
    class ref_out {

        void Method01() {

            int p1 = 0; // it's used as ref parameter so it's must be initialized before passing to the method
            int p2;     // it's used as out parameter so we don't need to initialize before passing to the method. However, we need to initialize it before using

            Method02(ref p1, out p2);
        }

        void Method02(ref int p1, out int p2) {
            // var xx = p2; !!! COMPILATION ERROR !!! WE NEED TO INITIALIZE BEFORE USING THE VARIABLE

            p2 = 10;
        }
    }   
}
