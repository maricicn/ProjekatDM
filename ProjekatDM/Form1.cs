using System.Drawing.Drawing2D;

namespace ProjekatDM
{

    public partial class Form1 : Form
    {
        private Rectangle button1OriginalRectangle;
        private Rectangle button2OriginalRectangle;
        private Rectangle button3OriginalRectangle;
        private Rectangle titleOriginalRectangle;
        private Rectangle originalFormSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            //File.WriteAllText("schoolFile.txt", string.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("schoolFile.csv", string.Empty);
            File.WriteAllText("templateFile.csv", string.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            button1OriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2OriginalRectangle = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3OriginalRectangle = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            titleOriginalRectangle = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
        }
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            if(c.GetType() == typeof(Label))
            {
                float newSize = (float)Math.Sqrt((double)(this.Width * this.Height) / (r.Width * r.Height)); ;
                c.Font = new Font(label1.Font.FontFamily, newSize);
                c.Location = new Point(newX, newY);

            }
            else
            {
                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(button1OriginalRectangle, button1);
            resizeControl(button2OriginalRectangle, button2);
            resizeControl(button3OriginalRectangle, button3);
            resizeControl(titleOriginalRectangle, label1);
            
        }
    }
}
