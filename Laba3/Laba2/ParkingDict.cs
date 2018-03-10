using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Port<T>
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defValue;

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defValue;
            }
        }

        private bool CheckFreePlaces(int index)
        {
            return !places.ContainsKey(index);
        }

        private void AddShip(int index, T ship)
        {
            places[index] = ship;
        }

        private T GetShip(int index)
        {
            T ship = places[index];
            places[index] = defValue;
            return ship;
        }

        public static int operator +(Port<T> p, T ship)
        {
            if (p.places.Count == p.maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlaces(i))
                {
                    p.AddShip(i, ship);
                    return i;
                }
            }
            p.places.Add(p.places.Count, ship);
            return p.places.Count - 1;
        }

        public static T operator -(Port<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T ship = p.places[index];
                p.places.Remove(index);
                return ship;
            }
            return p.defValue;
        }

        public Port(int size, T defVal)
        {
            defValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }
    }
}
