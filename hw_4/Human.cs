using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_4
{
    class Human
    {
        ////через свойства
        //    public string FirstName { get; set; }
        //public string LastName { get; set; }
        ////DateTime bd - класс дата
        //public int Age { get; set; }
        //Human(string _FirstName, string _LastName, int _Age)
        //{
        //    FirstName = _FirstName;
        //    LastName = _LastName;
        //    Age = _Age;
        //}

        //public Human() { }

        //через поля
        string firstname;
        string lastname;
        int age;
        public Human() { }
        public Human(string _firstName, string _lastName, int _age)
        {
            firstname = _firstName;
            lastname = _lastName;
            age = _age;
        }

        public void Print()
        {
            WriteLine($" {firstname} {lastname} {age} ");
        }

        public override string ToString()
        {
            return $"{firstname} {lastname} {age} ";
        }


    }
}
