using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList ar = new SortedList();

            ar.Add(1, "One Ring To Rule Them All");
            ar.Add(2, "Sam helped Frodo");
            ar.Add(3, "Sing along");

            Console.WriteLine("True or False, does the SorteList contain the value \"One Ring To Rule Them All\"?" + ar.ContainsValue("One Ring To Rule Them All") + ".");
            Console.WriteLine("True or False, does the SorteList contain the value \"Snowhite\"?" + ar.ContainsValue("Snowhite") + ".");
            Console.Read();
        }
    }
}