namespace Kulck_IMT_Voloshyn_Vitalii_Kursova_Pd_22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultOutput = new System.Windows.Forms.TextBox();
            this.femalePicture = new System.Windows.Forms.PictureBox();
            this.sexChoice = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.malePicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.femalePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рост";
            // 
            // heightInput
            // 
            this.heightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightInput.Location = new System.Drawing.Point(29, 61);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 22);
            this.heightInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(275, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес";
            // 
            // weightInput
            // 
            this.weightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightInput.Location = new System.Drawing.Point(238, 61);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(106, 22);
            this.weightInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Росчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultOutput
            // 
            this.resultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultOutput.Location = new System.Drawing.Point(87, 256);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(222, 38);
            this.resultOutput.TabIndex = 11;
            // 
            // femalePicture
            // 
            this.femalePicture.Image = ((System.Drawing.Image)(resources.GetObject("femalePicture.Image")));
            this.femalePicture.Location = new System.Drawing.Point(12, 320);
            this.femalePicture.Name = "femalePicture";
            this.femalePicture.Size = new System.Drawing.Size(381, 180);
            this.femalePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.femalePicture.TabIndex = 12;
            this.femalePicture.TabStop = false;
            this.femalePicture.Visible = false;
            // 
            // sexChoice
            // 
            this.sexChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexChoice.FormattingEnabled = true;
            this.sexChoice.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexChoice.Location = new System.Drawing.Point(120, 115);
            this.sexChoice.Name = "sexChoice";
            this.sexChoice.Size = new System.Drawing.Size(144, 24);
            this.sexChoice.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(204, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // malePicture
            // 
            this.malePicture.BackColor = System.Drawing.Color.White;
            this.malePicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("malePicture.ErrorImage")));
            this.malePicture.Image = ((System.Drawing.Image)(resources.GetObject("malePicture.Image")));
            this.malePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("malePicture.InitialImage")));
            this.malePicture.Location = new System.Drawing.Point(12, 320);
            this.malePicture.Name = "malePicture";
            this.malePicture.Size = new System.Drawing.Size(381, 180);
            this.malePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.malePicture.TabIndex = 17;
            this.malePicture.TabStop = false;
            this.malePicture.Visible = false;
            this.malePicture.Click += new System.EventHandler(this.malePicture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Выберите пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "(190)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(350, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "(80)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(122, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Индекс Масы Тела";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(405, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.malePicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sexChoice);
            this.Controls.Add(this.femalePicture);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Калькулятор ИМТ";
            ((System.ComponentModel.ISupportInitialize)(this.femalePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultOutput;
        private System.Windows.Forms.PictureBox femalePicture;
        private System.Windows.Forms.ComboBox sexChoice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox malePicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

