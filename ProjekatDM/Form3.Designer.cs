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
            label19 = new Label();
            comboBox5 = new ComboBox();
            label20 = new Label();
            comboBox6 = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label21 = new Label();
            panelPregled = new Panel();
            button7 = new Button();
            button6 = new Button();
            panelDodavanje = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panelPregled.SuspendLayout();
            panelDodavanje.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 123);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Dodavanje ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 83);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Škola";
            // 
            // cBSkola
            // 
            cBSkola.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSkola.FormattingEnabled = true;
            cBSkola.Location = new Point(223, 101);
            cBSkola.Name = "cBSkola";
            cBSkola.Size = new Size(213, 23);
            cBSkola.TabIndex = 2;
            cBSkola.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tBIme
            // 
            tBIme.Location = new Point(49, 101);
            tBIme.Name = "tBIme";
            tBIme.Size = new Size(150, 23);
            tBIme.TabIndex = 3;
            // 
            // tBPrezime
            // 
            tBPrezime.Location = new Point(49, 171);
            tBPrezime.Name = "tBPrezime";
            tBPrezime.Size = new Size(150, 23);
            tBPrezime.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 83);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Ime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 153);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Prezime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 153);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Odeljenje";
            // 
            // cBOdeljenje
            // 
            cBOdeljenje.Location = new Point(223, 171);
            cBOdeljenje.Name = "cBOdeljenje";
            cBOdeljenje.Size = new Size(213, 23);
            cBOdeljenje.TabIndex = 8;
            // 
            // cBPrviPredmet
            // 
            cBPrviPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cBPrviPredmet.FormattingEnabled = true;
            cBPrviPredmet.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            cBPrviPredmet.Location = new Point(463, 101);
            cBPrviPredmet.Name = "cBPrviPredmet";
            cBPrviPredmet.Size = new Size(213, 23);
            cBPrviPredmet.TabIndex = 11;
            cBPrviPredmet.SelectedIndexChanged += cBPrviPredmet_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 83);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 10;
            label6.Text = "Prvi predmet";
            // 
            // cBDrugiPredmet
            // 
            cBDrugiPredmet.DropDownStyle = ComboBoxStyle.Simple;
            cBDrugiPredmet.Enabled = false;
            cBDrugiPredmet.FormattingEnabled = true;
            cBDrugiPredmet.Location = new Point(463, 169);
            cBDrugiPredmet.Name = "cBDrugiPredmet";
            cBDrugiPredmet.Size = new Size(213, 23);
            cBDrugiPredmet.TabIndex = 13;
            cBDrugiPredmet.Text = "Matematika";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(463, 151);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 12;
            label7.Text = "Drugi predmet";
            // 
            // cBTreciPredmet
            // 
            cBTreciPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cBTreciPredmet.FormattingEnabled = true;
            cBTreciPredmet.Items.AddRange(new object[] { "Biologija", "Geografija", "Engleski jezik", "Istorija", "Italijanski jezik", "Nemački jezik", "Ruski jezik", "Srpski kao nematernji jezik", "Fizika", "Francuski jezik", "Hemija", "Španski jezik" });
            cBTreciPredmet.Location = new Point(463, 241);
            cBTreciPredmet.Name = "cBTreciPredmet";
            cBTreciPredmet.Size = new Size(213, 23);
            cBTreciPredmet.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 223);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 14;
            label8.Text = "Treći predmet";
            // 
            // button1
            // 
            button1.Location = new Point(266, 306);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 16;
            button1.Text = "Dodaj učenika";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cBTemplate
            // 
            cBTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            cBTemplate.FormattingEnabled = true;
            cBTemplate.Location = new Point(238, 38);
            cBTemplate.Name = "cBTemplate";
            cBTemplate.Size = new Size(178, 23);
            cBTemplate.TabIndex = 18;
            cBTemplate.SelectedIndexChanged += cBTemplate_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(238, 20);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 17;
            label9.Text = "Odaberite šablon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 193);
            label10.Name = "label10";
            label10.Size = new Size(122, 40);
            label10.TabIndex = 19;
            label10.Text = "Pregled ";
            label10.Click += label10_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 9);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 21;
            label11.Text = "Ime";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 79);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 23;
            label12.Text = "Prezime";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 146);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 24;
            label13.Text = "Škola";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 218);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 27;
            label14.Text = "Odeljenje";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(278, 79);
            label17.Name = "label17";
            label17.Size = new Size(75, 15);
            label17.TabIndex = 28;
            label17.Text = "Prvi predmet";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            comboBox4.Location = new Point(278, 97);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(192, 23);
            comboBox4.TabIndex = 29;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(278, 147);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 30;
            label16.Text = "Drugi predmet";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.Simple;
            comboBox3.Enabled = false;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(278, 165);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(192, 23);
            comboBox3.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(278, 219);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 32;
            label15.Text = "Treći predmet";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Biologija", "Geografija", "Engleski jezik", "Istorija", "Italijanski jezik", "Nemački jezik", "Ruski jezik", "Srpski kao nematernji jezik", "Fizika", "Francuski jezik", "Hemija", "Španski jezik" });
            comboBox2.Location = new Point(278, 237);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 23);
            comboBox2.TabIndex = 33;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Bright", 20.25F);
            button2.Location = new Point(146, 299);
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
            button3.Location = new Point(293, 299);
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
            button4.Location = new Point(411, 299);
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
            button5.Location = new Point(23, 299);
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
            label18.Location = new Point(236, 405);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 38;
            label18.Text = "label18";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(223, 222);
            label19.Name = "label19";
            label19.Size = new Size(125, 15);
            label19.TabIndex = 39;
            label19.Text = "Jezik na kom se polaže";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Srpski jezik", "Albanski jezik", "Bosanski jezik", "Bugarski jezik", "Mađarski jezik", "Rumunski jezik", "Rusinski jezik", "Slovački jezik", "Hrvatski jezik" });
            comboBox5.Location = new Point(223, 240);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(213, 23);
            comboBox5.TabIndex = 40;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(278, 16);
            label20.Name = "label20";
            label20.Size = new Size(125, 15);
            label20.TabIndex = 41;
            label20.Text = "Jezik na kom se polaže";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Srpski jezik", "Albanski jezik", "Bosanski jezik", "Bugarski jezik", "Mađarski jezik", "Rumunski jezik", "Rusinski jezik", "Slovački jezik", "Hrvatski jezik" });
            comboBox6.Location = new Point(278, 34);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(192, 23);
            comboBox6.TabIndex = 42;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(10, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 42);
            panel1.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Location = new Point(10, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 42);
            panel2.TabIndex = 44;
            panel2.Visible = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(164, 21);
            label21.Name = "label21";
            label21.Size = new Size(335, 50);
            label21.TabIndex = 45;
            label21.Text = "Dodavanje Učenika";
            // 
            // panelPregled
            // 
            panelPregled.Controls.Add(button7);
            panelPregled.Controls.Add(button6);
            panelPregled.Controls.Add(label20);
            panelPregled.Controls.Add(comboBox6);
            panelPregled.Controls.Add(label18);
            panelPregled.Controls.Add(button5);
            panelPregled.Controls.Add(button4);
            panelPregled.Controls.Add(button3);
            panelPregled.Controls.Add(button2);
            panelPregled.Controls.Add(comboBox2);
            panelPregled.Controls.Add(label15);
            panelPregled.Controls.Add(comboBox3);
            panelPregled.Controls.Add(label16);
            panelPregled.Controls.Add(comboBox4);
            panelPregled.Controls.Add(label17);
            panelPregled.Controls.Add(label14);
            panelPregled.Controls.Add(textBox3);
            panelPregled.Controls.Add(comboBox1);
            panelPregled.Controls.Add(label13);
            panelPregled.Controls.Add(label12);
            panelPregled.Controls.Add(textBox2);
            panelPregled.Controls.Add(label11);
            panelPregled.Controls.Add(textBox1);
            panelPregled.Location = new Point(299, 105);
            panelPregled.Name = "panelPregled";
            panelPregled.Size = new Size(484, 428);
            panelPregled.TabIndex = 46;
            panelPregled.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(311, 377);
            button7.Name = "button7";
            button7.Size = new Size(131, 36);
            button7.TabIndex = 44;
            button7.Text = "Izmeni učenika";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(55, 377);
            button6.Name = "button6";
            button6.Size = new Size(131, 36);
            button6.TabIndex = 43;
            button6.Text = "Izbriši učenika";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panelDodavanje
            // 
            panelDodavanje.Controls.Add(label19);
            panelDodavanje.Controls.Add(comboBox5);
            panelDodavanje.Controls.Add(cBTemplate);
            panelDodavanje.Controls.Add(label9);
            panelDodavanje.Controls.Add(button1);
            panelDodavanje.Controls.Add(cBTreciPredmet);
            panelDodavanje.Controls.Add(label8);
            panelDodavanje.Controls.Add(cBDrugiPredmet);
            panelDodavanje.Controls.Add(label7);
            panelDodavanje.Controls.Add(cBPrviPredmet);
            panelDodavanje.Controls.Add(label6);
            panelDodavanje.Controls.Add(label5);
            panelDodavanje.Controls.Add(cBOdeljenje);
            panelDodavanje.Controls.Add(label4);
            panelDodavanje.Controls.Add(label3);
            panelDodavanje.Controls.Add(tBPrezime);
            panelDodavanje.Controls.Add(tBIme);
            panelDodavanje.Controls.Add(cBSkola);
            panelDodavanje.Controls.Add(label2);
            panelDodavanje.Location = new Point(195, 120);
            panelDodavanje.Name = "panelDodavanje";
            panelDodavanje.Size = new Size(710, 413);
            panelDodavanje.TabIndex = 47;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(2, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 487);
            panel3.TabIndex = 48;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Bisque;
            panel4.Controls.Add(label21);
            panel4.Location = new Point(193, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(861, 99);
            panel4.TabIndex = 49;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(907, 584);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelPregled);
            Controls.Add(panelDodavanje);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panelPregled.ResumeLayout(false);
            panelPregled.PerformLayout();
            panelDodavanje.ResumeLayout(false);
            panelDodavanje.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private Label label19;
        public ComboBox comboBox5;
        private Label label20;
        public ComboBox comboBox6;
        private Panel panel1;
        private Panel panel2;
        private Label label21;
        private Panel panelPregled;
        private Panel panelDodavanje;
        private Panel panel3;
        private Panel panel4;
        private Button button6;
        private Button button7;
    }
}