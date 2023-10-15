using IStatic.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStatic.Models
{
    internal class Student2
    {
        public static int _count = 1;

        public Student2(string name, string surname)
        {
            Id = _count++;
            Name = name;
            Surname = surname;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($@"
Id:{Id}
Name:{Helper.Capitalize(Name)}
Surname:{Helper.Capitalize(Surname)}");
        }
    }
}
