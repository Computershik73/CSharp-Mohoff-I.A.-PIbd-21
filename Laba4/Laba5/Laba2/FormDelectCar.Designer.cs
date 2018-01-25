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
            this.labelCar.Location = new System.Drawing.Point(547, 43);
            this.labelCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(94, 15);
            this.labelCar.TabIndex = 0;
            this.labelCar.Text = "военная техника";
            this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LebelCar_MouseDown);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(11, 28);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(473, 238);
            this.pictureBoxCar.TabIndex = 1;
            this.pictureBoxCar.TabStop = false;
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.Controls.Add(this.labelDopColor);
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Controls.Add(this.labelBaseColor);
            this.panelCar.Location = new System.Drawing.Point(9, 15);
            this.panelCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(496, 329);
            this.panelCar.TabIndex = 2;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.AutoSize = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(240, 280);
            this.labelDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(123, 15);
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
            this.labelBaseColor.Location = new System.Drawing.Point(52, 280);
            this.labelBaseColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(80, 15);
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
            this.panelColor.Location = new System.Drawing.Point(655, 21);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(224, 255);
            this.panelColor.TabIndex = 4;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(90, 154);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(46, 48);
            this.panelBlue.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(13, 154);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(46, 48);
            this.panelYellow.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelWhite.Location = new System.Drawing.Point(159, 86);
            this.panelWhite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(46, 48);
            this.panelWhite.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(90, 86);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(46, 48);
            this.panelRed.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(13, 86);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(46, 48);
            this.panelGreen.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Silver;
            this.panelGray.Location = new System.Drawing.Point(159, 15);
            this.panelGray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(46, 48);
            this.panelGray.TabIndex = 1;
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Goldenrod;
            this.panelGold.Location = new System.Drawing.Point(90, 15);
            this.panelGold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(46, 48);
            this.panelGold.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(13, 15);
            this.panelBlack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(46, 48);
            this.panelBlack.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(560, 258);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(56, 19);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // labelVnedorozhnik
            // 
            this.labelVnedorozhnik.AllowDrop = true;
            this.labelVnedorozhnik.AutoSize = true;
            this.labelVnedorozhnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVnedorozhnik.Location = new System.Drawing.Point(543, 107);
            this.labelVnedorozhnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVnedorozhnik.Name = "labelVnedorozhnik";
            this.labelVnedorozhnik.Size = new System.Drawing.Size(32, 15);
            this.labelVnedorozhnik.TabIndex = 6;
            this.labelVnedorozhnik.Text = "танк";
            this.labelVnedorozhnik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelVnedorozhnik_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(547, 185);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(69, 19);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // FormDelectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 354);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelVnedorozhnik);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.panelCar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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