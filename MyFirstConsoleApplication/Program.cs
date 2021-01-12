using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Steven";
            char firstLetter = 'S';


            //Number types
            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            short littleNumber = Int16.MaxValue;

            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            var implicitStringThing = "this is an implicitly typed variable.";

            int uninitializedInt;
            var otherThing = "";

            var today = DateTime.Today;

            //instantiation
            var bestYear = new DateTime(2020, 1, 1);

            //anonymous type, new object (basically the same as a js object)
            var person = new { Name = "Nathan" };

            //everything either is or can be an object (This is not how we will normally see objects, just need to know that this can happen)
            object weirdStuff = 1234;
            weirdStuff = "More craziness";

            Console.WriteLine(weirdStuff);
        }
    }
}
