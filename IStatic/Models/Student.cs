using IStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IStatic.Models
{
    internal class Student:ICodeAcademy
    {
        public static int _count=1;

        public Student(string name, string surname)
        {
            Id = _count;
            _count++;
            Name = name.Substring(0,1).ToUpper()+name.Substring(1).ToLower();
            Surname = surname.Substring(0, 1).ToUpper() + surname.Substring(1).ToLower();
            CodeEmail = GenerateEmail();
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public void GetInfo()
        {
            Console.WriteLine(@$"Fullname:{Name} {Surname}
Email:{CodeEmail}");
        }


        public static bool CheckName(string name)
        {
            Regex rg = new Regex("^([A-Z]|[a-z]){3,25}$");

            if (rg.IsMatch(name)) return true;
            else return false;
        }

        public string GenerateEmail()
        {
            return $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
        }
    }
}
