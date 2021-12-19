namespace modifiers_volatile
{

    /*
        The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time. 
        
        The compiler, the runtime system, and even hardware may rearrange reads and writes to memory locations for performance reasons. 
        
        Fields that are declared volatile are excluded from certain kinds of optimizations. 
        
        There is no guarantee of a single total ordering of volatile writes as seen from all threads of execution.

        The volatile keyword can only be applied to fields of a class or struct. Local variables cannot be declared volatile.
    */
    class A {
        public volatile int sharedStorage;
    }
}