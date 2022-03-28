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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            Program.createblock.Editor_MouseDown();
        }

        private void Editor_MouseMove(object sender, MouseEventArgs e)
        {
            this.mousePos.Text = $"{this.PointToClient(Cursor.Position).X}, {this.PointToClient(Cursor.Position).Y}, {Cursor.Position.X}, {Cursor.Position.Y}";
            Program.createblock.Editor_MouseMove();
        }

        private void Editor_MouseUp(object sender, MouseEventArgs e)
        {
            Program.createblock.Editor_MouseUp(0);
        }

        private void seeoutput_Click(object sender, EventArgs e)
        {
            Program.output.Show();
        }
    }
}
