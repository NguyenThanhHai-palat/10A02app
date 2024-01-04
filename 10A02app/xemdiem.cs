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
    public partial class xemdiem : Form
    {
        public xemdiem()
        {
            InitializeComponent();
            
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("javascript:(function() { navigator.__defineGetter__('userAgent', function(){return 'Mozilla/5.0 (iPad; CPU OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1';});})();");
        }
    }
}
