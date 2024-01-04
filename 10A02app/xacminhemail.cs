using MVE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10A02app
{
    public partial class xacminhemail : Form
    {
        public int k = 0;
        public string checkout(int linenum)
        {
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] LM = readfile.allLines("data\\app.a");
            return LM[linenum];
        }
        private Random rnd = new Random();
        public int num;
        public xacminhemail()
        {
            InitializeComponent();
            num = rnd.Next(1101, 9970);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || email.Text==null)
            {
                MessageBox.Show("Vui lòng nhập email", "Xác Minh Eamil", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    MailMessage mail = new MailMessage("mail@10a02.palat001.cf", email.Text, "MÃ XÁC NHẬN CHO ỨNG DỤNG 10A02", "Chào, ĐÂY MÃ XÁC NHẬN CỦA BẠN LÀ:10A02-CODE:" + num.ToString() + ", SAU KHI NHẬP EMAIL CỦA BẠN SẼ ĐƯỢC SỚM LƯU LẠI");
                    mail.IsBodyHtml = true;
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Host = "smtp.gmail.com";
                    client.UseDefaultCredentials = false;
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("xacminhmail.palatdev@gmail.com", "itdd oqxg behg vcav");
                    client.EnableSsl = true;
                    client.Send(mail);
                    MessageBox.Show("Đã gửi mã xác nhận!", "Thông Báo", MessageBoxButtons.OK);
                    button1.Text = "ĐÃ GỬI";
                    button1.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xác Minh Eamil", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 3)
            {
                if (textBox1.Text == num.ToString())
                {
                    string[] datap = { };
                    string cas = "\n" + email.Text;
                    if (datap == null || datap[1] == "" || datap[0] == " ") {
                        File.WriteAllText(checkout(9),cas);
                    }
                    
                    this.Close();
                }
                else
                {
                    label5.Text = "SAI MÃ XÁC NHẬN";
                }
            }
        }
    }
}
