using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + " " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var uma = new Person();
            uma.FirstName = "Uma";
            uma.LastName = "Thileepan";
            uma.Introduce();

            var numbers = new int[3];
            numbers[0] = 2;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            string FirstName = "Uma";
            string LastName = "Thileepan";
            string FullName = string.Format("My name is {0} {1}", FirstName, LastName);
            Console.WriteLine(FullName);

            var names = new string[3] { "Thil", "Pira", "Uma" };
            var FormatNames = string.Join(",", names);
            Console.WriteLine(FormatNames);

            var message = @"Hi Uma, 
                Please check the following paths
                c:/user/doc/class 
                c:/user/doc/struct";
            Console.WriteLine(message);
        }
    }
}
