using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Parking
    {
        List<Port<ITransport>> pStages;
        int countPlaces = 15;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLVL;
        public int getLVL { get { return currentLVL; } }

        public Parking(int countStages)
        {
            pStages = new List<Port<ITransport>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                pStages.Add(new Port<ITransport>(countPlaces, null));
            }
        }

        public void LevelUp()
        {
            if(currentLVL + 1 < pStages.Count)
            {
                currentLVL++;
            }
        }

        public void LevelDown()
        {
            if (currentLVL > 0)
            {
                currentLVL--;
            }
        }

        public int PutInParking(ITransport ship)
        {
            return pStages[currentLVL] + ship;
        }

        public ITransport GetInParking(int ticket)
        {
            return pStages[currentLVL] - ticket;
        }

        public void DrawPort(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("P" + (currentLVL + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for(int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }

        public void Draw(Graphics g)
        {
            DrawPort(g);
            for(int i = 0; i < countPlaces; i++)
            {
                var ship = pStages[currentLVL][i];
                if (ship != null)
                {
                    ship.setPos(20 + i / 5 * placeSizeWidth, i % 5 * placeSizeHeight + 15);
                    ship.drawCar(g);
                }
            }
        }
    }
}
