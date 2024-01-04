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
    public partial class dsl : Form
    {
        public dsl()
        {
            APp aPp = new APp();    
            string url = aPp.checkout(3)+ aPp.checkout(17);
            InitializeComponent();
            webBrowser1.Navigate(url);
        }
    }
}
