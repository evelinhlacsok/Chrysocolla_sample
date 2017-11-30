using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GitProWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CheerAndGreet("Csicsi");
        }

        public static void Cheer(string input)
        {
            Console.WriteLine("szisarp");
        }

        public static void Greet(string name)
        {
            Console.WriteLine("Greetings");
        }

        public static void NewMethod(string input1, string input2)
        {
            Console.WriteLine($"{input1}, {input2}");
        }

        public static void CheerAndGreet(string name)
        {
            name = name.ToUpper();
            Cheer(name);
            Greet(name);
        }
    }
}
