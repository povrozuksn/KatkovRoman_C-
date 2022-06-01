using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalog
{
    public partial class mainform : Form
    {
        int price = 0;
        public mainform()
        {
            InitializeComponent();

            if (aut.login == "")
                label1.Text = "Вы не вошли";
            else
                label1.Text = aut.login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iphone iphonesus = new iphone();
            iphonesus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            samsung samsungsus = new samsung();
            samsungsus.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filtr filtrsus = new Filtr();
            filtrsus.ShowDialog();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            liked likedsus = new liked();
            likedsus.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            spr sprsus = new spr();
            sprsus.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            aut autsus = new aut();
            autsus.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ass asus = new ass();
            asus.ShowDialog();
        }
    }
}
