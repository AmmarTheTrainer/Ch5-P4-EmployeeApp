using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P4_EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n === Encapsulation in C# Programming === \n");
            //Employee emp = new Employee();

            ////emp.empName = "Ahmad"; // no access
            //emp.SetName("hello g");

            #region encapsulation using traditional accessors and mutators


            //Console.WriteLine("***** Fun with Encapsulation *****\n");
            //Employee emp = new Employee("Marvin", 456, 30_000);
            //emp.GiveBonus(1000);
            //emp.DisplayStats();
            //// Use the get/set methods to interact with the object's name.
            //emp.SetName("Marv sdfadfjaldjfajfds");
            //Console.WriteLine("Employee is named: {0}", emp.GetName());

            #endregion

            #region Encapsulation using .NET Properties

            //Console.WriteLine("***** Fun with Encapsulation *****\n");
            //Employee emp = new Employee("Marvin", 456, 30000);
            //emp.GiveBonus(1000);
            //emp.DisplayStats();
            //// Reset and then get the Name property.
            //emp.Name = "Marv";
            //Console.WriteLine("Employee is named: {0}", emp.Name);



            #endregion

            #region Applying Intrinsic operators on .NET Properties

            //Employee joe = new Employee();
            //joe.SetAge(joe.GetAge() + 1);

            //joe.Age++;


            #endregion

            #region Defining Static Properties



            #endregion

            Console.ReadLine();
        }
    }
}
