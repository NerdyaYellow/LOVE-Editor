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
    public class CreateBlock
    {
        public CreateBlock()
        {
            editor = Program.editor;
            newBlock = new();
            newBlock.Parent = editor;
            newBlock.ContextMenuStrip = editor.Block.ContextMenuStrip;
            AddFunction();
        }

        private Editor editor;

        private PictureBox newBlock;

        private Point startPos;
        private Point endPos;

        private readonly Color highlightColor = Color.FromArgb(128, 0, 170, 255);

        private bool touch = false;
        public void Editor_MouseDown()
        {
            if (touch) return;
            touch = true;
            startPos = editor.PointToClient(Cursor.Position);
            newBlock.BringToFront();
            newBlock.BackColor = highlightColor;
        }

        public void Editor_MouseMove()
        {
            if (!touch) return;
            Editor_MouseUp(1);
            touch = true;
        }

        public void Editor_MouseUp(int type)
        {
            endPos = editor.PointToClient(Cursor.Position);
            newBlock.Location = startPos;
            newBlock.Size = new Size(endPos.X - startPos.X, endPos.Y - startPos.Y);
            newBlock.BackColor = highlightColor;
            if (type == 1) return;
            newBlock.BackColor = Color.White;
            touch = false;
            Program.output.outputlabel.Text = Program.output.outputlabel.Text.Insert(Program.output.outputlabel.Text.Length - 3, $"love.graphics.rectangle('fill',{newBlock.Location.X}, {newBlock.Location.Y}, {newBlock.Size.Width}, {newBlock.Size.Height})\r\n");
            newBlock = new();
            newBlock.Parent = editor;
            newBlock.ContextMenuStrip = editor.Block.ContextMenuStrip;
            AddFunction();
        }

        public void AddFunction()
        {
            foreach (ToolStripMenuItem item in newBlock.ContextMenuStrip.Items)
            {
                if (item.ToString() == "Delete")
                {
                    item.Click += Delete;
                }
                if (item.ToString() == "Select Image")
                {
                    item.Click += SelectImage;
                }
            }
        }


        private void SelectImage(object sender, EventArgs e)
        {
            var touch = editor.GetChildAtPoint(editor.PointToClient(Cursor.Position));
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Select an Image",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = ".png",
                Filter = "BMP|*.bmp|PNG|*.png|GIF|*.gif|JPG|*.jpg;*.jpeg|TIFF|*.tif;*.tiff",
                FilterIndex = 2
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (touch == null) return;
                if (touch.GetType() != typeof(PictureBox)) return;
                if (!Program.output.outputlabel.Text.Contains($"\r\nlove.graphics.rectangle('fill',{touch.Location.X}, {touch.Location.Y}, {touch.Size.Width}, {touch.Size.Height})")) return;
                try
                {
                    touch.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    Program.exception.Show();
                    Program.exception.ErrorText($"Check if the image is valid!");
                }
                return;
            }
            return;
        }


        public void Delete(object sender, EventArgs e)
        {
            var touch = editor.GetChildAtPoint(editor.PointToClient(Cursor.Position));
            if (touch == null) return;
            if (touch.GetType() != typeof(PictureBox)) return;
            if (!Program.output.outputlabel.Text.Contains($"\r\nlove.graphics.rectangle('fill',{touch.Location.X}, {touch.Location.Y}, {touch.Size.Width}, {touch.Size.Height})")) return;
            Program.output.outputlabel.Text = Program.output.outputlabel.Text.Replace($"\r\nlove.graphics.rectangle('fill',{touch.Location.X}, {touch.Location.Y}, {touch.Size.Width}, {touch.Size.Height})", "");
            touch.Enabled = false;
            touch.Dispose();
        }
    }
}
