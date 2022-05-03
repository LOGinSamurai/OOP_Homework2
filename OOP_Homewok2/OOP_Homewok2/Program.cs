public class Animal
{
   public double height;
   public double weight;
   public int age;
    public Animal()
    {
        height = 1;
        weight = 1;
        age = 1;
    }
    public virtual void voice()
    {
        Console.WriteLine("AAAAAAA");
    }
    public static void chekIfMature(object obj, int age)
    {
         if(obj is Dog && age >= 1 ) 
        {
            Console.WriteLine("Your dog is mature");
        }
         else if (obj is Fish && age >= 2)
        {
                Console.WriteLine("Your fish is mature");
        }
        else if (obj is Dog && age < 1)
        {
            Console.WriteLine("Your dog is immature");
        }
        else if (obj is Fish && age < 2)
        {
            Console.WriteLine("Your fish is immature");
        }
        /*        else if (obj is Animal)
                {
                    Console.WriteLine("We are not shure because all animals are different");
                }*/
    }
}
public class Dog : Animal
{
    public string furrColor;
    public Dog() : base()
    {
        furrColor = "white";
    }
    public override void voice()
    {
        Console.WriteLine("Bark");
    }
}

public class Fish : Animal
{
    public string scalesColor;
    public Fish() : base()
    {
        scalesColor = "blue";
    }
    public override void voice()
    {
        Console.WriteLine("...");
    }
}
public class Program
{
    public static void Main(String []args)
    {
        Dog bobby = new Dog();
        Console.WriteLine(bobby.age);
        bobby.voice();
        Console.WriteLine(bobby.furrColor);
        Fish johny = new Fish();
        Console.WriteLine(johny.age);
        bobby.voice();
        Console.WriteLine(johny.scalesColor);
        Animal.chekIfMature(johny, johny.age);
        johny.age = 3;
        Animal.chekIfMature(johny, johny.age);
        Animal.chekIfMature(bobby, bobby.age);
        bobby.age = 0;
        Animal.chekIfMature(bobby, bobby.age);

    }
}
