using System;
using System.Collections.Generic;
using System.Linq;

namespace Datenstrukturen
{
    class Program
    {
        public bool Larger(int Zahl)
        {
            if (Zahl > 11)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Liste<int> BeispielListe = new Liste<int>();
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

            Liste<int> AddInteger = new Liste<int>();
            AddInteger.Add(13);
            AddInteger.Add(14);
            AddInteger.Add(15);
            AddInteger.Add(7);
            AddInteger.Add(16);
            AddInteger.Add(17);
            AddInteger.Add(18);
            AddInteger.Add(19);
            AddInteger.Add(20);

            //Liste<string> AddStrings = new Liste<string>();
            //AddStrings.Add("Hi");
            //AddStrings.Add("das");
            //AddStrings.Add("ist");
            //AddStrings.Add("ein");
            //AddStrings.Add("Test");

            BeispielListe.AddRange(AddInteger);
            //BeispielListe.AddRange(AddStrings);

            BeispielListe.Remove(12);
            BeispielListe.RemoveAt(0); 
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

            Program p = new Program();
            Predicate<int> predicate;
            predicate = p.Larger;
            Console.WriteLine("Exists: " + BeispielListe.Exists(predicate));
            Console.WriteLine("----");

            Console.WriteLine("Find: " + BeispielListe.Find(predicate));
            Console.WriteLine("----");

            Console.WriteLine("FindAll: ");
            BeispielListe.FindAll(predicate);

            Console.WriteLine("----");
            Console.WriteLine("FindIndex: " + BeispielListe.FindIndex(predicate));

            Console.WriteLine("----");
            Console.WriteLine("FindIndex mit zwei Parametern: " + BeispielListe.FindIndex(predicate, 15));




            //-----------CLEAR------------------------
            BeispielListe.Clear();
            Console.WriteLine("----");
            Console.WriteLine("Count nach Clear: " + BeispielListe.Count());




        }
    }
}
