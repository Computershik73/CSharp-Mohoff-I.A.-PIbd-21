using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public interface ITransport
    {
       
        void moveCar(Graphics g);

        void drawCar(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        void loadToplivo(int count);
        int getPassenger();
        int getToplivo();

        void setMainColor(Color color);

        string getInfo();
    }
}
