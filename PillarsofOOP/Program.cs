using PillarsofOOP;

// Program class to display all OOP pillars
class Program
{
    // Main method to create objects and call its method
    static void Main(string[] args)
    {
        // Inheritance example
        Console.WriteLine("This is example of Inheritance : ");
        // Creating an object of Team
        Team team1 = new Team("Team 1");
        // Calling method printInfo to display details
        Console.WriteLine(team1.printInfo());

        // Polymorphism example
        Console.WriteLine("This is example of Polymorphism : ");
        // Creating an object of Bird
        Bird myBird = new Bird();
        // Calling method Voice 
        myBird.Voice();

        // Creating an object with refrence of Child(Duck) and instance of parent(Bird) class
        // This is not allowed as giving reference of Child class and instance of parent class is not allowed in OOP
        //Duck myDuck = new Bird();
        // Method cannot be called as object can't be created
        //myDuck.Voice();

        // Encapsulation example
        Console.WriteLine("This is example of Encapsulation : ");
        // Creating an object of Laptop
        Laptop laptop = new Laptop();
        // Initalizing fields of laptop with the help of properties
        laptop.Brand = "HP";
        laptop.Model = "Victus";
        // Calling method Voice LaptopDetails to print details
        laptop.LaptopDetails();
        // Can't call this method as it has access modifier as private
        //laptop.MotherBoardInfo();
    }
}