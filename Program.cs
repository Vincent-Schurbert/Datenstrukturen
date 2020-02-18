using System;
using System.Collections.Generic;
using System.Linq;

namespace Datenstrukturen
{
    class Program
    {
        public int ZweiZahlenVergleichen(int Zahl1, int Zahl2)
        {
            if (Zahl1 > Zahl2)
            {
                return 1;
            }
            else if (Zahl1 == Zahl2)
            {
                return 0;
            }
            else return -1;
        }
        public bool Larger(int Zahl)
        {
            if (Zahl > 10)
                return true;
            else
                return false;
        }

        public void Verdopple(int Zahl)
        {
            Console.WriteLine(Zahl * 2);
        }

        static void Main(string[] args)
        {

            Program p = new Program();

            //--------------------------------------------------------------Predicate-------------------------------------------------------

            Predicate<int> predicate;
            predicate = p.Larger;

            //--------------------------------------------------------------Action-------------------------------------------------------
            Action<int> action;
            action = p.Verdopple;

            Comparison<int> comparison;
            comparison = p.ZweiZahlenVergleichen;

            //--------------------------------------------------------------Add-------------------------------------------------------
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
            AddInteger.Add(7);
            AddInteger.Add(4);

            //BeispielListe.Sort(comparison);
            //BeispielListe.Display();

            // //Liste<string> AddStrings = new Liste<string>();
            // //AddStrings.Add("Hi");
            // //AddStrings.Add("das");
            // //AddStrings.Add("ist");
            // //AddStrings.Add("ein");
            // //AddStrings.Add("Test");
            // //-------------------------------------------------------AddRange---------------------------------------------------------------- -

             BeispielListe.AddRange(AddInteger);
            //// BeispielListe.AddRange(AddStrings);

            ////-------------------------------------------------------Remove--------------------------------------------------------------

            BeispielListe.Remove(12);
            BeispielListe.RemoveAt(0);
            BeispielListe.Display();

            // // //-----------------------------------------------Count-------------------------------------------------------------------------

            Console.WriteLine("-----");
            Console.WriteLine("Count: " + BeispielListe.Count());

            //-----------------------------------------------Contains-------------------------------------------------------------------------

            Console.WriteLine("-----");
            Console.WriteLine("Contains: " + BeispielListe.Contains(20));

            //--------------------------------------------------IndexOf----------------------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("IndexOf: " + BeispielListe.IndexOf(1));
            Console.WriteLine("IndexOf mit 2 Parametern: " + BeispielListe.IndexOf(1, 8));

            //--------------------------------------------------ToArray----------------------------------------------------------------------

            BeispielListe.ToArray();

            //--------------------------------------------------------------Exists-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("Exists: " + BeispielListe.Exists(predicate));

            //--------------------------------------------------------------Find-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("Find: " + BeispielListe.Find(predicate));

            //--------------------------------------------------------------FindAll-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("FindAll: ");
            BeispielListe.FindAll(predicate);

            //--------------------------------------------------------------FindIndex-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("FindIndex: " + BeispielListe.FindIndex(predicate));
            Console.WriteLine("FindIndex mit zwei Parametern: " + BeispielListe.FindIndex(predicate, 15));

            //--------------------------------------------------------------FindLast-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("FindLast: " + BeispielListe.FindLast(predicate));

            //--------------------------------------------------------------FindLastIndex-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("FindLastIndex: " + BeispielListe.FindLastIndex(predicate));
            Console.WriteLine("FindLastIndex mit zwei Parametern: " + BeispielListe.FindLastIndex(predicate, 21));

            //--------------------------------------------------------------ForEach-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("Durch ForEach verdoppelte Werte: ");
            BeispielListe.ForEach(action);

            //--------------------------------------------------------------Insert-------------------------------------------------------

            Console.WriteLine("----");
            BeispielListe.Insert(7, 100);
            Console.WriteLine("Insert: ");
            BeispielListe.Display();

            //--------------------------------------------------------------LastIndexOf-------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("LastIndexOf: ");
            Console.WriteLine(BeispielListe.LastIndexOf(3));

            Console.WriteLine("----");
            Console.WriteLine("LastIndexOf mit 2 Parametern: ");
            Console.WriteLine(BeispielListe.LastIndexOf(20, 17));

            // //--------------------------------------------------------------RemoveAll-------------------------------------------------------------

            Console.WriteLine("----");
            Console.WriteLine("removeall: ");
            Console.WriteLine(BeispielListe.RemoveAll(predicate));

            Console.WriteLine("----");
            Console.WriteLine("Liste nach RemoveAll > 10: ");
            BeispielListe.Display();

            // //////--------------------------------------------------------------Reverse-------------------------------------------------------------

            // Console.WriteLine("----");
            // Console.WriteLine("Reverse: ");
            //// BeispielListe.Reverse();
            // //BeispielListe.Display();
            // Console.WriteLine("----");
            // Console.WriteLine("Reverse2: ");
            // BeispielListe.Reverse2();
            // BeispielListe.Display();




            // //--------------------------------------------------------------CLEAR-------------------------------------------------------------

            // BeispielListe.Clear();
            // Console.WriteLine("----");
            // Console.WriteLine("Count nach Clear: " + BeispielListe.Count());
        }
    }
}
