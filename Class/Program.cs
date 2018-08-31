using System;
using Class.Student;
using Class.Math;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jeffrey = new StudentName();
            Jeffrey.FirstName = "Jeffrey";
            Jeffrey.LastName = "Chen";

            Jeffrey.Introduce();


            var calculator = new Calculator();
            
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
