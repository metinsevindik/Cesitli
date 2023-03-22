using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace mailtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SendMailFrom = gonderenTxt.Text;
            String SendMailTo = AliciTxt.Text;
            String SendMailSubject = KonuTxt.Text;
            String SendMailBody = IcerikTxt.Text;

            try
            {
                SmtpClient SmtpServer = new SmtpClient(smtptxt.Text, Convert.ToInt32(portTxt.Text));
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage email = new MailMessage();
                // START
                email.From = new MailAddress(SendMailFrom);
                email.To.Add(SendMailTo);
                email.CC.Add(SendMailFrom);
                email.Subject = SendMailSubject;
                email.Body = SendMailBody;
                //END
                SmtpServer.Timeout = 5000;
                SmtpServer.EnableSsl = sslCheckbox.Checked;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential(SendMailFrom, passtxt.Text);
                SmtpServer.Send(email);

                MessageBox.Show("Mail gönderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA:" + ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
