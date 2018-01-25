using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Parking
    {
        ClassArray<ITransport> parking;
        
        List< ClassArray<ITransport>> parkingStages;
        int countPlaces = 20;
        int placesSizeWidth = 250;
        int placeSizeHight = 150;
        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }
        public Parking(int countStages)
       {
            parkingStages = new List<ClassArray<ITransport>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                parking= new ClassArray<ITransport>(countPlaces,null);
                parkingStages.Add(parking);
            }
            
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelDown()
        {
            if(currentLevel>0)
                {
                currentLevel--;
            }
        }

        public int PutCarInParking(ITransport car)
        {
            return parkingStages[currentLevel] + car;
        }
        public ITransport GetCarInParking(int ticket)
        {
            return parkingStages[currentLevel] - ticket;
        }
        public void Draw(Graphics g,int width, int heigt)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var car = parkingStages[currentLevel][i];
                if (car!=null)
                {
                    car.setPosition(5 + i / 5 * placesSizeWidth + 25, i % 5 * placeSizeHight + 15);
                    car.drawCar(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placesSizeWidth - 70, 420);

            g.DrawRectangle(pen, 0, 0, (countPlaces / 2) * placeSizeHight, 600);
            g.DrawLine(pen, 0, placeSizeHight,50, placeSizeHight);
            g.DrawLine(pen, 0, placeSizeHight+150, 50, placeSizeHight+150);
            g.DrawLine(pen, 0, placeSizeHight+300, 50, placeSizeHight+300);
            for (int i=0;i<countPlaces/5;i++)
            {
                for (int j=0;j<6;j++)
                {
                    g.DrawLine(pen, i * placesSizeWidth+20, j * placeSizeHight,i * placesSizeWidth + 150, j * placeSizeHight);
                   if(j<5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placesSizeWidth + 30, j * placeSizeHight + 20);
                    }
                }
                
                g.DrawLine(pen, i * placesSizeWidth+270, 0, i * placesSizeWidth+270, 700);
            }
        }
    }
}
