using System;
using System.Collections.Generic;

namespace DictonaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictonary<int , Student> students = new MyDictonary<int , Student>();

            students.Add(134, new Student(1, "ibrahim","alzamel"));
            students.Add(134, new Student(2, "nermin", "isrep"));
            students.Add(134, new Student(3, "abdullah", "alikaj"));
            students.Add(134, new Student(4, "bashir", "manafihi"));
            students.Add(134, new Student(5, "bashir", "manafihi"));
            students.Add(134, new Student(6, "bashir", "manafihi"));

            Console.WriteLine(students.Count);


        }
    }
}
