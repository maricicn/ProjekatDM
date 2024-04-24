namespace ProjekatDM
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            cBSkola = new ComboBox();
            tBIme = new TextBox();
            tBPrezime = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cBOdeljenje = new TextBox();
            cBPrviPredmet = new ComboBox();
            label6 = new Label();
            cBDrugiPredmet = new ComboBox();
            label7 = new Label();
            cBTreciPredmet = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            cBTemplate = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label14 = new Label();
            label17 = new Label();
            comboBox4 = new ComboBox();
            label16 = new Label();
            comboBox3 = new ComboBox();
            label15 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label18 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 30);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 0;
            label1.Text = "Dodavanje učenika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 101);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Škola";
            // 
            // cBSkola
            // 
            cBSkola.FormattingEnabled = true;
            cBSkola.Location = new Point(267, 119);
            cBSkola.Name = "cBSkola";
            cBSkola.Size = new Size(213, 23);
            cBSkola.TabIndex = 2;
            cBSkola.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tBIme
            // 
            tBIme.Location = new Point(71, 119);
            tBIme.Name = "tBIme";
            tBIme.Size = new Size(143, 23);
            tBIme.TabIndex = 3;
            // 
            // tBPrezime
            // 
            tBPrezime.Location = new Point(71, 189);
            tBPrezime.Name = "tBPrezime";
            tBPrezime.Size = new Size(143, 23);
            tBPrezime.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 101);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Ime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 171);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Prezime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 171);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Odeljenje";
            // 
            // cBOdeljenje
            // 
            cBOdeljenje.Location = new Point(267, 189);
            cBOdeljenje.Name = "cBOdeljenje";
            cBOdeljenje.Size = new Size(213, 23);
            cBOdeljenje.TabIndex = 8;
            // 
            // cBPrviPredmet
            // 
            cBPrviPredmet.FormattingEnabled = true;
            cBPrviPredmet.Location = new Point(550, 119);
            cBPrviPredmet.Name = "cBPrviPredmet";
            cBPrviPredmet.Size = new Size(178, 23);
            cBPrviPredmet.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 101);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 10;
            label6.Text = "Prvi predmet";
            // 
            // cBDrugiPredmet
            // 
            cBDrugiPredmet.FormattingEnabled = true;
            cBDrugiPredmet.Location = new Point(550, 187);
            cBDrugiPredmet.Name = "cBDrugiPredmet";
            cBDrugiPredmet.Size = new Size(178, 23);
            cBDrugiPredmet.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 169);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 12;
            label7.Text = "Drugi predmet";
            // 
            // cBTreciPredmet
            // 
            cBTreciPredmet.FormattingEnabled = true;
            cBTreciPredmet.Location = new Point(550, 259);
            cBTreciPredmet.Name = "cBTreciPredmet";
            cBTreciPredmet.Size = new Size(178, 23);
            cBTreciPredmet.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(550, 241);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 14;
            label8.Text = "Treći predmet";
            // 
            // button1
            // 
            button1.Location = new Point(338, 313);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 16;
            button1.Text = "Dodaj učenika";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cBTemplate
            // 
            cBTemplate.FormattingEnabled = true;
            cBTemplate.Location = new Point(71, 277);
            cBTemplate.Name = "cBTemplate";
            cBTemplate.Size = new Size(178, 23);
            cBTemplate.TabIndex = 18;
            cBTemplate.SelectedIndexChanged += cBTemplate_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 259);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 17;
            label9.Text = "Odaberite šablon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1060, 30);
            label10.Name = "label10";
            label10.Size = new Size(218, 40);
            label10.TabIndex = 19;
            label10.Text = "Pregled učenika";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(969, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(969, 101);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 21;
            label11.Text = "Ime";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(969, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(969, 171);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 23;
            label12.Text = "Prezime";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(969, 238);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 24;
            label13.Text = "Škola";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(969, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(969, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(969, 310);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 27;
            label14.Text = "Odeljenje";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1239, 101);
            label17.Name = "label17";
            label17.Size = new Size(75, 15);
            label17.TabIndex = 28;
            label17.Text = "Prvi predmet";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1239, 119);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(178, 23);
            comboBox4.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1239, 169);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 30;
            label16.Text = "Drugi predmet";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1239, 187);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(178, 23);
            comboBox3.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1239, 241);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 32;
            label15.Text = "Treći predmet";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1239, 259);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 23);
            comboBox2.TabIndex = 33;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Bright", 20.25F);
            button2.Location = new Point(1108, 391);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 34;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1239, 391);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 35;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1357, 391);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 36;
            button4.Text = ">>";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(969, 391);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 37;
            button5.Text = "<<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1178, 504);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 38;
            label18.Text = "label18";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 756);
            Controls.Add(label18);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label15);
            Controls.Add(comboBox3);
            Controls.Add(label16);
            Controls.Add(comboBox4);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(cBTemplate);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(cBTreciPredmet);
            Controls.Add(label8);
            Controls.Add(cBDrugiPredmet);
            Controls.Add(label7);
            Controls.Add(cBPrviPredmet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cBOdeljenje);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tBPrezime);
            Controls.Add(tBIme);
            Controls.Add(cBSkola);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public ComboBox cBSkola;
        private TextBox tBIme;
        private TextBox tBPrezime;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cBOdeljenje;
        public ComboBox cBPrviPredmet;
        private Label label6;
        public ComboBox cBDrugiPredmet;
        private Label label7;
        public ComboBox cBTreciPredmet;
        private Label label8;
        private Button button1;
        public ComboBox cBTemplate;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private Label label13;
        public ComboBox comboBox1;
        private TextBox textBox3;
        private Label label14;
        private Label label17;
        public ComboBox comboBox4;
        private Label label16;
        public ComboBox comboBox3;
        private Label label15;
        public ComboBox comboBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label18;
    }
}