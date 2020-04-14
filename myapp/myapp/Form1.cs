using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Click to make the transformation";
            timer1.Start();
            pb1.MouseEnter += new EventHandler(pb1_Enter);
            pb2.MouseEnter += new EventHandler(pb2_Enter);
            pb3.MouseEnter += new EventHandler(pb3_Enter);
            pb4.MouseEnter += new EventHandler(pb4_Enter);
            pb5.MouseEnter += new EventHandler(pb5_Enter);
            pb6.MouseEnter += new EventHandler(pb6_Enter);
            pb7.MouseEnter += new EventHandler(pb7_Enter);
            pb8.MouseEnter += new EventHandler(pb8_Enter);
            pb9.MouseEnter += new EventHandler(pb9_Enter);
            pb10.MouseEnter += new EventHandler(pb10_Enter);
            pb_Start.MouseEnter += new EventHandler(pbStart_Enter);
            pb_finish.MouseEnter += new EventHandler(pbFinish_Enter);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_Start.Location = new Point(pb_Start.Location.X + 100, pb_Start.Location.Y);
        }

        private void pb1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You finished your journey as a Padawan");
        }

        private void pb2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You fought hard and died as the last Jedi");
        }

        private void pb3_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You finished your journey as a Padawan");
        }

        private void pb4_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You finished your journey as a Padawan");
        }

        private void pb5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You fought hard and died as the last Jedi");
        }

        private void pb6_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You didn't survive tha falling of the order" );
        }

        private void pb7_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You reached Baby Yoda's rank");
        }

        private void pb8_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You were so close to reaching Master Yoda,s rank");
        }

        private void pb9_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You were so close to reaching Master Yoda,s rank");
        }

        private void pb10_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You were so close to reaching Master Yoda,s rank");
        }



        private void pbFinish_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations,your reached Yoda's rank");
        }

        private void pbStart_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Wait until the start dissapears");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (pictureBox1.Visible)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
                

           

        }
    }
}
