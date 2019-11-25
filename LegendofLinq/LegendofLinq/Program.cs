using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace LegendofLinq
{
    class Program
    {
        static public List<String> getData()
        {
            return File.ReadAllLines("words.txt").ToList();
        }
        static public List<String> ReverseSort()
        {
            List<String> data = getData();
            data.Reverse();
            Console.WriteLine("The list has been reversed.");
            return data;
        }
        static public List<String> StartingWith(String x)
        {
            List<String> data = getData();
            List<String> results = new List<String>();
            for(int c = 0; c < data.Count; c++)
            {
                if (data[c].StartsWith(x))
                {
                    results.Add(data[c]);
                }
            }
            return results;
        }
        static public List<String> NeedleHaystack(String n, int pos)
        {
            List<String> data = getData();
            List<String> results = new List<String>();
            for (int c = 0; c < data.Count; c++)
            {
                if (data[c].Length > 2)
                {
                    if (data[c].Substring(pos, n.Length) == n) ;
                    {
                        results.Add(data[c]);
                    }
                }
            }
            return results;
        }
        static void Main(string[] args)
        {
            ReverseSort();
            Console.WriteLine(StartingWith("Z").Count + " words start with 'Z'.");
            Console.WriteLine(StartingWith("He").Count + " words start with \"He\".");
            Console.WriteLine(NeedleHaystack("e", 1).Count + " words have 'e' in the second position.");
        }
    }
}
