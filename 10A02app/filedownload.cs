using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using HtmlAgilityPack;
using MVE;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10A02app
{
    public partial class filedownload : Form
    {
        public string checkout(int linenum)
        {
            PALATAPP.Readfile readfile = new PALATAPP.Readfile();
            string[] LM = readfile.allLines("data\\app.a");
            return LM[linenum];
        }
        class datares
        {
            public string name;
            public string filepath;
            public string description;
        }
        int cas;
        List<string> documentdata = new List<string>();
        List<string> hrefList = new List<string>();
        List<string> filen = new List<string>();
        List<string> des = new List<string>();
        List<string> datelst = new List<string>();
        public filedownload()
        {
            InitializeComponent();
            dowehnload();
        }
        void dowehnload()
        {
            try{
                HtmlWeb web = new HtmlWeb();
                web.OverrideEncoding = Encoding.UTF8;
                HtmlAgilityPack.HtmlDocument document = web.Load("https://pltupload.glitch.me/preview");
                HtmlNodeCollection urlfile = document.DocumentNode.SelectNodes("//a");
                HtmlNodeCollection mota = document.DocumentNode.SelectNodes("//mrc");
                HtmlNodeCollection tenfile = document.DocumentNode.SelectNodes("//arc");
                HtmlNodeCollection ngaygio = document.DocumentNode.SelectNodes("//d");
                if (ngaygio != null)
                {
                    foreach (HtmlNode spanNode in ngaygio)
                    {
                        string spanContent = spanNode.InnerHtml;
                        datelst.Add(spanContent);
                    }
                }
                if (tenfile != null)
                {
                    foreach (HtmlNode spanNode in tenfile)
                    {
                        string spanContent = spanNode.InnerHtml;
                        filen.Add(spanContent);
                    }
                }
                if (mota != null)
                {
                    foreach (HtmlNode sp2anNode in mota)
                    {
                        string spanContents = sp2anNode.InnerHtml;
                        des.Add(spanContents);
                    }
                }
                if (urlfile != null)
                {
                    foreach (HtmlNode anchorNode in urlfile)
                    {
                        string hrefValue = anchorNode.GetAttributeValue("href", "");
                        hrefList.Add(hrefValue);
                    }
                }
                for (int i = 0; urlfile.Count > i; i++)
                {
                    listBox1.Items.Add(des[i] + "-" + filen[i] + "-" + datelst[i]);
                    documentdata.Add(des[i] + "-" + filen[i] + "-" + datelst[i]);
                }

            } catch(Exception e) {  }
            

        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            e.Cancel = true;
            string filepath = null;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = e.Url.Segments[e.Url.Segments.Length - 1];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog1.FileName;
                WebClient client = new WebClient();
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(e.Url, filepath);
            }
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                string selectedContent = listBox1.SelectedItem.ToString();
                PALATAPP pALATAPP = new PALATAPP();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Tải Xuống";
                saveFileDialog.Filter = "MS WORD|*.docx|PDF|*.pdf|MS WORD|*.doc";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    WebClient webClient = new WebClient();
                    webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                    webClient.DownloadFile("https://pltupload.glitch.me/" + hrefList[selectedIndex], saveFileDialog.FileName);
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
