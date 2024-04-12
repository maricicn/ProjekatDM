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
            StreamReader schoolFile = new StreamReader("schoolFile.txt");
            while (!schoolFile.EndOfStream)
            {
                string line = schoolFile.ReadLine();
                comboBox1.Items.Add(line);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
