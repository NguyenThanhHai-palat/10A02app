using MVE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using HtmlAgilityPack;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Policy;
using System.Diagnostics;

namespace _10A02app
{
    public partial class APp : Form
    {
        int c = 0;
        public string checkout(int linenum)
        {
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] LM = readfile.allLines("data\\app.a");
            return LM[linenum];
        }
        public APp()
        {
            string[] a = { };
            this.ShowInTaskbar = false;
            InitializeComponent();
            onchecked();
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] glp = readfile.allLines(checkout(8));
            login login = new login(a);
            if (login.name.Length < 1)
            {
                this.Close();

            }
            loadversion(); 
        }

        public void onchecked()
        {
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();      
            string[] glp = readfile.allLines(checkout(8));
            if ((glp[0] == "") && (glp[0] == " "))
            {
                this.Close();
                
            }
            else
            {
                string url = checkout(3) + checkout(15);
                
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Encoding = UTF8Encoding.UTF8;
                        string content = client.DownloadString(url);
                        string[] lines = content.Split('\n');
                        foreach (string line in lines)
                        {
                            comboBox1.Items.Add(line);
                        }
                    }
                }
                catch
                {

                }
                this.ShowInTaskbar = true;

            }

            nameid.Text = glp[0];
        }

        private void nameid_Click(object sender, EventArgs e)
        {

        }
        
        void loadversion()
        {

            using (WebClient client = new WebClient())
            {
                client.Encoding = UTF8Encoding.UTF8;
                string content = client.DownloadString(checkout(3)+ "/data/source/app/version.a");
                string[] lines = content.Split('\n');
                if (Application.ProductVersion.ToString() != lines[0])
                {
                    DialogResult dialogResult = MessageBox.Show("Đã có phiên bản mới bạn có muốn cập nhật?", "Thông Báo Cập Nhật", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start("UpdateService.exe");
                        this.Close();
                    }
                }
            }
            
        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }
        void repair_updateservice(int ver)
        {

        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Tài Liệu")
                {
                    panel1.Controls.Clear();
                    filedownload filedownload = new filedownload();
                    panel1.Controls.Add(filedownload.clc);
                }
                else if (comboBox1.Text == "Thông tin giáo viên")
                {
                    panel1.Controls.Clear();
                    ttgv ttgv = new ttgv();
                    panel1.Controls.Add(ttgv.webBrowser1);
                }
                else if (comboBox1.Text == "Về Phần Mềm")
                {
                    panel1.Controls.Clear();
                    AboutBox1 aboutBox1 = new AboutBox1();
                    panel1.Controls.Add(aboutBox1.tableLayoutPanel);
                }
                else if (comboBox1.Text == "Tra Cứu Điểm")
                {
                    panel1.Controls.Clear();
                    custombox1 custombox1 = new custombox1();
                    panel1.Controls.Add(custombox1.webBrowser1);
                    custombox1.webBrowser1.Navigate("https://tracuu.vnedu.vn/so-lien-lac/tra-cuu-diem/",null,null, "User-Agent: Mozilla/5.0 (iPad; CPU OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1");
                }
                else if (comboBox1.Text == checkout(33))
                {
                    panel1.Controls.Clear();
                    custombox1 custombox1 = new custombox1();
                    panel1.Controls.Add(custombox1.webBrowser1);
                    custombox1.webBrowser1.Navigate(checkout(34), null, null, "User-Agent: Mozilla/5.0 (iPad; CPU OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1");
                }
                else if (comboBox1.Text == checkout(35))
                {
                    panel1.Controls.Clear();
                    custombox1 custombox1 = new custombox1();
                    panel1.Controls.Add(custombox1.webBrowser1);
                    custombox1.webBrowser1.Navigate(checkout(36), null, null, "User-Agent: Mozilla/5.0 (iPad; CPU OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1");
                }
                else if (comboBox1.Text == checkout(37))
                {

                    panel1.Controls.Clear();
                    custombox1 custombox1 = new custombox1();
                    panel1.Controls.Add(custombox1.webBrowser1);
                    custombox1.webBrowser1.Navigate(checkout(37), null, null, "User-Agent: Mozilla/5.0 (iPad; CPU OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1");
                }
                else
                {
                    panel1.Controls.Clear();
                }
            }
            catch
            {

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Thêm..";
            panel1.Controls.Clear();
            tkb tkb = new tkb();
            panel1.Controls.Add(tkb.clc);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dsl dsl = new dsl();
            panel1.Controls.Add(dsl.webBrowser1);
        }

        private void APp_Load(object sender, EventArgs e)
        {

        }
    }
}
