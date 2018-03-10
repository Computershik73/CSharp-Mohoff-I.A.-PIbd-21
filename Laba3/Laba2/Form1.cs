using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form : System.Windows.Forms.Form
    {
        Parking parking;

        public Form()
        {
            InitializeComponent();
            parking = new Parking(5);
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Порт №" + i);
            }
            listBox1.SelectedIndex = parking.getLVL;
            DrawPort();
        }

        private void DrawPort()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(picture.Width, picture.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                picture.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var ship = new Military(30, 300, 9000, dialog.Color, dialogDop.Color);
                    int place = parking.PutInParking(ship);
                    DrawPort();
                    MessageBox.Show("Ваше место: " + (place + 1));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorDialog dialogDopp = new ColorDialog();
                    if (dialogDopp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var ship = new Tank(30, 300, 9000, dialog.Color, true, true, dialogDop.Color, dialogDopp.Color);
                        int place = parking.PutInParking(ship);
                        DrawPort();
                        MessageBox.Show("Ваше место: " + (place + 1));
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string LVL = listBox1.Items[listBox1.SelectedIndex].ToString();
            if (maskedTextBox1.Text != "")
            {
                ITransport ship = parking.GetInParking(Convert.ToInt32(maskedTextBox1.Text) - 1);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureTake.Width, pictureTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.setPos(15, 10);
                    ship.drawCar(gr);
                    pictureTake.Image = bmp;
                    DrawPort();
                }
                else
                {
                    MessageBox.Show("Здесь пусто");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBox1.SelectedIndex = parking.getLVL;
            DrawPort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBox1.SelectedIndex = parking.getLVL;
            DrawPort();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        { }
        private void label1_Click(object sender, EventArgs e)
        { }
    }
}