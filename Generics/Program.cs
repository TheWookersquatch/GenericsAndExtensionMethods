using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T".
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Equipment". The second class called "Food".
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Equipment>". The second instance will hold "<food>".
        //TODO create some instanes of type Food and Equipment and Add them the correct storage bins.

        //TODO In the program class Create a static void method called CountToNum that has a generic type called "T".
        //TODO Give the method a T paramter called "n".
        //TODO In the method scope make the method print all the numbers from 0 to "n".
        //TODO Call the method in the Main first by giving it a float number. Then call it again by giving it a double number.

        public static void CountToNum<T>(T n)
        {
            var num = int.Parse( n.ToString());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var oddNumbers = ExtensionMethods<int>.FindOdds(numbers);
            var sortedNumbers = ExtensionMethods<int>.SortArray(numbers);

            var equip = new Storage<Equipment>();
            var food = new Storage<Food>();
            var pizza = new Food();
            var chicken = new Food();
            var grapes = new Food();
            
            food.Bin.Add(pizza);
            food.Bin.Add(chicken);
            food.Bin.Add(grapes);
          
            var hammer = new Equipment();
            var drill = new Equipment();
            var lathe = new Equipment();

            equip.Bin.Add(hammer);
            equip.Bin.Add(drill);
            equip.Bin.Add(lathe); 
         
            float num1 = 22 / 7;
            CountToNum(num1);

            double num2 = 22 / 7;
            CountToNum(num2);



        }
      

        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create an extension method called "FindOdds" this method should take an IEnumerable of type integers and return a new IEnumerable of only the odd integers. Use linq in the scope to find odd numbers.

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
