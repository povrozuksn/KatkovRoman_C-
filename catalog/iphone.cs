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
    public partial class iphone : Form
    {
        public iphone()
        {
            InitializeComponent();


            int x = 0;
            int y = 0;
            for (int i = 0; i < 12; i++)
            {
                Filtr.phone_list[i].btn.Visible = true;
                Filtr.phone_list[i].pic.Visible = true;

                if (Filtr.phone_list[i].comp != "Iphone")
                {
                    Filtr.phone_list[i].pic.Visible = false;
                    Filtr.phone_list[i].btn.Visible = false;
                }

                Filtr.phone_list[i].btn.Location = new System.Drawing.Point(31 + x, 51 + y);
                Filtr.phone_list[i].btn.Size = new System.Drawing.Size(198, 39);
                Filtr.phone_list[i].btn.Click += new System.EventHandler(Filtr.phoneClick);
                Controls.Add(Filtr.phone_list[i].btn);

                Filtr.phone_list[i].pic.Location = new Point(31 + x, 96 + y);
                Filtr.phone_list[i].pic.Size = new Size(198, 215);
                Controls.Add(Filtr.phone_list[i].pic);
                x = x + 206;
                if (x + 206 > Width)
                {
                    y = y + 269;
                    x = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mainsus = new mainform();
            mainsus.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtr.phoneClick(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iphone_Load(object sender, EventArgs e)
        {

        }
    }
}
