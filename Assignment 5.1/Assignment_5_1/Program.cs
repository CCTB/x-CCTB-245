using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTimeStudent personA = 
                new DayTimeStudent("Bob Smith", "780.421.1234", "S18", "HP2298");

            Student temp = new Student();
            temp = new Student();
            temp = new Student();

            EveningStudent personB = 
                new EveningStudent("Jane Doe", "780.773.7763", "WB102", "C#");

            // Display info
            personA.DisplayStudent();
            personB.DisplayStudent();
            personA.DisplayStudent();
            temp.DisplayStudent();
        }
    }
}
