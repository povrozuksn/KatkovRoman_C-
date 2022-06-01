using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace catalog
{
    public partial class phoneinfo : Form
    {
        Phone phone;
        public phoneinfo(Phone _phone)
        {
            InitializeComponent();
            phone = _phone;
            pictureBox1.Load("../../../images/" + phone.name + ".jpg");
            textBox1.Text = File.ReadAllText("../../../texts/" + phone.name + ".txt");
            label1.Text = phone.name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(liked.likedphones.ContainsKey(phone)) 
                liked.likedphones[phone]++;
            else
                liked.likedphones.Add(phone, 1);
        }

        private void phoneinfo_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
