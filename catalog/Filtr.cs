using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace catalog
{
    public struct Phone
    {
        public string name;
        public int price;
        public string comp;
        public string memory;
        public Button btn;
        public PictureBox pic;
        public Phone(string _name, int _price, string _comp, string _memory)
        {
            name = _name;
            price = _price;
            comp = _comp;
            memory = _memory;
            btn = new Button();
            pic = new PictureBox();

            btn.Text = name;
            
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load("../../../images/" + name + ".jpg");
        }
    }
    public partial class Filtr : Form
    {
        Button[] btn = new Button[8];
        public static List<Phone> phone_list = new List<Phone>();
        
        public Filtr()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines("../../../phones.txt");
           
            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                Phone phone = new Phone(parts[0], Convert.ToInt32(parts[1]), parts[2], parts[3]);
                phone_list.Add(phone);
            }

           /* phone_list[0] = new Phone("Samsung S10",       41999, "Samsung", "0");
            phone_list[1] = new Phone("Samsung S21",       49999, "Samsung", "0");
            phone_list[2] = new Phone("Samsung Z Fold 3", 149999, "Samsung", "0");
            phone_list[3] = new Phone("Iphone X",          39999, "Iphone", "64");
            phone_list[4] = new Phone("Iphone XS",         46999, "Iphone", "64");
            phone_list[5] = new Phone("Iphone 11",         49999, "Iphone", "64");
            phone_list[6] = new Phone("Iphone 12",         79999, "Iphone", "256");
            phone_list[7] = new Phone("Iphone 13",         74999, "Iphone", "128");
           */

            int x = 0;
            int y = 0;
            for (int i = 0; i < phone_list.Count; i++)
            {
                phone_list[i].btn.Location = new System.Drawing.Point(31 + x, 51 + y);
                phone_list[i].btn.Size = new System.Drawing.Size(198, 39);
                phone_list[i].btn.Click += new System.EventHandler(phoneClick);
                pan.Controls.Add(phone_list[i].btn);

                phone_list[i].pic.Location = new Point(31 + x, 96 + y);
                phone_list[i].pic.Size = new Size(198, 215);
                pan.Controls.Add(phone_list[i].pic);
                x = x + 206;
                if (x + 206 > Width)
                {
                    y = y + 269;
                    x = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void phoneClick(object sender, EventArgs e)
        {

            for (int i = 0; i < phone_list.Count; i++)
            {
                if (((Button)sender).Text == phone_list[i].btn.Text)
                {
                    phoneinfo iphoneinfo = new phoneinfo(phone_list[i]);
                    iphoneinfo.ShowDialog();
                }    
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 8; i++)
            {
                phone_list[i].btn.Visible = true;
                phone_list[i].pic.Visible = true;

                if (compbox.Text != ""  && phone_list[i].comp != compbox.Text)
                {
                    phone_list[i].pic.Visible = false;
                    phone_list[i].btn.Visible = false;
                }

                

                if (pricetxt.Text != "" && phone_list[i].price > Convert.ToInt32(pricetxt.Text))
                {
                    phone_list[i].pic.Visible = false;
                    phone_list[i].btn.Visible = false;
                }

                if(phone_list[i].btn.Visible)
                { 
                    phone_list[i].btn.Location = new System.Drawing.Point(31 + x, 51 + y);
                    phone_list[i].btn.Size = new System.Drawing.Size(198, 39);
                    phone_list[i].btn.Click += new System.EventHandler(phoneClick);
                    pan.Controls.Add(phone_list[i].btn);

                    phone_list[i].pic.Location = new Point(31 + x, 96 + y);
                    phone_list[i].pic.Size = new Size(198, 215);
                    pan.Controls.Add(phone_list[i].pic);
                    x = x + 206;
                    if (x + 206 > Width)
                    {
                        y = y + 269;
                        x = 0;
                    }
                }



            }
        }

        private void likedClick(object sender, EventArgs e)
        {
            liked likedsus = new liked();
            likedsus.ShowDialog();
        }
    }
}
