using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatDM
{
    public partial class Form3 : Form
    {
        public static Form3 form3instance;
        public int line;
        public Form3()
        {
            InitializeComponent();
            form3instance = this;
            if (File.Exists("schoolFile.csv"))
            {
                StreamReader schoolFile = new StreamReader("schoolFile.csv");
                while (!schoolFile.EndOfStream)
                {
                    string line = schoolFile.ReadLine();
                    string[] s = line.Split(",");
                    cBSkola.Items.Add(s[0]);
                }
                schoolFile.Close();
            }
            if (File.Exists("templateFile.csv"))
            {
                StreamReader templateFile = new StreamReader("templateFile.csv");
                while (!templateFile.EndOfStream)
                {
                    string line = templateFile.ReadLine();
                    string[] s = line.Split(",");
                    cBTemplate.Items.Add(s[0]);
                }
                templateFile.Close();
            }
            line = 0;
            label18.Text = line.ToString();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader templateFile = new StreamReader("templateFile.csv");
            string line = string.Empty;
            int index = cBTemplate.SelectedIndex;
            for (int i = 0; i <= index; i++)
            {
                line = templateFile.ReadLine();
            }
            string[] s = line.Split(",");
            cBSkola.Text = s[1];
            cBPrviPredmet.Text = s[2];
            cBDrugiPredmet.Text = s[3];
            cBTreciPredmet.Text = s[4];
            templateFile.Close();
        }
        private string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter studentFile = new StreamWriter("studentFile.csv", append: true);
            if (tBIme.Text != string.Empty)
            {
                studentFile.Write(tBIme.Text + ";" + tBPrezime.Text + ";" + cBSkola.Text + ";" + cBOdeljenje.Text + ";" + cBPrviPredmet.Text + ";" + cBDrugiPredmet.Text + ";" + cBTreciPredmet.Text);
                studentFile.WriteLine();
            }
            else MessageBox.Show("Morate navesti ime ucenika");
            studentFile.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var count = File.ReadAllLines("studentFile.csv").Count();
            if (line + 1 <= count)
            {
                line++;
                string read = GetLine("studentFile.csv", line);
                string[] s = read.Split(";");
                textBox1.Text = s[0];
                textBox2.Text = s[1];
                comboBox1.Text = s[2];
                textBox3.Text = s[3];
                comboBox4.Text = s[4];
                comboBox3.Text = s[5];
                comboBox2.Text = s[6];
                label18.Text = line.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (line - 1 > 0)
            {
                line--;
                string read = GetLine("studentFile.csv", line);
                string[] s = read.Split(";");
                textBox1.Text = s[0];
                textBox2.Text = s[1];
                comboBox1.Text = s[2];
                textBox3.Text = s[3];
                comboBox4.Text = s[4];
                comboBox3.Text = s[5];
                comboBox2.Text = s[6];
                label18.Text = line.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string read = File.ReadAllLines("studentFile.csv").Last();
            string[] s = read.Split(";");
            textBox1.Text = s[0];
            textBox2.Text = s[1];
            comboBox1.Text = s[2];
            textBox3.Text = s[3];
            comboBox4.Text = s[4];
            comboBox3.Text = s[5];
            comboBox2.Text = s[6];
            line = File.ReadAllLines("studentFile.csv").Count();
            label18.Text = line.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string read = File.ReadAllLines("studentFile.csv").First();
            string[] s = read.Split(";");
            textBox1.Text = s[0];
            textBox2.Text = s[1];
            comboBox1.Text = s[2];
            textBox3.Text = s[3];
            comboBox4.Text = s[4];
            comboBox3.Text = s[5];
            comboBox2.Text = s[6];
            line = 1;
            label18.Text = line.ToString();
        }
    }
}
