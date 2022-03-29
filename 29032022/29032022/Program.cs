using System;
using yourclasses;
using myclasses;
using _29032022.Classes.SubClasses;
using Classes;
using ClassLibrary;

namespace _29032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            School school = new School();

            Human human = new Human();
            human.Name = "Hikmet";
            human.Surname = "Abbasov";

            _29032022.Classes.SubClasses.Student student = new _29032022.Classes.SubClasses.Student();
        }
    }
}
