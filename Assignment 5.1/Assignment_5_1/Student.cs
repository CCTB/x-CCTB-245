using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5_1
{
    class Student
    {
        // static field for the last generated student ID
        private static int _LastUsedID = 20140001; // setting an initial value for field

        public int Id { get; private set; }
        public string Name { get; protected set; }
        public string PhoneNumber { get; protected set; }

        public Student()
        {
            Console.WriteLine("<- Student - Parameterless Constructor ->");
            _LastUsedID++;
            Id = _LastUsedID;
        }

        public Student(string name, string phone) : this()
        {
            Console.WriteLine("<- Student - Greedy Constructor ->");
            Name = name;
            PhoneNumber = phone;
        }

        public virtual void DisplayStudent()
        {
            Console.WriteLine("ID: " + Id + "  Name: " + Name + "  Phone: " + PhoneNumber + ")");
        }
    }
}
