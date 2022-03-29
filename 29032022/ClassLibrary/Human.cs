using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Human
    {
        protected internal string Name { get; set; }
        private protected string Surname { get; set; }

        private byte _age;
    }
}
