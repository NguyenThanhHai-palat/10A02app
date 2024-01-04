using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MVE;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;

namespace _10A02app
{
    public partial class login : Form
    {
        public int linesc=0;
        public int c = 0;
        public string name;
        void thongbao()
        {
            if (c == 0)
            {

                using (WebClient client = new WebClient())
                {
                    client.Encoding = UTF8Encoding.UTF8;
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    string content = client.DownloadString("https://pltupload.glitch.me/dataupload/n.txt");
                    if (content.Length > 0)
                    {
                        string[] lines = content.Split('\n');
                        MessageBox.Show(lines[1], lines[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }

        }
        public void checkemail()
        {
            string datap;
            try { datap = File.ReadAllText(checkout(9)); } catch { File.WriteAllText(checkout(9), ""); }
            PALATAPP.Readfile r = new PALATAPP.Readfile();
            string[] dadat = r.allLines(checkout(9));
            if (dadat[1]=="" || dadat[1] == null)
            {
                xacminhemail xc = new xacminhemail();
                xc.Show();
            }

        }
        public string checkout(int linenum)
        {
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] LM = readfile.allLines("data\\app.a");
            return LM[linenum];
        }
        public login(string[] args)
        {
            InitializeComponent();
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            if (readfile.allText(checkout(8)) == null || readfile.allText(checkout(8)) == "")
            {

            }
            else
            {
                onload();
                onchecked();
            }
            Icon gc = new Icon(checkout(10));
            this.Icon = gc;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string a = pass.Text;
            string b=date.Text;
            string c = a + "\n" + b;
            if(pass.Text == "" || date.Text == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ");
            }
            else
            {
                File.WriteAllText(checkout(8), c);
                onchecked();
                thongbao();
                this.Close();
            }
            
        }
        void onload()
        {
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] glp = readfile.allLines(checkout(8));
            if (((glp[0] != "") && (glp[0] != " ")) && ((glp[1] != "") && (glp[1] != " ")))
            {
                 try
                {
                    pass.Text = glp[0];
                    date.Text = glp[1];
                }
                catch
                {
                    this.Close();
                }
            }
            else
            {
                try
                {
                    pass.Text = glp[0];
                    date.Text = glp[1];
                }
                catch
                {
                    this.Close();
                }
            }
        }

        void updatedata()
        {
            WebClient webClient = new WebClient();
            string rgc = webClient.DownloadString(checkout(3)+ (checkout(19)));
            File.WriteAllText("data\\app.a", rgc);
        }
        void onchecked()
        {
            string[] a = { };
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] glp = readfile.allLines(checkout(8));
            string glpc = readfile.allText(checkout(8));

            if ((glpc == "") && (glpc == " ") && (glpc == null))
            {
                login login = new login(a);
                login.Show();
                MessageBox.Show("VUI LÒNG ĐĂNG NHẬP");
            }
            else
            {
                    string url = checkout(3) + checkout(14);
                    string url2 = checkout(3) + checkout(16);
                using (WebClient client = new WebClient())
                {
                    string givename = client.DownloadString(url);
                    string givepass = client.DownloadString(url2);
                    string[] lines = givename.Split('\n');
                    string[] lines1 = givepass.Split('\n');
                    for (int i = 0; i < 60; i++)
                    {
                        try
                        {
                            if (lines[i] != null || lines[i] == "")
                            {
                                string line = lines[i];
                                if (glp[0] == line)
                                {

                                    if (glp[1] == lines1[i])
                                    {
                                        i = 60;
                                        updatedata();
                                        name = glp[0];

                                    }
                                    else
                                    {
                                        MessageBox.Show("SAI NGÀY SINH!", "ĐĂNG NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        string ac = pass.Text;
                                        string bc = "";
                                        string c = ac + "\n" + bc;
                                        File.WriteAllText(checkout(8), c);
                                    }
                                }
                                else
                                {
                                        string ac = "";
                                        string bc = "";
                                        string c = ac + "\n" + bc;
                                    
                                }
                            }
                            else
                            {

                            }
                        }
                        catch
                        {
                            name = "";
                        }
                        
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("NHẬP HỌ VÀ TÊN KHÔNG DẤU VÀ VIẾT IN\nVÍ DỤ: NGUYEN VAN A\n\nNHẬP CHÍNH XÁC NGÀY SINH NẾU KHÔNG CÓ THÌ NHẬP 31/12/1999\n\n\nNGUYÊN NHÂN HỌ VÀ TÊN VIẾT HOA VÀ KHÔNG GHI DẤU LÀ DO ĐỒNG BỘ DỮ LIỆU VỚI WEBSITE 10A02.palat001.cf\nNẾU ỨNG DỤNG KHÔNG LÊN VUI LÒNG NHẬP CHÍNH XÁC HỌ VÀ TÊN KHÔNG DẤU VÀ NGÀY SINH NẾU VẪN KHÔNG ĐƯỢC LIÊN HỆ QUA ZALO : 0904548361", "HƯỚNG DẪN");
        }

        private void login_Shown(object sender, EventArgs e)
        {
            
        }

        private void login_Leave(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xacminhemail xd = new xacminhemail();
            xd.Show();
        }
    }
}
