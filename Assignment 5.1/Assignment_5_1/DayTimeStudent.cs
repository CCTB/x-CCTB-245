using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5_1
{
    class DayTimeStudent : Student
    {
        public string Section { get; set; }
        public string Locker { get; set; }

        public DayTimeStudent(int id, string name, string phone, string section, string locker)
        {
            Id = id;
            Name = name;
            PhoneNumber = phone;
            Section = section;
            Locker = locker;
        }

        public override void DisplayStudent()
        {
            base.DisplayStudent();
            Console.WriteLine("Section: {0}  Locker Number: {1}",
                              Section, Locker);
        }
    }
}
