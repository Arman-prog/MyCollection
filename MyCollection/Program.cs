using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> digits = new MyCollection<int> { 10, 12, 2, 25, 36, 150 };
            Console.WriteLine(digits.Contains(2));
            Console.WriteLine($"items count = {digits.Count}");
            Console.WriteLine();
            digits.Print();

            Console.WriteLine("remove 25 " + digits.Remove(25));
            Console.WriteLine($"items count = {digits.Count}");
            Console.WriteLine();
            digits.Print();

            Console.WriteLine("foreach\n");

            foreach (int digit in digits)
            {
                Console.WriteLine(digit);
            }



            Student st1 = new Student { FirstName = "Gexam", Lastname = "Hovhannisyan", BirthDate = new DateTime(1994, 09, 25) };
            Student st2 = new Student { FirstName = "Arsen", Lastname = "Vardanyan", BirthDate = new DateTime(1998, 07, 13) };
            Student st3 = new Student { FirstName = "Davit", Lastname = "Karapetyan", BirthDate = new DateTime(2000, 11, 10) };

            MyCollection<Student> students = new MyCollection<Student> { st1, st2 };
            students.Add(st3);
            Console.WriteLine($"students count: {students.Count}\n");

            students.Print();

            students.Remove(st2);

            Console.WriteLine($"students count: {students.Count}\n");
            students.Add(new Student { FirstName = "Aram", Lastname = "Vardanyan", BirthDate = new DateTime(1988, 08, 23) });
            Console.WriteLine($"students count: {students.Count}\n");

            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }

        }
    }
}
