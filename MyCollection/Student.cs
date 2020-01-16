using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class Student
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                TimeSpan age = DateTime.Now - BirthDate;
                return age.Days / 365;
            }
        }


        public override string ToString()
        {
            return $"{FirstName}\t{Lastname}\t{Age}";
        }

        static public bool operator >(Student st1, Student st2)
        {
            return st1.Age > st2.Age;
        }
        static public bool operator <(Student st1, Student st2)
        {
            return st1.Age < st2.Age;
        }
    }
}
