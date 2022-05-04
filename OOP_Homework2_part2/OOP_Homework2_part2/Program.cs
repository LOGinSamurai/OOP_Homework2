
namespace OOP_Homework2_part2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Worker John = new Worker("John", 1000);
            John.Display();
            UsersWorker Ivan = new UsersWorker("Ivan",25,1000);
            Ivan.Display();
            UsersWorker Vasya = new UsersWorker("Vasya", 26, 2000);
            Vasya.Display();
            Console.WriteLine("|Sum of Salary: " + (Ivan.getSalary() + Vasya.getSalary()) + "|");
            Student Harry = new Student();
            Harry.Display();
            Harry.course = "Physics";
            Harry.scholarship = 2000;
            Harry.Display();
        }
    }
}