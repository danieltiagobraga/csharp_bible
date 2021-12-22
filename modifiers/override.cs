namespace modifiers_override 
{
    /*
        The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.

        IN THE CASE BELLOW WE WILL USE THE OVERRIDE MODIFIER TO DEFINE THE IMPLEMENTATION OF THE ABSTRACT METHOD DoStuffs
    */
    public abstract class A 
    {
        public abstract void DoStuffs();
    }

    public class B : A
    {
        public override void DoStuffs()
        {
            throw new System.NotImplementedException();
        }
    }

    // IN THE CASE BELLOW WE WILL USE THE OVERRIDE MODIFIER TO DEFINE THE IMPLEMENTATION OF THE VIRTUAL METHOD DoStuffs
    public class C 
    {
        public virtual void DoStuffs() {
            // IMPLEMENTATION HERE
            
            // THE VIRTUAL METHODS ALLOWS US TO DEFINE THE IMPLEMENTATION OF THE METHOD CONTRARY TO THE ABSTRACT METHODS
        }
    }

    public class E : C {
        public override void DoStuffs()
        {
            base.DoStuffs();    // WE CAN USE THE BASE IMPLEMENTATION IF WE WANT 
        }
    }
}