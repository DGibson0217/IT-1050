using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {// Person 1
            Person p1 = new Person();
            Console.WriteLine("What is your First Name?");
            p1.FirstName = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            p1.LastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            p1.Age = int.Parse(Console.ReadLine());
            p1.Spouse = new Person();

            Person.SumofAllAges = Person.SumofAllAges + p1.Age;

            p1.PrintNameAndAge();

            Console.WriteLine("What is your Spouse's Name?");
            p1.Spouse.FirstName = Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            Console.WriteLine("What is your Spouse's Age?");
            p1.Spouse.Age = int.Parse(Console.ReadLine());
            p1.Spouse.Spouse = p1;

            p1.Spouse.PrintNameAndAge();

            Person.SumofAllAges = Person.SumofAllAges + p1.Spouse.Age;


            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

         // Person 2
            Person p2 = new Person();
            Console.WriteLine("What is your First Name?");
            p2.FirstName = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            p2.LastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            p2.Age = int.Parse(Console.ReadLine());
            p2.Spouse = new Person();

            Person.SumofAllAges = Person.SumofAllAges + p2.Age; 

            p2.PrintNameAndAge();

            Console.WriteLine("What is your Spouse's Name?");
            p2.Spouse.FirstName = Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            Console.WriteLine("What is your Spouse's Age?");
            p2.Spouse.Age = int.Parse(Console.ReadLine());
            p2.Spouse.Spouse = p2;

            p2.Spouse.PrintNameAndAge();

            Person.SumofAllAges = Person.SumofAllAges + p2.Spouse.Age;

            Console.WriteLine(" The sum of our ages is ");
            Console.WriteLine(Person.SumofAllAges);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("The average of our ages is ");
            Console.WriteLine(Person.SumofAllAges / 4);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();


        }
    }
}
