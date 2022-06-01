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
    public partial class aut : Form
    {
        public aut()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg reg = new reg();
            reg.ShowDialog();
        }
        public static string login = "";
        public static string mail = "";
        public static string pswrd = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("../../../users.txt");

            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
 
                if ((textBox1.Text == parts[0] || textBox1.Text == parts[2]) && textBox2.Text == parts[1])
                {
                    login = parts[0];
                    pswrd = parts[1];
                    mail  = parts[2];
                }

                MessageBox.Show("Вы успшено вошли");
                Close();

                
                return;
            }

            MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
