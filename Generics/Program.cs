﻿using System;
using System.IO;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type T.
        //TODO In your class create a property List called "Bin". Set the list type to T.
        //TODO Create two more classes. One class called "Equipment". The second class called "Food".
        //TODO create two instances of type Storage in the Main method. First Instance will hold Equipment. The second instance will hold food.
        //TODO create some instanes of type Food and Equipment and Add them the correct storage bins.
        
        static void Main(string[] args)
        {

            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log("Test1", w);
                Log("Test2", w);
            }


            string greeting = "hello";

            greeting.PrintString();

            var numbers = new int[] { 2, 3, 4, 5, 6, 7, 8, };

            var odds = numbers.FindOdds();



        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }



        //TODO Create a method called NumberPrinter that has a generic type called "Numbers".
        //TODO Give the method an array parameter of type "Numbers"
        //TODO In the method scope make the method print all the numbers from the array in a foreach loop.
        //TODO Call the method first by giving it the type float. Then call it again by giving it the type byte.



        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //in your new class create an extension method called "FindOdds" this method should take an IENumerable of intergers and return a new IeNumerable of only the odd ones. Use linq in the scope to find odd numbers.




    }
}
