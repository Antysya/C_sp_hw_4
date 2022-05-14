using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_4
{
    class Manager : Employee
    {
        string activity;
        public Manager(string _firstName, string _lastName, int _age, double _salary, string _activity) 
            : base(_firstName, _lastName, _age, _salary)
        {
            activity = _activity;
        }

        public new void Print()
        {
            base.Print();
            WriteLine($" {activity}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {activity}";
        }
    }
}
