/*
 *
 *using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using HelloPractice.Problems.Random;
using HelloPractice.Problems.Udemy;
using HelloPractice.Problems.Udemy.Intermediate;
using NUnit.Framework.Internal;

namespace HelloPractice
{
    class Program
    
    {
        static void Main(string[] args)
        {

            var ram = new Ram();

            var component = ram as Computer; 

            if (ram is Animal)
            {
                Console.WriteLine("It is a PC");
            }
            else
            {
                Console.WriteLine("no it is not");
            }
        }

    }
    //Write any class outside of program and use ALT+ENTER to move it to another .cs file 

    class Computer
    {
        public Computer()
        {
            Console.WriteLine("Parent");
        }


    }

    class Ram : Computer
    {
        public Ram()
        {
            Console.WriteLine("Child Ram from Computer");
        }
    }

    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Parent");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Child ");
        }
    }
    

    }

 *
 */