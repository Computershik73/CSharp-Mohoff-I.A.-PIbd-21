using NLog;
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
    public partial class Form2 : Form
    {


        Parking parking;
        FormDelectCar form;
        int placesSizeWidth = 250;
        int placeSizeHight = 150;

        private Logger log;

        public Form2()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            parking = new Parking(5);
            for (int i = 1; i < 6; i++)
            {
                listBox.Items.Add("Уровень " + i);
            }
            listBox.SelectedIndex = parking.getCurrentLevel;

            Draw();
        }
        /// <summary>
        /// Метод для отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBox.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)

                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr, placesSizeWidth, placeSizeHight);
                pictureBoxParking.Image = bmp;
            }
        }

        
        private void button1_Click(object sender, EventArgs e) //down
        {
            parking.LevelDown();
            listBox.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на уровень ниже. Текущий уровень: " + parking.getCurrentLevel);
            Draw();
        }

        private void button2_Click(object sender, EventArgs e) //up
        {
            parking.LevelUp();
            listBox.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на уровень выше. Текущий уровень: " + parking.getCurrentLevel);
            Draw();
        }


        private void buttonSetCar_Click_1(object sender, EventArgs e)
        {
    
            form = new FormDelectCar();
            form.AddEvent(AddCar);
            form.Show();
            log.Info("Меню для выборки цвета для машины");
            
        }

        private void AddCar(ITransport car)
        {
            if (car != null)
            {
                
                try
                {
                    int place = parking.PutCarInParking(car);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                    log.Info("Машина или внедорожник добавлены");
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            }
        }


        private void buttonSetVnedorozhnik_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var car = new Tank(100, 4, 10, 1600,dialog.Color, true, true, true, dialogDop.Color);
                    int place = parking.PutCarInParking(car);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                    log.Info("Припаркован Внедорожник на место " + place);
                }
            }
            
        }

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > -1)
            {
                string level = listBox.Items[listBox.SelectedIndex].ToString();

                if (maskedTextBox1.Text != "")
                {
                    try
                    {
                        ITransport car = parking.GetCarInParking(Convert.ToInt32(maskedTextBox1.Text));
                        if (car != null)
                        {//если удалось забрать, то отрисовываем
                            Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            car.setPosition(150, 5);
                            car.drawCar(gr);
                            pictureBoxTakeCar.Image = bmp;
                            Draw();
                        }
                        log.Info("Машину или Внедорожник забрали");

                    }
                    catch (ParkingIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }   
                
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }

        }


    }

    }


