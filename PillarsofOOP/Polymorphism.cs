
namespace PillarsofOOP
{
    class Bird
    {
        public void Voice()
        {
            Console.WriteLine("Turr Turr\n\n");
        }
    }
    class Duck : Bird
    {
        public void Voice()
        {
            Console.WriteLine("Quack Quack\n\n");
        }
    }
}
