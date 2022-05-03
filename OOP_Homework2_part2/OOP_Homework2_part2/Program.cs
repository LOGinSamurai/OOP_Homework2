
namespace OOP_Homework2_part2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Worker John = new Worker("John", 1000);
            Console.WriteLine("|Name: "+ John.getName() + "| |Salary: " + John.getSalary()+"|");
            UsersWorker Ivan = new UsersWorker("Ivan",25,1000);
            Console.WriteLine("|Name: " + Ivan.getName() + "| |Salary: " + Ivan.getSalary() + "|");
            UsersWorker Vasya = new UsersWorker("Vasya", 26, 2000);
            Console.WriteLine("|Name: " + Vasya.getName() + "| |Salary: " + Vasya.getSalary() + "|");
            Console.WriteLine("|Sum of Salary: " + (Ivan.getSalary() + Vasya.getSalary()) + "|");
            Student Harry = new Student();
            Harry.Display();
            Harry.course = "third grade";
            Harry.scholarship = "Necromancer";
            Harry.Display();
        }
    }
}