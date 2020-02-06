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
        //------------------------------------------------------------------------------------------------------------------------
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
        //------------------------------------------------------------------------------------------------------------------------
        public void AddRange(Liste<T> AListe)
        {
            var Help = AListe.First;

            for (int i = 0; i < AListe.Count(); i++)
            {
                Add(Help.Value);
                Help = Help.Right;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        public void Clear()
        {
            First = Last = null;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public bool Contains(T Wert)
        {

            bool IstEnthalten = false;
            var Start = First;

            while (Start.Right != null)
            {
                var ListenWert = Start.Value;

                if (ListenWert.Equals(Wert))
                {
                    IstEnthalten = true;
                    break;
                }
                Start = Start.Right;
            }

            return IstEnthalten;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public int IndexOf(T Wert)
        {
            int Index = 0;
            var Start = First;

            while (Start != null)
            {
                if (Start.Value.Equals(Wert))
                    return Index;
                else
                {
                    Start = Start.Right;
                    Index++;
                }
            }
            return -1;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public int IndexOf(T Wert, int Index)
        {
            var Start = First;
            var hilfe = 0;

            while (hilfe < Index)
            {
                Start = Start.Right;
                hilfe++;
            }

            while (Index <= Count() - 1)
            {
                if (Start.Value.Equals(Wert))
                    return Index;
                else
                {
                    Start = Start.Right;
                    Index++;
                }
            }
            return -1;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public T[] ToArray()
        {
            T[] Ergebnis = new T[Count()];
            var Start = First;

            for (int i = 0; i < Count(); i++)
            {
                Ergebnis[i] = Start.Value;
                Start = Start.Right;
            }
            return Ergebnis;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public void Remove(T Item)
        {
            var Start = First;
            var Hilfszähler = First.Right;

            if (Start.Value.Equals(Item))
            {
                First = First.Right;
                return;
            }

            while (Start != null)
            {
                if (Start.Value.Equals(Item))
                {
                    Start.Left.Right = Start.Right;
                    Start.Right.Left = Start.Left;
                    break;
                }
                else
                {
                    Start = Start.Right;
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        public void RemoveAt(int Index)
        {
            var Counter = 0;
            var Start = First;

            if (Index == 0) // Für den Fall das Index 0 gelöscht werden soll
            {
                First = First.Right;
                return;
            }

            if (Index == Count() - 1)
            {
                Last = Last.Left;
                Last.Right = null;
            }

            if (Index < Count() - 1)
            {
                while (Counter <= Index)
                {
                    if (Counter == Index)
                    {
                        Start.Left.Right = Start.Right;
                        Start.Right.Left = Start.Left;
                    }
                    else
                        Start = Start.Right;

                    Counter++;
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------

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
