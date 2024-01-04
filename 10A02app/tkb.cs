using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10A02app
{
    public partial class tkb : Form
    {
        public tkb()
        {
            APp aPp = new APp();
            string url = aPp.checkout(3) + aPp.checkout(18);
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = url;
        }
    }
}
