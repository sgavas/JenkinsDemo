using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static string CreateMessage()
        {
            return "Hello World";
        }

        public static string CreateWelcomeMessage()
        {
            return "Welcome to Xyz";
        }

        public static string CreateFakeMessage()
        {
            return "Welcome to Fake";
        }

    }
}
