using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
   public  class Military:Vehicle
    {
        
public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 300)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 3;
                }
            }
        }
        public override int MaxCountToplivo
        {
            get
            {
                return base.MaxCountToplivo;
            }

            protected set
            {
                if (value > 5 && value < 15)
                {
                    base.MaxCountToplivo = value;
                }
                else
                {
                    base.MaxCountToplivo = 10;
                }
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 1500 && value < 3000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1500;
                }
            }
        }
        public Military(int maxSpeed, int maxCountPassengers, int maxCountToplivo, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.MaxCountToplivo = maxCountToplivo;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            this.countToplivo = 0;
            //Random rand = new Random();
            //startPosX = rand.Next(10, 200);
            //startPosY = rand.Next(10, 200);
        }

        public Military(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers= Convert.ToInt32(strs[1]);
                MaxCountToplivo = Convert.ToInt32(strs[2]);
                Weight= Convert.ToInt32(strs[3]);
                ColorBody = Color.FromName(strs[4]);
            }
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }


        
        public override void moveCar(Graphics g)
        {
            startPosX +=
            (MaxSpeed * 50 / (float)Weight) /
            (countToplivo == 0 ? 1 : countToplivo);
            drawCar(g);
        }
        public override void drawCar(Graphics g)
        {
            drawLightCar(g);
        }
        protected virtual void drawLightCar(Graphics g)
        {
            //границы военной техники 
       
            //кузов 
            Brush br = new SolidBrush(ColorBody);
            g.FillRectangle(br, startPosX, startPosY, 150, 100);
            g.FillRectangle(br, startPosX + 180, startPosY , 30, 100);

            //стекла 
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, startPosX-10, startPosY, 10, 100);
            g.FillRectangle(brBlue, startPosX + 150, startPosY, 30, 100);

            //выделяем рамкой крышу 
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, startPosX, startPosY, 150, 100);
            g.DrawRectangle(pen, startPosX + 180, startPosY, 30, 100);
            g.DrawRectangle(pen, startPosX-10, startPosY, 220, 100);

            //фары
            Brush brY = new SolidBrush(Color.Yellow);
            g.FillRectangle(brY, startPosX+200, startPosY, 10, 30);
            g.FillRectangle(brY, startPosX + 200, startPosY+70, 10, 30);
            Brush brR = new SolidBrush(Color.Red);
            g.FillRectangle(brR, startPosX -15, startPosY, 5, 20);
            g.FillRectangle(brR, startPosX -15, startPosY+80 , 5, 20);


        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + MaxCountToplivo + ";"
                + Weight + ";" + ColorBody.Name;
        }
    }
}
