using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human h1 = new Human("Ann", "Eroshina", 35);
            //Employee em1 = new Employee();
           
            Manager m1 = new Manager("Ann", "Eroshina", 35, 1000, "IT");
            WriteLine(m1);

            Scienict s1 = new Scienict("Oleg", "Eroshin", 25, 5000, "доктор медицинских наук");
            WriteLine(s1);

            Specialist sp1 = new Specialist("Ivan", "Belov", 38, 1000, "главный");
            WriteLine(sp1);
        }
    }
}
