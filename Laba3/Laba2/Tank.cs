using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tank : Military
    {
        private bool frontCannon;
        private bool backCannon;
        private Color dopColor;
        private Color dopColor1;

        public Tank(int maxSpeed, int maxCrew, double displacement, Color mainC, bool frontCannon, bool backCannon, Color dopC, Color secondC) : base(maxSpeed, maxCrew, displacement, mainC, secondC)
        {
            this.frontCannon = frontCannon;
            this.backCannon = backCannon;
            this.dopColor = dopC;
            this.dopColor1 = secondC;
        }

        protected override void drawNormalSudno(Graphics g)
        {
            base.drawNormalSudno(g);
            frontCannon = true;
            if (frontCannon)
            {
                Brush spoiler = new SolidBrush(dopColor);

                g.FillRectangle(spoiler, startPosX - 25, startPosY, 20, 100);
                g.FillEllipse(spoiler, startPosX - 27, startPosY - 10, 20, 20);
                g.FillEllipse(spoiler, startPosX - 27, startPosY + 90, 20, 15);

                g.FillRectangle(spoiler, startPosX + 212, startPosY, 15, 100);
                g.FillEllipse(spoiler, startPosX + 212, startPosY - 10, 15, 20);
                g.FillEllipse(spoiler, startPosX + 212, startPosY + 90, 15, 15);
            }
            backCannon = true;
            if (backCannon)
            {
                Brush sp = new SolidBrush(dopColor);
                g.FillRectangle(sp, startPosX - 25, startPosY + 25, 15, 50);
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen, startPosX - 25, startPosY + 25, 15, 50);
            }
        }
    }
}
