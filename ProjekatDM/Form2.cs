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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             StreamWriter schoolFile = new StreamWriter("schoolFile.txt", append:true);
             if (textBox1.Text != string.Empty) schoolFile.WriteLine(textBox1.Text);
             else MessageBox.Show("Morate navesti ime skole");
             schoolFile.Close();
        }
    }
}
