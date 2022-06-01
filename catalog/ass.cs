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
    public partial class ass : Form
    {
        public ass()
        {
            InitializeComponent();
        }

        private void ass_Load(object sender, EventArgs e)
        {
           
        }
        string fileName = "";
        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("phones.txt",
            Environment.NewLine +
            nameTB.Text + ", " +
            companyCB.Text + ", " +
            memoryTB.Text + ", " +
            priceTB.Text + ", ");

            if (fileName != "")
            {
                File.Copy(fileName, "../../../images/" + nameTB.Text + ".jpg");
                File.AppendAllText("../../../texts/" + nameTB.Text + ".txt",
                Environment.NewLine + describe.Text);
                MessageBox.Show("Ваш телефон успешно добавлен");
            }
        }
    }
}
                                                           