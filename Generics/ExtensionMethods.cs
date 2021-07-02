using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Linq;
namespace Generics
{
    public static class ExtensionMethods<T>
    {
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create an extension method called "FindOdds" this method should take an IEnumerable of type integers
        //and return a new IEnumerable of only the odd integers. Use linq in the scope to find odd numbers.
        public static  IEnumerable<int> FindOdds(IEnumerable<int> numbers)
        {
            return numbers.Where(n => n % 2 == 1);
        }
        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement
        public static T[] SortArray(T[] array)
        {
            return array.OrderBy(x => x).ToArray();
            
        }
    }
}
