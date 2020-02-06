using System;
using System.Collections.Generic;
using System.Linq;

namespace Datenstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste<object> BeispielListe = new Liste<object>();
            BeispielListe.Add(0);
            BeispielListe.Add(1);
            BeispielListe.Add(2);
            BeispielListe.Add(3);
            BeispielListe.Add(4);
            BeispielListe.Add(5);
            BeispielListe.Add(6);
            BeispielListe.Add(7);
            BeispielListe.Add(8);
            BeispielListe.Add(9);
            BeispielListe.Add(10);
            BeispielListe.Add(1);
            BeispielListe.Add(11);
            BeispielListe.Add(12);

            Liste<object> AddInteger = new Liste<object>();
            AddInteger.Add(13);
            AddInteger.Add(14);
            AddInteger.Add(15);
            AddInteger.Add(16);
            AddInteger.Add(17);
            AddInteger.Add(18);
            AddInteger.Add(19);
            AddInteger.Add(20);

            Liste<object> AddStrings = new Liste<object>();
            AddStrings.Add("Hi");
            AddStrings.Add("das");
            AddStrings.Add("ist");
            AddStrings.Add("ein");
            AddStrings.Add("Test");

            BeispielListe.AddRange(AddInteger);
            BeispielListe.AddRange(AddStrings);

            BeispielListe.Remove(1);
            BeispielListe.RemoveAt(25); 
            BeispielListe.Display();



            Console.WriteLine("-----");
            Console.WriteLine("Count: " + BeispielListe.Count());
            Console.WriteLine("-----");
            Console.WriteLine("Contains: " + BeispielListe.Contains(20));
            Console.WriteLine("----");
            Console.WriteLine("IndexOf: " + BeispielListe.IndexOf(1));
            Console.WriteLine("----");
            Console.WriteLine("IndexOf mit 2 Parametern: " + BeispielListe.IndexOf(1, 8));
            Console.WriteLine("----");
            BeispielListe.ToArray();


            //-----------CLEAR------------------------
            BeispielListe.Clear();
            Console.WriteLine("Count nach Clear: " + BeispielListe.Count());




        }
    }
}
