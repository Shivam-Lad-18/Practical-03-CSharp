namespace PillarsofOOP
{
    // Abstract: A class that cannot be instantiated and is meant to be inherited by other classes.
    // It can contain abstract methods, which must be implemented by derived classes.
    abstract class LaptopTemplate
    {
        // Abstract method: A method without implementation in the abstract class. derived class must provide its implementation.
        public abstract void LaptopDetails();
    }
    // Laptop class inherits abstract class to implement its method
    class Laptop : LaptopTemplate
    {
        // private fields so that it can not be accessed in other classes to achieve encapsulation
        private string brand;
        private string model;

        // Properties to access the private fields and achieve encapsulation
        public string Brand {
            get { return brand; } // getter to return value of brand
            set { brand = value; } // setter to set the value of brand
        }
        public string Model
        {
            get { return model; } // getter to return value of model
            set { model = value; } // setter to set the value of model
        }
        // Override method of Abstarct class to achieve abstraction
        // Prints the data of private fields with help of public properties
        public override void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
        // Private method that can't be accessed in other classes and instance of class
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
