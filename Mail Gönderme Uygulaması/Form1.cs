using System.Net;
using System.Net.Mail;

namespace Mail_Gönderme_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }






        private void button1_Click(object sender, EventArgs e)
        {
            using (MailMessage mail = new("aysegulcelik1128@gmail.com", textBox1.Text, textBox2.Text, richTextBox1.Text))
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                foreach (var filename in openFileDialog1.FileNames)
                    if (File.Exists(filename))
                        mail.Attachments.Add(new Attachment(filename));
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("YOUR_EMAIL@gmail.com", "YOUR_APP_PASSWORD");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                FRM_Alert alert = new();
                alert.ShowDialog();
                textBox1.Text = textBox2.Text = richTextBox1.Text = label6.Text = "";

            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach (var filename in openFileDialog1.FileNames)
                label6.Text = filename;
        }



    }

}

