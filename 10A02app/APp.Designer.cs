namespace _10A02app
{
    partial class APp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APp));
            this.label1 = new System.Windows.Forms.Label();
            this.nameid = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noflabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐANG ĐĂNG NHẬP VỚI TƯ CÁCH LÀ: ";
            // 
            // nameid
            // 
            this.nameid.AutoSize = true;
            this.nameid.BackColor = System.Drawing.Color.Transparent;
            this.nameid.ForeColor = System.Drawing.Color.White;
            this.nameid.Location = new System.Drawing.Point(236, 448);
            this.nameid.Name = "nameid";
            this.nameid.Size = new System.Drawing.Size(0, 13);
            this.nameid.TabIndex = 1;
            this.nameid.Click += new System.EventHandler(this.nameid_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(31, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "THỜI KHÓA BIỂU";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(31, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "DANH SÁCH LỚP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 31);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Thêm..";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(216, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 383);
            this.panel1.TabIndex = 8;
            // 
            // noflabel
            // 
            this.noflabel.AutoSize = true;
            this.noflabel.BackColor = System.Drawing.Color.Transparent;
            this.noflabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noflabel.ForeColor = System.Drawing.Color.White;
            this.noflabel.Location = new System.Drawing.Point(30, 225);
            this.noflabel.Name = "noflabel";
            this.noflabel.Size = new System.Drawing.Size(0, 28);
            this.noflabel.TabIndex = 9;
            // 
            // APp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.noflabel);
            this.Controls.Add(this.nameid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APp";
            this.Text = "10A02 - V1.1.0.0";
            this.TransparencyKey = System.Drawing.Color.SaddleBrown;
            this.Load += new System.EventHandler(this.APp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label noflabel;
    }
}

