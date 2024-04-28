using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjekatDM
{
    public partial class Form3 : Form
    {
        public static Form3 form3instance;
        public int line;
        public int seconds;
        public Form3()
        {
            InitializeComponent();
            form3instance = this;
            seconds = 0;
            if (File.Exists("schoolFile.csv"))
            {
                StreamReader schoolFile = new StreamReader("schoolFile.csv");
                while (!schoolFile.EndOfStream)
                {
                    string line = schoolFile.ReadLine();
                    string[] s = line.Split(";");
                    cBSkola.Items.Add(s[0]);
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
                    string[] s = line.Split(";");
                    cBTemplate.Items.Add(s[0]);
                }
                templateFile.Close();
            }
            line = 0;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cBTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader templateFile = new StreamReader("templateFile.csv");
            string line = string.Empty;
            int index = cBTemplate.SelectedIndex;
            for (int i = 0; i <= index; i++)
            {
                line = templateFile.ReadLine();
            }
            string[] s = line.Split(";");
            cBSkola.Text = s[1];
            cBPrviPredmet.Text = s[2];
            cBDrugiPredmet.Text = s[3];
            cBTreciPredmet.Text = s[4];
            comboBox5.Text = s[5];
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
            if (tBIme.Text == "Branko" || tBIme.Text == "Бранко")
            {
                if (tBPrezime.Text == "Vrhovac" || tBPrezime.Text == "Врховац")
                {
                    //MessageBox.Show("easter egg");
                    timer1.Enabled = true;
                    labelTimer.Visible = true;
                    pictureBox1.Visible = true;
                    seconds = 2;
                    labelTimer.Text = "3";
                    timer1.Start();

                }
            }
            else
            {
                StreamWriter studentFile = new StreamWriter("studentFile.csv", append: true);
                if (tBIme.Text != string.Empty)
                {
                    studentFile.Write(tBIme.Text + ";" + tBPrezime.Text + ";" + cBSkola.Text + ";" + cBOdeljenje.Text + ";" + cBPrviPredmet.Text + ";" + cBDrugiPredmet.Text + ";" + cBTreciPredmet.Text + ";" + comboBox5.Text);
                    studentFile.WriteLine();
                }
                else MessageBox.Show("Morate navesti ime ucenika");
                studentFile.Close();
                MessageBox.Show("Podaci u učeniku su sačuvani");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("studentFile.csv") && File.ReadAllLines("studentFile.csv").Count() > 0)
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
                    comboBox6.Text = s[7];

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("studentFile.csv") && File.ReadAllLines("studentFile.csv").Count() > 0)
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
                    comboBox6.Text = s[7];


                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("studentFile.csv") && File.ReadAllLines("studentFile.csv").Count() > 0)
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
                comboBox6.Text = s[7];
                line = File.ReadAllLines("studentFile.csv").Count();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("StudentFile.csv") && File.ReadAllLines("studentFile.csv").Count() > 0)
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
                comboBox6.Text = s[7];
                line = 1;

            }
        }

        private void cBPrviPredmet_SelectedIndexChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            label21.Text = "Dodavanje učenika";
            panel1.Visible = true;
            panel2.Visible = false;
            panelPregled.Location = new Point(315, 539);
            panelDodavanje.Visible = true;
            panelPregled.Visible = false;
            label1.BackColor = Color.DarkOrange;
            label10.BackColor = Color.Bisque;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label21.Text = "Pregled učenika";
            panel1.Visible = false;
            panel2.Visible = true;
            panelDodavanje.Visible = false;
            panelPregled.Visible = true;
            panelPregled.Location = new Point(290, 120);
            label1.BackColor = Color.Bisque;
            label10.BackColor = Color.DarkOrange;
        }
        private void DeleteFromFile(string path, int line)
        {
            List<string> linesList = File.ReadAllLines(path).ToList();
            linesList.RemoveAt(line - 1);
            File.WriteAllLines(path, linesList.ToArray());
        }
        private void DataFromFile(string path)
        {
            string read = GetLine("studentFile.csv", line);
            string[] s = read.Split(";");
            textBox1.Text = s[0];
            textBox2.Text = s[1];
            comboBox1.Text = s[2];
            textBox3.Text = s[3];
            comboBox4.Text = s[4];
            comboBox3.Text = s[5];
            comboBox2.Text = s[6];
            comboBox6.Text = s[7];

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (line == File.ReadAllLines("studentFile.csv").Count() && line != 0)
            {
                if (line != 1)
                {
                    DeleteFromFile("studentFile.csv", line);
                    line--;
                    DataFromFile("studentFile.csv");
                    MessageBox.Show("Podaci o učeniku su izbrisani");

                }
                else
                {
                    DeleteFromFile("studentFile.csv", line);
                    line--;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    comboBox1.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    comboBox4.Text = string.Empty;
                    comboBox3.Text = string.Empty;
                    comboBox2.Text = string.Empty;
                    comboBox6.Text = string.Empty;
                    MessageBox.Show("Podaci o učeniku su izbrisani");
                }
            }
            else
            {
                if (line == 0)
                {
                    MessageBox.Show("Nemate kog učenika da izbrišete!");
                }
                else if (line == 1)
                {
                    DeleteFromFile("studentFile.csv", line);
                    DataFromFile("studentFile.csv");
                    MessageBox.Show("Podaci o učeniku su izbrisani");
                }
                else if (line != 0)
                {
                    DeleteFromFile("studentFile.csv", line);
                    line--;
                    DataFromFile("studentFile.csv");
                    MessageBox.Show("Podaci o učeniku su izbrisani!");
                }


            }



        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (line != 0)
            {
                List<string> linesList = File.ReadAllLines("studentFile.csv").ToList();
                string s = textBox1.Text + ";" + textBox2.Text + ";" + comboBox1.Text + ";" + textBox3.Text + ";" + comboBox4.Text + ";" +
                    comboBox3.Text + ";" + comboBox2.Text + ";" + comboBox6.Text;
                linesList.RemoveAt(line - 1);
                linesList.Insert(line - 1, s);
                File.WriteAllLines("studentFile.csv", linesList.ToArray());
                //DataFromFile("studentFile.csv");
                MessageBox.Show("Podaci o učeniku su izmenjeni!");
            }
            else
            {
                MessageBox.Show("Nemate kog ucenika da izmenite!");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string s = GetLine("schoolFile.csv", index + 1);
            string[] rline = s.Split(';');
            if (rline[1].ToString() == "Opšti")
            {
                if (comboBox4.Text == "Srpski jezik i književnost")
                {
                    comboBox2.Items.RemoveAt(7);
                }
                else
                {
                    if (!comboBox2.Items.Cast<string>().Contains("Srpski kao nematernji jezik"))
                        comboBox2.Items.Insert(7, "Srpski kao nematernji jezik");


                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            string s = GetLine("schoolFile.csv", index + 1);
            string[] rline = s.Split(';');
            //comboBox2.Text = string.Empty;
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
                if (Array.IndexOf(predmeti, comboBox2.Text) == -1) comboBox2.Text = string.Empty;
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Umetnički")
            {
                string[] predmeti1 = { "Solfeđo", "Harmonija" };
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti1) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Poljoprivreda, proizvodnja i prerada hrane")
            {
                string[] predmeti = {"Zootehničar",
                                     "Tehničar za biotehnologiju",
                                     "Tehničar poljoprivredne tehnike",
                                     "Tehničar hortikulture"
                                     };
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Šumarstvo i obrada drveta")
            {
                string[] predmeti = {"Tehničar za pejzažnu arhitekturu",
                                     "Šumarski tehničar",
                                     };
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Geologija, rudarstvo i metalurgija")
            {
                string[] predmeti = {"Geološki tehničar za geotehniku i hidrogeologiju",
                                     "Geološki tehničar za istraživanje mineralnih sirovina",
                                     "Rudarski tehničar",
                                     "Rudarski tehničar za pripremu mineralnih sirovina"
                                     };
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
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
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
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
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
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
                comboBox2.Items.Clear();
                foreach (var predmet in predmeti) comboBox2.Items.Add(predmet);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Tekstilstvo i kožarstvo")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Tekstilni tehničar");
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Geodezija i građevinarstvo")
            {
                string[] predmeti = {"Građevinski tehničar za laboratorijska ispitivanja",
                                     "Građevinski tehničar za hidrogradnju",
                                     "Izvođač instalaterskih i završnih građevinskih radova"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(predmeti);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);

            }
            else if (rline[1].ToString() == "Saobraćaj")
            {
                string[] predmeti = {"Nautički tehničar – rečni smer",
                                     "Saobraćajno-transportni tehničar",
                                     "Tehničar vuče",
                                     "Tehničar PTT saobraćaja",
                                     "Tehničar unutrašnjeg transporta",
                                     "Transportni komercijalista"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(predmeti);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Trgovina, ugostiteljstvo i turizam")
            {
                string[] predmeti = {"Aranžer u trgovini i Trgovinski tehničar",
                                     "Kulinarski tehničar",
                                     "Ugostiteljski tehničar"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(predmeti);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Ekonomija, pravo i administracija")
            {
                string[] predmeti = {"Ekonomski tehničar",
                                     "Finansijski tehničar",
                                     "Carinski tehničar"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(predmeti);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Zdravstvo i socijalna zaštita")
            {
                string[] predmeti = {"Ginekološko-akušerska sestra",
                                     "Zubni tehničar",
                                     "Medicinska sestra – vaspitač",
                                     "Pedijatrijska sestra – tehničar",
                                     "Sanitarno-ekološki tehničar"};
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(predmeti);
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
            else if (rline[1].ToString() == "Lične usluge")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Scenski masker i vlasuljar");
                comboBox2.DropDownWidth = DropDownWidth(comboBox2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = seconds--.ToString();
            if (seconds < -1)
            {
                timer1.Stop();
                labelTimer.Visible = false;
                pictureBox1.Visible = false;
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cBTreciPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBTreciPredmet.Text == "Srpski kao nematernji jezik" && cBPrviPredmet.Text == "Srpski jezik i književnost")
            {
                cBTreciPredmet.Text = string.Empty;
                cBTreciPredmet.Items.Remove("Srpski kao nematernji jezik");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Srpski kao nematernji jezik" && comboBox4.Text == "Srpski jezik i književnost")
            {
                comboBox2.Text = string.Empty;
                comboBox2.Items.Remove("Srpski kao nematernji jezik");
            }
        }
    }
}
