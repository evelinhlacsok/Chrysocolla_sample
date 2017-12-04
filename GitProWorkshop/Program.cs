using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using GitProWorkshop.Repositories;
using GitProWorkshop.Entities;

namespace GitProWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new WorkshopContext(); 
            WorkshopRepository.AddSomething();
            CheerAndGreet("Csicsi");
            Boost("csicsi", "nice");
        }

        public static void Cheer(string name)
        {
            Console.WriteLine($"{name}'s language is szisarp.");
        }

        public void Greet(string firstname, string lastname)
        {
            Console.WriteLine("hey " + firstname + lastname);
        }

        public static void Greeting(string name)
        {
            Console.WriteLine($"Greetings, {name}!");
        }

        public static void NewMethod(string input1, string input2)
        {
            Console.WriteLine($"{input1}, {input2}");
        }

		public static void Boost(string name, string niceWord)
		{
			Console.WriteLine($"you {name} are {niceWord}");
		}

        public static void CheerAndGreet(string name)
        {
            name = name.ToUpper();
            Cheer(name);
            Greeting(name);
        }
    }
}