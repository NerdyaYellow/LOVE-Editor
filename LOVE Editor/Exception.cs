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
    public partial class Exception : Form
    {
        public Exception()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ErrorText(string text)
        {
            this.label1.Text = text;
        }
    }
}
