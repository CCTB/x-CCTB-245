using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5_1
{
    class EveningStudent : Student
    {
        public string CourseName { get; set; }
        public string RoomNumber { get; set; }

        public EveningStudent(int id, string p2, string p3, string roomNumber, string courseName)
        {
            Id = id;
            Name = p2;
            PhoneNumber = p3;
            RoomNumber = roomNumber;
            CourseName = courseName;
        }

        public override void DisplayStudent()
        {
            Console.WriteLine("Id: {0}  Name: {1}  Phone: {2}  Room: {3}  Course: {4}",
                              Id, Name, PhoneNumber, RoomNumber, CourseName);
        }
    }
}
