﻿namespace ProjekatDM
{
    partial class Form2
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
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            cBSkola = new ComboBox();
            label7 = new Label();
            cBTreciPredmet = new ComboBox();
            label8 = new Label();
            cBDrugiPredmet = new ComboBox();
            label9 = new Label();
            cBPrviPredmet = new ComboBox();
            label10 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 0;
            label1.Text = "Dodavanje Škole / Šablona";
            // 
            // button1
            // 
            button1.Location = new Point(124, 220);
            button1.Name = "button1";
            button1.Size = new Size(106, 48);
            button1.TabIndex = 3;
            button1.Text = "Dodaj školu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(517, 65);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Šablon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 164);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Tip mature";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Opšti", "Stučni", "Umetnički" });
            comboBox1.Location = new Point(92, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 102);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Ime Škole";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 65);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Škola:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 96);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "Ime šablona";
            // 
            // cBSkola
            // 
            cBSkola.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSkola.FormattingEnabled = true;
            cBSkola.Location = new Point(447, 172);
            cBSkola.Name = "cBSkola";
            cBSkola.Size = new Size(192, 23);
            cBSkola.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 154);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 14;
            label7.Text = "Škola";
            // 
            // cBTreciPredmet
            // 
            cBTreciPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cBTreciPredmet.FormattingEnabled = true;
            cBTreciPredmet.Items.AddRange(new object[] { "Биологија", "Географија", "Енглески језик", "Историја", "Италијански језик", "Немачки језик", "Руски језик", "Српски као нематерњи језик", "Физика", "Француски језик", "Хемија", "Шпански језик" });
            cBTreciPredmet.Location = new Point(447, 326);
            cBTreciPredmet.Name = "cBTreciPredmet";
            cBTreciPredmet.Size = new Size(192, 23);
            cBTreciPredmet.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 308);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 20;
            label8.Text = "Treći predmet";
            // 
            // cBDrugiPredmet
            // 
            cBDrugiPredmet.DropDownStyle = ComboBoxStyle.Simple;
            cBDrugiPredmet.Enabled = false;
            cBDrugiPredmet.FormattingEnabled = true;
            cBDrugiPredmet.Location = new Point(447, 270);
            cBDrugiPredmet.Name = "cBDrugiPredmet";
            cBDrugiPredmet.Size = new Size(192, 23);
            cBDrugiPredmet.TabIndex = 19;
            cBDrugiPredmet.Text = "Математика";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(447, 252);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 18;
            label9.Text = "Drugi predmet";
            // 
            // cBPrviPredmet
            // 
            cBPrviPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cBPrviPredmet.FormattingEnabled = true;
            cBPrviPredmet.Items.AddRange(new object[] { "Српски језик и књижевност", "Албански језик и књижевност", "Босански језик и књижевност", "Бугарски језик и књижевност", "Мађарски језик и књижевност", "Румунски језик и књижевност", "Русински језик и књижевност", "Словачки језик и књижевност", "Хрватски језик и књижевност" });
            cBPrviPredmet.Location = new Point(447, 220);
            cBPrviPredmet.Name = "cBPrviPredmet";
            cBPrviPredmet.Size = new Size(192, 23);
            cBPrviPredmet.TabIndex = 17;
            cBPrviPredmet.SelectedIndexChanged += cBprvipredmet_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(447, 202);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 16;
            label10.Text = "Prvi predmet";
            // 
            // button2
            // 
            button2.Location = new Point(490, 364);
            button2.Name = "button2";
            button2.Size = new Size(106, 48);
            button2.TabIndex = 22;
            button2.Text = "Dodaj šablon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(cBTreciPredmet);
            Controls.Add(label8);
            Controls.Add(cBDrugiPredmet);
            Controls.Add(label9);
            Controls.Add(cBPrviPredmet);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(cBSkola);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private ComboBox cBSkola;
        private Label label7;
        public ComboBox cBTreciPredmet;
        private Label label8;
        public ComboBox cBDrugiPredmet;
        private Label label9;
        public ComboBox cBPrviPredmet;
        private Label label10;
        private Button button2;
    }
}