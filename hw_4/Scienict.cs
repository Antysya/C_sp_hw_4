using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_4
{
    class Scienict : Employee
    {
        string direction;
        public Scienict(string _firstName, string _lastName, int _age, double _salary, string _direction) 
            : base(_firstName, _lastName, _age, _salary)
        {
            direction = _direction;
        }

        public new void Print()
        {
            base.Print();
            WriteLine($" {direction}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {direction}";
        }
    }
}
