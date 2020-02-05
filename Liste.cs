using System;
using System.Text;

namespace Datenstrukturen
{
    public class Liste<T>
    {
        Knoten<T> First;
        Knoten<T> Last;

        public int Count()
        {
            int Zähler = 0;
            var Erster = First;

            while (Erster != null)
            {
                Erster = Erster.Right;
                Zähler++;
            }
            return Zähler;
        }

        public void Add(T NewNode)
        {
            if (First == null)
            {
                var add = new Knoten<T>(null, NewNode, null);
                First = add;
                Last = add;
                return;
            }
            else
            {
                var add = new Knoten<T>(Last, NewNode, null);
                Last.Right = add;
                Last = add;
            }
        }

        public void AddRange(Liste<T> AListe)
        {
            var Help = AListe.First;

            for (int i = 0; i < AListe.Count(); i++)
            {
                Add(Help.Value);
                Help = Help.Right;
            }
        }

        public void Clear()
        {
            First = Last = null;
        }

        public bool Contains(T Wert)
        {
            
            bool IstEnthalten = false;

            while (First.Right != null)
            {
                var ListenWert = First.Value;

                if (ListenWert.Equals(Wert))
                {
                    IstEnthalten = true;
                    break;
                }
                First = First.Right;
            }

            return IstEnthalten;
        }

        public void Exists()
        {

        }

        public void Display()
        {
            Knoten<T> Start = First;

            if (Start == null)
            {
                Console.WriteLine("Die Liste ist aktuell Leer");
            }

            while (Start != null)
            {
                Console.WriteLine(Start.Value);
                Start = Start.Right;
            }
        }
    }
}
