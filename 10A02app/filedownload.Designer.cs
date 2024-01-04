namespace _10A02app
{
    partial class filedownload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.clc = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clc.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser2
            // 
            this.webBrowser2.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser2.Location = new System.Drawing.Point(0, 190);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(543, 190);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("https://pltupload.glitch.me/add.html", System.UriKind.Absolute);
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // clc
            // 
            this.clc.Controls.Add(this.listBox1);
            this.clc.Controls.Add(this.label1);
            this.clc.Controls.Add(this.webBrowser2);
            this.clc.Location = new System.Drawing.Point(0, 1);
            this.clc.Name = "clc";
            this.clc.Size = new System.Drawing.Size(543, 437);
            this.clc.TabIndex = 0;
            this.clc.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(543, 184);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "TẢI FILE LÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filedownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.clc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "filedownload";
            this.Text = "ĐĂNG TẢI FILE";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.clc.ResumeLayout(false);
            this.clc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser2;
        public System.Windows.Forms.Panel clc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}