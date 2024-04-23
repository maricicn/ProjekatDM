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
                    comboBox1.Items.Add(s[0]);
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
            for(int i = 0; i <= index; i++)
            {
                line = templateFile.ReadLine();
            }
            string[] s = line.Split(",");
            comboBox1.Text = s[1];
            comboBox2.Text = s[2];
            comboBox3.Text = s[3];
            comboBox4.Text = s[4];
            templateFile.Close();
        }
    }
}
