using IStatic.Extension;
using IStatic.Models;

namespace IStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////Task1

            //Console.WriteLine("Enter Name:");
            //string name=Console.ReadLine();
            //name = name.Trim();

            //Console.WriteLine("Enter Surname:");
            //string surname = Console.ReadLine();
            //surname = surname.Trim();


            //if (Student.CheckName(name) && Student.CheckName(surname))
            //{
            //    Student student = new Student(name, surname);
            //    student.GetInfo();
            //}
            //else Console.WriteLine("Student yaradilmadi");




            //Task2

            //Console.WriteLine(Helper.IsOdd(1));
            //Console.WriteLine(Helper.IsOdd(0));
            //Console.WriteLine(Helper.IsOdd(-11));
            //Console.WriteLine(Helper.IsOdd(-3));
            //Console.WriteLine(Helper.IsEven(1));

            //Console.WriteLine(Helper.HasDigit("asdasaaa"));



            // TASK 3
            Group gr = new Group("AF103");
            Group.AddGroup(gr);
            gr.AddStudent(new Student2("ADil", "nasirli"));
            gr.AddStudent(new Student2("Leyla", "shafiyeva"));
            gr.AddStudent(new Student2("fatima", "nasirli"));
            gr.AddStudent(new Student2("Gunel", "shafi"));


            //gr.RemoveStudent(2);
            //Console.WriteLine(gr);
            //foreach (var item in gr.Students)
            //{
            //    Console.WriteLine(item);
            //}



            //gr.GetGroupInfo();
            //foreach (var item in gr.Search("adi"))
            //{
            //    Console.WriteLine(item);
            //}

            //gr.ShowStudents();
            //Console.WriteLine(gr.GetStudent(2));
            Group gr2 = new Group("AB104");
            Group.AddGroup(gr2);
            gr2.AddStudent(new Student2("Fatima", "Nasirli"));
            gr2.AddStudent(new Student2("adil", "   nasirli   "));
            gr2.AddStudent(new Student2("LAla", "Shafii"));
            gr2.AddStudent(new Student2("Leyla", "Nasirli"));


            Group.ShowAllGroups();



        }
    }
}