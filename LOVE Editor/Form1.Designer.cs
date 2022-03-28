
namespace LOVE_Editor
{
    partial class Editor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.Block = new System.Windows.Forms.PictureBox();
            this.BlockMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mousePos = new System.Windows.Forms.Label();
            this.seeoutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Block)).BeginInit();
            this.BlockMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Block
            // 
            this.Block.BackColor = System.Drawing.Color.Transparent;
            this.Block.ContextMenuStrip = this.BlockMenu;
            this.Block.Location = new System.Drawing.Point(-40, 122);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(100, 87);
            this.Block.TabIndex = 0;
            this.Block.TabStop = false;
            // 
            // BlockMenu
            // 
            this.BlockMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.BlockMenu.Name = "contextMenuStrip1";
            this.BlockMenu.Size = new System.Drawing.Size(142, 48);
            this.BlockMenu.Text = "Block Menu";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem.Text = "Select Image";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // mousePos
            // 
            this.mousePos.AutoSize = true;
            this.mousePos.BackColor = System.Drawing.Color.Transparent;
            this.mousePos.ForeColor = System.Drawing.Color.White;
            this.mousePos.Location = new System.Drawing.Point(871, 504);
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(22, 15);
            this.mousePos.TabIndex = 1;
            this.mousePos.Text = "0,0";
            // 
            // seeoutput
            // 
            this.seeoutput.Location = new System.Drawing.Point(871, 479);
            this.seeoutput.Name = "seeoutput";
            this.seeoutput.Size = new System.Drawing.Size(75, 23);
            this.seeoutput.TabIndex = 3;
            this.seeoutput.Text = "See Output";
            this.seeoutput.UseVisualStyleBackColor = true;
            this.seeoutput.Click += new System.EventHandler(this.seeoutput_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(992, 528);
            this.Controls.Add(this.seeoutput);
            this.Controls.Add(this.mousePos);
            this.Controls.Add(this.Block);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.Text = "LOVE Editor 1.1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Block)).EndInit();
            this.BlockMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label mousePos;
        public System.Windows.Forms.PictureBox Block;
        private System.Windows.Forms.ContextMenuStrip BlockMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button seeoutput;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

