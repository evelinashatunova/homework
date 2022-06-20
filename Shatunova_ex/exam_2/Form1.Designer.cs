
namespace exam_task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonJPG = new System.Windows.Forms.RadioButton();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.radioButtonBMP = new System.Windows.Forms.RadioButton();
            this.formatLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(30, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "folder";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.Location = new System.Drawing.Point(296, 516);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(146, 41);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "Каталог";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(296, 563);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 35);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(63, 386);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 212);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButtonJPG
            // 
            this.radioButtonJPG.AutoSize = true;
            this.radioButtonJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJPG.Location = new System.Drawing.Point(326, 418);
            this.radioButtonJPG.Name = "radioButtonJPG";
            this.radioButtonJPG.Size = new System.Drawing.Size(69, 22);
            this.radioButtonJPG.TabIndex = 5;
            this.radioButtonJPG.TabStop = true;
            this.radioButtonJPG.Text = "JPEG";
            this.radioButtonJPG.UseVisualStyleBackColor = true;
            this.radioButtonJPG.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonPNG
            // 
            this.radioButtonPNG.AutoSize = true;
            this.radioButtonPNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPNG.Location = new System.Drawing.Point(326, 448);
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.Size = new System.Drawing.Size(62, 22);
            this.radioButtonPNG.TabIndex = 6;
            this.radioButtonPNG.TabStop = true;
            this.radioButtonPNG.Text = "PNG";
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            this.radioButtonPNG.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonBMP
            // 
            this.radioButtonBMP.AutoSize = true;
            this.radioButtonBMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBMP.Location = new System.Drawing.Point(326, 478);
            this.radioButtonBMP.Name = "radioButtonBMP";
            this.radioButtonBMP.Size = new System.Drawing.Size(62, 22);
            this.radioButtonBMP.TabIndex = 7;
            this.radioButtonBMP.TabStop = true;
            this.radioButtonBMP.Text = "BMP";
            this.radioButtonBMP.UseVisualStyleBackColor = true;
            this.radioButtonBMP.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatLabel.Location = new System.Drawing.Point(322, 395);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(64, 18);
            this.formatLabel.TabIndex = 8;
            this.formatLabel.Text = "Формат";
            this.formatLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 635);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.radioButtonBMP);
            this.Controls.Add(this.radioButtonPNG);
            this.Controls.Add(this.radioButtonJPG);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр изображений";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonJPG;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.RadioButton radioButtonBMP;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

