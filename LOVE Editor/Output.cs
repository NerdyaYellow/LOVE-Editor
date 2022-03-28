using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOVE_Editor
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }
        
        [STAThread]
        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.outputlabel.Text);
        }
    }
}
