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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter schoolFile = new StreamWriter("schoolFile.csv", append: true);
            if (textBox1.Text != string.Empty)
            {
                schoolFile.Write(textBox1.Text + ",");
                cBSkola.Items.Add(textBox1.Text);
                schoolFile.Write(comboBox1.Text);
                schoolFile.WriteLine();
            }
            else MessageBox.Show("Morate navesti ime skole");
            schoolFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter templateFile = new StreamWriter("templateFile.csv", append: true);
            if (textBox2.Text != string.Empty)
            {
                templateFile.Write(textBox2.Text + "," + cBSkola.Text + "," + cBPrviPredmet.Text + "," + cBDrugiPredmet.Text + "," + cBTreciPredmet.Text);
                templateFile.WriteLine();
            }
            else MessageBox.Show("Morate navesti ime sablona");
            templateFile.Close();
        }

        private void cBprvipredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBPrviPredmet.Text == "Српски језик и књижевност")
            {
                cBTreciPredmet.Items.RemoveAt(7);
            }
            else
            {
                if (!cBTreciPredmet.Items.Cast<string>().Contains("Српски као нематерњи језик"))
                    cBTreciPredmet.Items.Insert(8, "Српски као нематерњи језик");

            }
        }
    }
}
