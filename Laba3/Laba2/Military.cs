using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Military : Vehicle
    {
		protected float startPosX;
		protected float startPosY;

        public override int maxSpeed
        {
            get
            {
                return base.maxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 40)
                {
                    base.maxSpeed = value;
                }
                else
                {
                    base.maxSpeed = 20;
                }
            }
        }

        public override int maxCrew
        {
            get
            {
                return base.maxCrew;
            }

            protected set
            {
                if (value > 100 && value < 400)
                {
                    base.maxCrew = value;
                }
                else
                {
                    base.maxCrew = 300;
                }
            }
        }

        public override double displacement
        {
            get
            {
                return base.displacement;
            }

            protected set
            {
                if (value > 8000 && value < 12000)
                {
                    base.displacement = value;
                }
                else
                {
                    base.displacement = 9000;
                }
            }
        }

        public Military(int maxSpeed, int maxCrew, double displacement, Color color1, Color color2)
        {
            this.maxSpeed = maxSpeed;
            this.maxCrew = maxCrew;
            this.ColorBody1 = color1;
            this.ColorBody2 = color2;
            this.displacement = displacement;
            this.CrewCount = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void moveCar(Graphics g)
        {
            startPosX += (maxSpeed * 50 / ((float)displacement / 100)) / (CrewCount == 0 ? 1 : CrewCount);
            drawCar(g);
        }

        public override void drawCar(Graphics g)
        {
            drawNormalSudno(g);
        }

        protected virtual void drawNormalSudno(Graphics g)
        {
            
            Brush grayB = new SolidBrush(ColorBody1);
            Brush brownB = new SolidBrush(Color.SandyBrown);
            Brush grayDB = new SolidBrush(ColorBody2);

            Brush br = new SolidBrush(ColorBody1);
            g.FillRectangle(br, startPosX, startPosY, 150, 100);
            g.FillRectangle(br, startPosX + 180, startPosY, 30, 100);

            //стекла 
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, startPosX - 10, startPosY, 10, 100);
            g.FillRectangle(brBlue, startPosX + 150, startPosY, 30, 100);

            //выделяем рамкой крышу 
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, startPosX, startPosY, 150, 100);
            g.DrawRectangle(pen, startPosX + 180, startPosY, 30, 100);
            g.DrawRectangle(pen, startPosX - 10, startPosY, 220, 100);

            //фары
            Brush brY = new SolidBrush(Color.Yellow);
            g.FillRectangle(brY, startPosX + 200, startPosY, 10, 30);
            g.FillRectangle(brY, startPosX + 200, startPosY + 70, 10, 30);
            Brush brR = new SolidBrush(Color.Red);
            g.FillRectangle(brR, startPosX - 15, startPosY, 5, 20);
            g.FillRectangle(brR, startPosX - 15, startPosY + 80, 5, 20);
        }

		public override void setPos(int x, int y)
		{
			startPosX = x;
			startPosY = y;
		}
    }
}