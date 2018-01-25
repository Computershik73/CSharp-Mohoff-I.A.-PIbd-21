namespace Laba2
{
    partial class FormDelectCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCar = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panelCar = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.labelVnedorozhnik = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.panelCar.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCar
            // 
            this.labelCar.AllowDrop = true;
            this.labelCar.AutoSize = true;
            this.labelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCar.Location = new System.Drawing.Point(729, 53);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(32, 19);
            this.labelCar.TabIndex = 0;
            this.labelCar.Text = "Car";
            this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LebelCar_MouseDown);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(15, 34);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(631, 293);
            this.pictureBoxCar.TabIndex = 1;
            this.pictureBoxCar.TabStop = false;
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.Controls.Add(this.labelDopColor);
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Controls.Add(this.labelBaseColor);
            this.panelCar.Location = new System.Drawing.Point(12, 19);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(662, 405);
            this.panelCar.TabIndex = 2;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.AutoSize = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(320, 345);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(159, 19);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.lebelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.AutoSize = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(70, 345);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(101, 19);
            this.labelBaseColor.TabIndex = 3;
            this.labelBaseColor.Text = "Базовый цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.lebelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.lebelBaseColor_DragEnter);
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelWhite);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelGray);
            this.panelColor.Controls.Add(this.panelGold);
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Location = new System.Drawing.Point(873, 26);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(298, 314);
            this.panelColor.TabIndex = 4;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(120, 190);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(62, 59);
            this.panelBlue.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(17, 190);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(62, 59);
            this.panelYellow.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelWhite.Location = new System.Drawing.Point(212, 106);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(62, 59);
            this.panelWhite.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(120, 106);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(62, 59);
            this.panelRed.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(17, 106);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(62, 59);
            this.panelGreen.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Silver;
            this.panelGray.Location = new System.Drawing.Point(212, 18);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(62, 59);
            this.panelGray.TabIndex = 1;
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Goldenrod;
            this.panelGold.Location = new System.Drawing.Point(120, 18);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(62, 59);
            this.panelGold.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(17, 18);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(62, 59);
            this.panelBlack.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(746, 317);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // labelVnedorozhnik
            // 
            this.labelVnedorozhnik.AllowDrop = true;
            this.labelVnedorozhnik.AutoSize = true;
            this.labelVnedorozhnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVnedorozhnik.Location = new System.Drawing.Point(724, 132);
            this.labelVnedorozhnik.Name = "labelVnedorozhnik";
            this.labelVnedorozhnik.Size = new System.Drawing.Size(97, 19);
            this.labelVnedorozhnik.TabIndex = 6;
            this.labelVnedorozhnik.Text = "Vnedorozhnik";
            this.labelVnedorozhnik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelVnedorozhnik_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(729, 228);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(92, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // FormDelectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 436);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelVnedorozhnik);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.panelCar);
            this.Name = "FormDelectCar";
            this.Text = "FormDelectCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label labelVnedorozhnik;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Button buttonOk;
    }
}