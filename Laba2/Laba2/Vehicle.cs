using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public abstract class Vehicle : ITransport
    {
        protected float startPosX;
        protected float startPosY;
        protected int countPassengers;
        protected int countToplivo;
        public virtual int MaxCountPassengers { protected set; get; }
        public virtual int MaxCountToplivo { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }
        public Color ColorBody { protected set; get; }
        public virtual double Weight { protected set; get; }
        public abstract void moveCar(Graphics g);
        public abstract void drawCar(Graphics g);
        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }
        public void loadPassenger(int count)
        {
            if (countPassengers + count < MaxCountPassengers)
            {
                countPassengers += count;
            }
        }
        public int getPassenger()
        {
            int count = countPassengers;
            countPassengers = 0;
            return count;
        }
        public void loadToplivo(int count)
        {
            if (countToplivo + count < MaxCountToplivo)
            {
                countToplivo += count;
            }
        }
        public int getToplivo()
        {
            int count = countToplivo;
            countToplivo = 0;
            return count;


        }
    }
}
