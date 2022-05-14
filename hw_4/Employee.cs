using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_4
{
    class Employee: Human
    {
        //через свойства
        //public double Salary { get; set; }
        //public Employee(string _FirstName, string _LastName, int _Age, double _Salary)/*:base(FirstName, LastName, Age)*/ // для base только с полями, свойства не подходят
        //{
        //    FirstName = _FirstName;
        //    LastName = _LastName;
        //    Age = _Age;
        //    Salary = _Salary;
        //    //...
        //}

        //через поля
        public double salary;
        public Employee() { }
        public Employee(string _firstName, string _lastName, int _age, double _salary) : base(_firstName, _lastName, _age)
        {
            salary = _salary;
        }

        public new void Print()
        {
            base.Print();
            WriteLine($" {salary}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {salary}";
        }
    }
}
