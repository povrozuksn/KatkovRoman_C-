using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Mail;
namespace catalog
{
    public partial class sendmail : Form
    {
        public sendmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("pukhruk3@gmail.com", "Phones");
            MailAddress toAdress = new MailAddress(textBox1.Text, "User");
            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAdress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "ffff ejhpbyf";
                mailMessage.Body = "ш агслув нщг шт нщгк фыыБ вщ куьуьиук ьу" + Environment.NewLine;
                mailMessage.IsBodyHtml = true;
                System.IO.File.WriteAllText("mail.csv", "Название, Цена, Количество, Стоимость всей корзины");

                foreach (KeyValuePair<Phone, int> Liked_phones in liked.likedphones)
                {
                    Phone phone = Liked_phones.Key;
                    System.IO.File.AppendAllText("mail.csv", Environment.NewLine + phone.name + ", " 
                                                + phone.price + ", " + Liked_phones.Value + ", "
                                                + Liked_phones.Value * phone.price);
                                                 
                }

                //формирование файла для отправки

                System.IO.File.AppendAllText("mail.csv", Environment.NewLine + "Цена вашей корзины: " + liked.totalprice);

                mailMessage.Attachments.Add(new Attachment("mail.csv"));

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "PeePoop228");

                smtpClient.Send(mailMessage);   
            }

            MessageBox.Show("Словил");
        }
    }
}
