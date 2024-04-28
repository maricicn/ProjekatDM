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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    string[] s = line.Split(";");
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
                schoolFile.Write(textBox1.Text + ";");
                cBSkola.Items.Add(textBox1.Text);
                schoolFile.Write(comboBox1.Text);
                schoolFile.WriteLine();
            }
            else MessageBox.Show("Morate navesti ime skole");
            schoolFile.Close();
            MessageBox.Show("Podaci o školi su sačuvani");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter templateFile = new StreamWriter("templateFile.csv", append: true);
            if (textBox2.Text != string.Empty)
            {
                templateFile.Write(textBox2.Text + ";" + cBSkola.Text + ";" + cBPrviPredmet.Text + ";" + cBDrugiPredmet.Text + ";" + cBTreciPredmet.Text + ";" + comboBox2.Text);
                templateFile.WriteLine();
            }
            else MessageBox.Show("Morate navesti ime sablona");
            templateFile.Close();
            MessageBox.Show("Podaci o šablonu su sačuvani");
        }

        private void cBprvipredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cBSkola.SelectedIndex;
            string s = GetLine("schoolFile.csv", index + 1);
            string[] rline = s.Split(';');
            if (rline[1].ToString() == "Opšti")
            {
                if (cBPrviPredmet.Text == "Srpski jezik i književnost")
                {
                    cBTreciPredmet.Items.RemoveAt(7);
                }
                else
                {
                    if (!cBTreciPredmet.Items.Cast<string>().Contains("Srpski kao nematernji jezik"))
                        cBTreciPredmet.Items.Insert(7, "Srpski kao nematernji jezik");


                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label1.Text = "Dodavanje Škole";
            panel1.Visible = true;
            panel2.Visible = false;
            panelSablon.Location = new Point(612, 117);
            panelSkola.Visible = true;
            panelSablon.Visible = false;
            label5.BackColor = Color.DarkOrange;
            label11.BackColor = Color.Bisque;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label1.Text = "Dodavanje Šablona";
            panel1.Visible = false;
            panel2.Visible = true;
            panelSkola.Visible = false;
            panelSablon.Visible = true;
            panelSablon.Location = new Point(235, 117);
            label5.BackColor = Color.Bisque;
            label11.BackColor = Color.DarkOrange;
        }

        public string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
        private void cBSkola_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cBSkola.SelectedIndex;
            string s = GetLine("schoolFile.csv", index + 1);
            string[] rline = s.Split(';');
            if (rline[1].ToString() == "Opšti")
            {
                string[] predmeti = {"Biologija",
                              "Geografija",
                              "Engleski jezik",
                              "Istorija",
                              "Italijanski jezik",
                              "Nemački jezik",
                              "Ruski jezik",
                              "Srpski kao nematernji jezik",
                              "Fizika",
                              "Francuski jezik",
                              "Hemija",
                              "Španski jezik"};
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Umetnički")
            {
                string[] predmeti1 = { "Solfeđo", "Harmonija" };
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti1) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Poljoprivreda, proizvodnja i prerada hrane")
            {
                string[] predmeti = {"Zootehničar",
                                     "Tehničar za biotehnologiju",
                                     "Tehničar poljoprivredne tehnike",
                                     "Tehničar hortikulture"
                                     };
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Šumarstvo i obrada drveta")
            {
                string[] predmeti = {"Tehničar za pejzažnu arhitekturu",
                                     "Šumarski tehničar",
                                     };
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Geologija, rudarstvo i metalurgija")
            {
                string[] predmeti = {"Geološki tehničar za geotehniku i hidrogeologiju",
                                     "Geološki tehničar za istraživanje mineralnih sirovina",
                                     "Rudarski tehničar",
                                     "Rudarski tehničar za pripremu mineralnih sirovina"
                                     };
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Mašinstvo i obrada metala")
            {
                string[] predmeti = {"Brodomašinski tehničar",
                                     "Mašinski tehničar za kompjutersko konstruisanje",
                                     "Mašinski tehničar merne i regulacione tehnike",
                                     "Mašinski tehničar motornih vozila",
                                     "Tehničar grejanja i klimatizacije",
                                     "Tehničar za kompjutersko upravljanje (CNC) mašina",
                                     "Tehničar za robotiku",
                                     "Tehničar mašinske energetike",
                                     "Tehničar optike"
                                     };
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Elektrotehnika")
            {
                string[] predmeti = {"Elektrotehničar automatike",
                                     "Elektrotehničar elektromotornih pogona",
                                     "Elektrotehničar elektronike",
                                     "Elektrotehničar energetike",
                                     "Elektrotehničar za termičke i rashladne uređaje",
                                     "Elektrotehničar informacionih tehnologija",
                                     "Elektrotehničar procesnog upravljanja",
                                     "Elektrotehničar računara"
                                     };
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Hemija, nemetali i grafičarstvo")
            {
                string[] predmeti = {"Tehničar grafičke dorade",
                                     "Tehničar za zaštitu životne sredine",
                                     "Tehničar za industrijsku farmaceutsku tehnologiju",
                                     "Tehničar štampe",
                                     "Fotograf",
                                     "Hemijski laborant",
                                     "Hemijsko-tehnološki tehničar"};
                cBTreciPredmet.Items.Clear();
                foreach (var predmet in predmeti) cBTreciPredmet.Items.Add(predmet);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Tekstilstvo i kožarstvo")
            {
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.Add("Tekstilni tehničar");
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Geodezija i građevinarstvo")
            {
                string[] predmeti = {"Građevinski tehničar za laboratorijska ispitivanja",
                                     "Građevinski tehničar za hidrogradnju",
                                     "Izvođač instalaterskih i završnih građevinskih radova"};
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.AddRange(predmeti);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);

            }
            else if (rline[1].ToString() == "Saobraćaj")
            {
                string[] predmeti = {"Nautički tehničar – rečni smer",
                                     "Saobraćajno-transportni tehničar",
                                     "Tehničar vuče",
                                     "Tehničar PTT saobraćaja",
                                     "Tehničar unutrašnjeg transporta",
                                     "Transportni komercijalista"};
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.AddRange(predmeti);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Trgovina, ugostiteljstvo i turizam")
            {
                string[] predmeti = {"Aranžer u trgovini i Trgovinski tehničar",
                                     "Kulinarski tehničar",
                                     "Ugostiteljski tehničar"};
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.AddRange(predmeti);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Ekonomija, pravo i administracija")
            {
                string[] predmeti = {"Ekonomski tehničar",
                                     "Finansijski tehničar",
                                     "Carinski tehničar"};
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.AddRange(predmeti);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Zdravstvo i socijalna zaštita")
            {
                string[] predmeti = {"Ginekološko-akušerska sestra",
                                     "Zubni tehničar",
                                     "Medicinska sestra – vaspitač",
                                     "Pedijatrijska sestra – tehničar",
                                     "Sanitarno-ekološki tehničar"};
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.AddRange(predmeti);
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
            else if (rline[1].ToString() == "Lične usluge")
            {
                cBTreciPredmet.Items.Clear();
                cBTreciPredmet.Items.Add("Scenski masker i vlasuljar");
                cBTreciPredmet.DropDownWidth = DropDownWidth(cBTreciPredmet);
            }
        }
        public int DropDownWidth(System.Windows.Forms.ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cBTreciPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBTreciPredmet.Text == "Srpski kao nematernji jezik" && cBPrviPredmet.Text == "Srpski jezik i književnost")
            {
                cBTreciPredmet.Text = string.Empty;
                cBTreciPredmet.Items.Remove("Srpski kao nematernji jezik");
            }
        }
    }
}
