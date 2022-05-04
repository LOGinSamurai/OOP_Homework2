namespace OOP_Homewok2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Dog bobby = new Dog();
            Console.WriteLine(bobby.age);
            bobby.voice();
            Console.WriteLine(bobby.furrColor);
            Fish johny = new Fish();
            Console.WriteLine(johny.age);
            johny.voice();
            Console.WriteLine(johny.scalesColor);
            Animal.chekIfMature(johny, johny.age);
            johny.age = 3;
            Animal.chekIfMature(johny, johny.age);
            Animal.chekIfMature(bobby, bobby.age);
            bobby.age = 0;
            Animal.chekIfMature(bobby, bobby.age);

        }
    }
}
