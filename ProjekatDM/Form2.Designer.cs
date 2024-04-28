namespace ProjekatDM
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
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
            label11 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            panelSkola = new Panel();
            label3 = new Label();
            comboBox2 = new ComboBox();
            panelSablon = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelSkola.SuspendLayout();
            panelSablon.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(305, 50);
            label1.TabIndex = 0;
            label1.Text = "Dodavanje Škole ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Opšti", "Poljoprivreda, proizvodnja i prerada hrane", "Šumarstvo i obrada drveta", "Geologija, rudarstvo i metalurgija", "Mašinstvo i obrada metala", "Elektrotehnika", "Hemija, nemetali i grafičarstvo", "Tekstilstvo i kožarstvo", "Geodezija i građevinarstvo", "Saobraćaj", "Trgovina, ugostiteljstvo i turizam", "Ekonomija, pravo i administracija", "Zdravstvo i socijalna zaštita", "Lične usluge", "Umetnički" });
            comboBox1.Location = new Point(17, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkOrange;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(22, 176);
            label5.Name = "label5";
            label5.Size = new Size(91, 40);
            label5.TabIndex = 10;
            label5.Text = "Škola:";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 17);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "Ime šablona";
            // 
            // cBSkola
            // 
            cBSkola.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSkola.FormattingEnabled = true;
            cBSkola.Location = new Point(16, 97);
            cBSkola.Name = "cBSkola";
            cBSkola.Size = new Size(192, 23);
            cBSkola.TabIndex = 13;
            cBSkola.SelectedIndexChanged += cBSkola_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 79);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 14;
            label7.Text = "Škola";
            // 
            // cBTreciPredmet
            // 
            cBTreciPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cBTreciPredmet.FormattingEnabled = true;
            cBTreciPredmet.Items.AddRange(new object[] { "Biologija", "Geografija", "Engleski jezik", "Istorija", "Italijanski jezik", "Nemački jezik", "Ruski jezik", "Srpski kao nematernji jezik", "Fizika", "Francuski jezik", "Hemija", "Španski jezik" });
            cBTreciPredmet.Location = new Point(252, 166);
            cBTreciPredmet.Name = "cBTreciPredmet";
            cBTreciPredmet.Size = new Size(250, 23);
            cBTreciPredmet.TabIndex = 21;
            cBTreciPredmet.SelectedIndexChanged += cBTreciPredmet_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 148);
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
            cBDrugiPredmet.Location = new Point(252, 97);
            cBDrugiPredmet.Name = "cBDrugiPredmet";
            cBDrugiPredmet.Size = new Size(250, 23);
            cBDrugiPredmet.TabIndex = 19;
            cBDrugiPredmet.Text = "Matematika";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(252, 79);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 18;
            label9.Text = "Drugi predmet";
            // 
            // cBPrviPredmet
            // 
            cBPrviPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cBPrviPredmet.FormattingEnabled = true;
            cBPrviPredmet.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            cBPrviPredmet.Location = new Point(252, 33);
            cBPrviPredmet.Name = "cBPrviPredmet";
            cBPrviPredmet.Size = new Size(250, 23);
            cBPrviPredmet.TabIndex = 17;
            cBPrviPredmet.SelectedIndexChanged += cBprvipredmet_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(252, 15);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 16;
            label10.Text = "Prvi predmet";
            // 
            // button2
            // 
            button2.Location = new Point(181, 215);
            button2.Name = "button2";
            button2.Size = new Size(106, 48);
            button2.TabIndex = 22;
            button2.Text = "Dodaj šablon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 233);
            label11.Name = "label11";
            label11.Size = new Size(110, 40);
            label11.TabIndex = 24;
            label11.Text = "Šablon:";
            label11.Click += label11_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(6, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 42);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Location = new Point(6, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 42);
            panel2.TabIndex = 26;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(133, 449);
            panel3.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = Color.NavajoWhite;
            panel5.Location = new Point(1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(132, 90);
            panel5.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Bisque;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(131, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(675, 90);
            panel4.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(79, 166);
            button1.Name = "button1";
            button1.Size = new Size(121, 48);
            button1.TabIndex = 3;
            button1.Text = "Dodaj školu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 91);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Tip mature";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Ime Škole";
            // 
            // panelSkola
            // 
            panelSkola.Controls.Add(button1);
            panelSkola.Controls.Add(comboBox1);
            panelSkola.Controls.Add(label4);
            panelSkola.Controls.Add(label2);
            panelSkola.Controls.Add(textBox1);
            panelSkola.Location = new Point(305, 116);
            panelSkola.Name = "panelSkola";
            panelSkola.Size = new Size(305, 242);
            panelSkola.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 148);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 30;
            label3.Text = "Jezik na kom se polaže";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Srpski jezik", "Albanski jezik", "Bosanski jezik", "Bugarski jezik", "Mađarski jezik", "Rumunski jezik", "Rusinski jezik", "Slovački jezik", "Hrvatski jezik" });
            comboBox2.Location = new Point(16, 166);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 23);
            comboBox2.TabIndex = 31;
            // 
            // panelSablon
            // 
            panelSablon.Controls.Add(label3);
            panelSablon.Controls.Add(comboBox2);
            panelSablon.Controls.Add(cBTreciPredmet);
            panelSablon.Controls.Add(label6);
            panelSablon.Controls.Add(textBox2);
            panelSablon.Controls.Add(cBSkola);
            panelSablon.Controls.Add(button2);
            panelSablon.Controls.Add(label7);
            panelSablon.Controls.Add(label9);
            panelSablon.Controls.Add(label10);
            panelSablon.Controls.Add(cBDrugiPredmet);
            panelSablon.Controls.Add(label8);
            panelSablon.Controls.Add(cBPrviPredmet);
            panelSablon.Location = new Point(203, 116);
            panelSablon.Name = "panelSablon";
            panelSablon.Size = new Size(537, 273);
            panelSablon.TabIndex = 32;
            panelSablon.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(panelSablon);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelSkola);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelSkola.ResumeLayout(false);
            panelSkola.PerformLayout();
            panelSablon.ResumeLayout(false);
            panelSablon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
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
        private Label label11;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private Label label4;
        private Label label2;
        private Panel panelSkola;
        private Label label3;
        public ComboBox comboBox2;
        private Panel panelSablon;
    }
}