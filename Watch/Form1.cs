using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        DateTime teraz;
        int onl;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            int time = DateTime.Now.Hour;
            if (time > 6 && time < 11)
            {
                pictureBox1.Image = Properties.Resources.poranek;
                label2.Text="Dzień dobry rano! ";
            }
            else if (time >= 11 && time <= 17)
            {
                pictureBox1.Image = Properties.Resources.poludnie;
                label2.Text="Dzień dobry w poludnie! ";
            }
            else if (time > 17 && time <= 19)
            {
                pictureBox1.Image = Properties.Resources.wieczor;
                label2.Text="Dobry wieczor! ";
            }
            else if (time > 19 && time <= 6)
            {
                pictureBox1.Image = Properties.Resources.noc;
                label2.Text="Dobranoc! ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) onl = 1;
            else onl = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            teraz = DateTime.Now;
            String txt;
            if (onl == 1)
            {
                txt = teraz.Hour.ToString() + ":" + teraz.Minute.ToString() + ":" + teraz.Second.ToString();
                label1.Text = txt;
            }
            else
            {
                label1.Text = teraz.ToString();
            }
            

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
