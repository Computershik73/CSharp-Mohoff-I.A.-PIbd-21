using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface ITransport
    {
        void moveCar(Graphics g);
        void drawCar(Graphics g);
        void setPos(int x, int y);
        void loadCrew(int count);
        int getCrew();
    }
}