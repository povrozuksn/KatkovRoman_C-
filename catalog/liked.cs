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
    public partial class liked : Form
    {
        public static int totalprice = 0;
        public static Dictionary<Phone, int> likedphones = new Dictionary<Phone, int>();

        public liked()
        {
            InitializeComponent();
            Text = "Избранное";
            Draw();
        }

        public static void Calculate()
        {
            totalprice = 0;
            foreach(KeyValuePair<Phone, int> liked_Phones in likedphones)
            {
                totalprice += liked_Phones.Value * liked_Phones.Key.price;
            }
        }
        void Draw ()
        {
            Controls.Clear();
            Controls.Add(label1);
            Controls.Add(button1);

            int x = 30;
            int y = 50;
            foreach (KeyValuePair<Phone, int> Liked_phones in likedphones)
            {
                Phone phone = Liked_phones.Key;

                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y + AutoScrollPosition.Y);
                picture.Size = new Size(198, 215);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = phone.pic.Image;
                Controls.Add(picture);
                #endregion

                #region 2 столбец 
                Label label1 = new Label();
                label1.Font = new Font("Calibri", 16);
                label1.Text = "Модель: " + phone.name;
                label1.Location = new Point(x + 210, y + AutoScrollPosition.Y);
                label1.Size = new Size(200, 40);
                Controls.Add(label1);

                Label label2 = new Label();
                label2.Font = new Font("Calibri", 12);
                label2.Text = "Внутренняя память: " + phone.memory.ToString();
                label2.Location = new Point(x + 210, y + 40 + AutoScrollPosition.Y);
                label2.Size = new Size(200, 40);
                Controls.Add(label2);

                Label label3 = new Label();
                label3.Font = new Font("Calibri", 12);
                label3.Text = "Кол-во: " + Liked_phones.Value.ToString() + "шт.";
                label3.Location = new Point(x + 210, y + 90 + AutoScrollPosition.Y);
                label3.Size = new Size(200, 40);
                Controls.Add(label3);

                /**/
                #endregion

                #region 3 столбец

                Label label4 = new Label();
                label4.Font = new Font("Calibri", 12);
                label4.Text = "ЦЕНА - " + (phone.price).ToString();
                label4.Location = new Point(x + 410, y + AutoScrollPosition.Y);
                label4.Size = new Size(200, 40);
                Controls.Add(label4);

                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Location = new Point(x + 410, y + 40 + AutoScrollPosition.Y);
                numericUpDown1.Name = "numericUpDown1";
                numericUpDown1.Size = new Size(100, 50);
                numericUpDown1.Value = Liked_phones.Value;
                numericUpDown1.Click += new EventHandler(countChanged);
                Controls.Add(numericUpDown1);

                Label label5 = new Label();
                label5.Font = new Font("Calibri", 12);
                label5.Text = "ИТОГО(руб.): " + (phone.price * Liked_phones.Value).ToString();
                label5.Location = new Point(x + 410, y + 90 + AutoScrollPosition.Y);
                label5.Size = new Size(200, 40);
                Controls.Add(label5);

                #endregion

                #region 4 столбец

                Button btn_del = new Button();
                btn_del.Font = new Font("Calibri", 12);
                btn_del.Text = "Удалить";
                btn_del.Location = new Point(x + 700, y + 50 + AutoScrollPosition.Y);
                btn_del.Size = new Size(100, 40);
                btn_del.Click += new System.EventHandler(Del);
                Controls.Add(btn_del);
                #endregion

                y = y + 269;
            }

            Calculate();
            label1.Text = ("Общая стоимость корзины (руб.) - ") + totalprice.ToString();
        }

        void Del(Object sender, EventArgs e)
        {
            int i = 0;
            Button b = new Button();
            b = (Button)sender; 
            Dictionary<Phone, int> likedphones1 = new Dictionary<Phone, int>();
            
                foreach (KeyValuePair<Phone, int> Liked_phones in likedphones)
                {
                    Phone phone = Liked_phones.Key;
                    if (b.Location == new Point(730, 269 * i + 100 + AutoScrollPosition.Y))
                    { }
                    else
                    {
                        likedphones1[Liked_phones.Key] = Liked_phones.Value;
                    }
                    i++;
                }
                likedphones = likedphones1;
                Draw();
           
        }
        private void countChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            for (int i = 0; i < likedphones.Count; i++)
            {
                int price = 0;
                Image image = null;
                if (nud.Location == new Point(440, 269 * i + 90))
                {
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Location == new Point(30, 269 * i + 50 + AutoScrollPosition.Y))
                            image = ((PictureBox)ctrl).Image;
                    }

                    foreach (Phone phone in Filtr.phone_list)
                    {
                        if(phone.pic.Image == image)
                        {
                            likedphones[phone] = (int)nud.Value;
                        }
                    }

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(440, 269 * i + 50 + AutoScrollPosition.Y))
                            price = Convert.ToInt32(ctrl.Text.Replace("ЦЕНА - ", ""));
                    }

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(440, 269 * i + 140 + AutoScrollPosition.Y))
                            ctrl.Text = "ИТОГО(руб.): " + (price * nud.Value).ToString();
                    }
                    
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(240, 269 * i + 140 + AutoScrollPosition.Y))
                            ctrl.Text = "Кол-во(шт.): " + nud.Value.ToString();
                    }
                }
            }
        }
        private void liked_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendmail mailsus = new sendmail();
            mailsus.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
