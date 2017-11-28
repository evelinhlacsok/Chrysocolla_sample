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
        }

        public void Cheer(string input)
        {
            Console.WriteLine("szisarp");
        }

        public void Greet(string name)
        {
            Console.WriteLine("Greetings");
        }

        public void New(string input1, string input2)
        {
            Console.WriteLine($"{input1}, {input2}");
        }
    }
}
