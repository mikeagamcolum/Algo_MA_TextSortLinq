using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Gma.DataStructures.StringSearch;

namespace LegendofLinq
{
    class Program
    {
        public static UkkonenTrie<Delegate> tree;
        static public List<String> getData()
        {
            return File.ReadAllLines("words.txt").ToList();
        }

        static public List<String> StartingWith(String x)
        {
            List<String> results = new List<String>();
            return results;
        }

        static public List<String> NeedleHaystack(String n, int pos)
        {
            List<String> results = new List<String>();
            return results;
        }



        static void Main(string[] args)
        {
            tree = new UkkonenTrie<Delegate>(getData().Count);    
            for (int x = 0; x < getData().Count - 1; x++)
            {
            //    delegate var temp = tree.Retrieve(getData()[x + 1]);
            //    tree.Add(getData()[x], temp);
            }

            Console.WriteLine(StartingWith("Z").Count + " words start with 'Z'.");
            Console.WriteLine(StartingWith("He").Count + " words start with \"He\".");
            Console.WriteLine(NeedleHaystack("e", 1).Count + " words have 'e' in the second position.");
        }
    }
}
