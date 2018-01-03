using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class FormDelectCar : Form
    {

        /// <summary> 
        /// Переменная-выбранная машина 
        /// </summary> 
        ITransport car = null;
        /// <summary> 
        /// Получить машину 
        /// </summary> 
        public ITransport getCar { get { return car; } }
        /// <summary> 
        /// Отрисовать машину 
        /// </summary> 
        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(50, 5);
                car.drawCar(gr);
                pictureBoxCar.Image = bmp;
            }
        }
        private event myDel eventAddCar;
        /// <summary> 
        /// Добавление события 
        /// </summary> 
        /// <param name="ev"></param> 
        public void AddEvent(myDel ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new myDel(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }
        public FormDelectCar()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            ButtonCancel.Click += (object sender, EventArgs e) => { Close(); };

        }

        private void LebelCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelCar.DoDragDrop(labelCar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {//случаным образом выбриаем какая машина встанет 
                case "Car":
                    car = new Military(100, 4, 3, 500, Color.Black);
                    break;
                case "Vnedorozhnik":
                    car = new Tank(100, 4, 3, 500, Color.Black, true, true, true, Color.Black);
                    break;
            }
            DrawCar();
        }
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lebelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lebelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelVnedorozhnik_MouseDown(object sender, MouseEventArgs e)
        {
            labelVnedorozhnik.DoDragDrop(labelVnedorozhnik.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is Tank)
                {
                    (car as Tank).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }

        

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            if (eventAddCar != null)
            {
                eventAddCar(car);
            }
            Close();
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}

