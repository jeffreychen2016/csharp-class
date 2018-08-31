using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Student
{
    public class StudentName
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hello, my name is {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
