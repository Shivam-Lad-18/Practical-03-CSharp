using PillarsofOOP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is example of Inheritance : ");
        Team team1 = new Team("Team 1");
        Console.WriteLine(team1.printInfo());

        Console.WriteLine("This is example of Polymorphism : ");
        Bird myBird = new Bird();
        myBird.Voice();

        //This is not allowed as giving reference of Child class and instance of parent class
        //Duck myDuck = new Bird();
        //myDuck.Voice();

        Console.WriteLine("This is example of Encapsulation : ");
        Laptop laptop = new Laptop();
        laptop.Brand = "HP";
        laptop.Model = "Victus";
        laptop.LaptopDetails();
        //laptop.MotherBoardInfo();
    }
}