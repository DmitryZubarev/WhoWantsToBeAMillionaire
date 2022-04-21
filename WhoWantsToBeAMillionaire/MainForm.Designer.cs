namespace WhoWantsToBeAMillionaire
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.btnMistake = new System.Windows.Forms.Button();
            this.btnCalling = new System.Windows.Forms.Button();
            this.btn5050 = new System.Windows.Forms.Button();
            this.btnHallSupport = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(79, 390);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(144, 48);
            this.btn3.TabIndex = 1;
            this.btn3.Tag = "3";
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(371, 324);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(144, 48);
            this.btn2.TabIndex = 3;
            this.btn2.Tag = "2";
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(371, 390);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(144, 48);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "4";
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(79, 324);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(144, 48);
            this.btn1.TabIndex = 5;
            this.btn1.Tag = "1";
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(76, 229);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(439, 75);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Text";
            // 
            // lstLevel
            // 
            this.lstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 16;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "   800 000",
            "   400 000",
            "   200 000",
            "   100 000",
            "     50 000",
            "     25 000",
            "     15 000",
            "     10 000",
            "       5 000",
            "       3 000",
            "       2 000",
            "       1 000",
            "          500"});
            this.lstLevel.Location = new System.Drawing.Point(507, 15);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(73, 244);
            this.lstLevel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnChangeQuestion);
            this.panel1.Controls.Add(this.btnMistake);
            this.panel1.Controls.Add(this.btnCalling);
            this.panel1.Controls.Add(this.btn5050);
            this.panel1.Controls.Add(this.btnHallSupport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 102);
            this.panel1.TabIndex = 8;
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.BackColor = System.Drawing.Color.White;
            this.btnChangeQuestion.Location = new System.Drawing.Point(223, 28);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(145, 42);
            this.btnChangeQuestion.TabIndex = 5;
            this.btnChangeQuestion.Text = "Замена вопроса";
            this.btnChangeQuestion.UseVisualStyleBackColor = false;
            this.btnChangeQuestion.Click += new System.EventHandler(this.btnChangeQuestion_Click);
            // 
            // btnMistake
            // 
            this.btnMistake.BackColor = System.Drawing.Color.White;
            this.btnMistake.Location = new System.Drawing.Point(435, 52);
            this.btnMistake.Name = "btnMistake";
            this.btnMistake.Size = new System.Drawing.Size(145, 42);
            this.btnMistake.TabIndex = 4;
            this.btnMistake.Text = "Право на ошибку";
            this.btnMistake.UseVisualStyleBackColor = false;
            this.btnMistake.Click += new System.EventHandler(this.btnMistake_Click);
            // 
            // btnCalling
            // 
            this.btnCalling.BackColor = System.Drawing.Color.White;
            this.btnCalling.Location = new System.Drawing.Point(435, 4);
            this.btnCalling.Name = "btnCalling";
            this.btnCalling.Size = new System.Drawing.Size(145, 42);
            this.btnCalling.TabIndex = 3;
            this.btnCalling.Text = "Звонок другу";
            this.btnCalling.UseVisualStyleBackColor = false;
            this.btnCalling.Click += new System.EventHandler(this.btnCalling_Click);
            // 
            // btn5050
            // 
            this.btn5050.BackColor = System.Drawing.Color.White;
            this.btn5050.Location = new System.Drawing.Point(12, 52);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(145, 42);
            this.btn5050.TabIndex = 2;
            this.btn5050.Text = "50/50";
            this.btn5050.UseVisualStyleBackColor = false;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // btnHallSupport
            // 
            this.btnHallSupport.BackColor = System.Drawing.Color.White;
            this.btnHallSupport.Location = new System.Drawing.Point(12, 4);
            this.btnHallSupport.Name = "btnHallSupport";
            this.btnHallSupport.Size = new System.Drawing.Size(145, 42);
            this.btnHallSupport.TabIndex = 0;
            this.btnHallSupport.Text = "Помощь зала";
            this.btnHallSupport.UseVisualStyleBackColor = false;
            this.btnHallSupport.Click += new System.EventHandler(this.btnHallSupport_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnScores.Location = new System.Drawing.Point(12, 15);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(117, 40);
            this.btnScores.TabIndex = 9;
            this.btnScores.Text = "Таблица крутых";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 556);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "WWTBM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button btnHallSupport;
        private System.Windows.Forms.Button btnChangeQuestion;
        private System.Windows.Forms.Button btnMistake;
        private System.Windows.Forms.Button btnCalling;
        private System.Windows.Forms.Button btnScores;
    }
}

