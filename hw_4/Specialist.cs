using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_4
{
    class Specialist : Employee
    {
        string qualification;
        public Specialist(string _firstName, string _lastName, int _age, double _salary, string _qualification)
            : base(_firstName, _lastName, _age, _salary)
        {
            qualification = _qualification;
        }

        public new void Print()
        {
            base.Print();
            WriteLine($" {qualification}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {qualification}";
        }
    }
}
