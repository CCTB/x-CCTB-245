using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5_1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            PhoneNumber = phone;
        }

        public virtual void DisplayStudent()
        {
            Console.WriteLine(Name + " (ph " + PhoneNumber + ")");
        }
    }
}
