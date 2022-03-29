using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    internal class Employee:Human
    {
        public Employee(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
