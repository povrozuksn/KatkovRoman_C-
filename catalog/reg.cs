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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }

            else
            {
                if(textBox2.Text != textBox3.Text)
                    MessageBox.Show("Пароли не совпадают");
                else
                {
                    File.AppendAllText("../../../users.txt", textBox1.Text + ", "
                                                           + textBox2.Text + ", "
                                                           + textBox4.Text
                                                           + Environment.NewLine);
                    Close();
                }   
            }
        }
    }
}
