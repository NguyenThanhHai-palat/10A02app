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
        public int z = 0;
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
            z++;
            button1.Text = "GỬI LẠI";
            if (z == 7)
            {
                MessageBox.Show("Bạn đã gửi lại ≥5 lần, xin hãy kiểm tra lại:\n1.Email chính xác hay không \n2.Kiểm tra đã kết nối internet cho app hay chưa\n3.Kiểm tra thùng thư rác của thư\n Sau đó tắt app bật lại để nhập lại mã", "Xác Minh Email", MessageBoxButtons.OK, MessageBoxIcon.Question);
                button1.Visible = false;
            }
            if (email.Text == "" || email.Text==null)
            {
                MessageBox.Show("Vui lòng nhập email", "Xác Minh Eamil", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    MailMessage mail = new MailMessage("mail@10a02.palat001.cf", email.Text, "MÃ XÁC NHẬN CHO ỨNG DỤNG 10A02", "Chào bạn, <br>MÃ XÁC NHẬN CỦA BẠN LÀ:10A02-CODE:<p style='color:red;'><b>" + num.ToString() + "</b></p>, SAU KHI NHẬP EMAIL CỦA BẠN SẼ ĐƯỢC SỚM LƯU LẠI<br><p style='text-align:center'><strong>(C)PALATDEV</strong></p>");
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
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xác Minh Email", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 3)
            {
                if (textBox1.Text == num.ToString())
                {
                    string datap = File.ReadAllText(checkout(9));
                    string cas = email.Text;
                    if (datap == null || datap == "" || datap == " ") {
                        File.WriteAllText(checkout(9),cas);
                        Application.Restart();
                    }

                    
                }
                else
                {
                    label5.Text = "SAI MÃ XÁC NHẬN";
                }
            }
        }
    }
}
