namespace PillarsofOOP
{
    // Bird class as Parent
    class Bird
    { 
        // public virtual Voice method as it can be called from anywhere and can be overriden by its child
        // Prints voice of a bird in console
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr\n\n");
        }
    }
    //Child Class Duck which inherits Bird
    class Duck : Bird
    {
        // public override Voice method as it can be called from anywhere and is overriding its parent method
        // Prints voice of a Duck in console
        public override void Voice()
        {
            Console.WriteLine("Quack Quack\n\n");
        }
    }
}
