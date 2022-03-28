
namespace LOVE_Editor
{
    partial class Output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output));
            this.copy = new System.Windows.Forms.Button();
            this.outputlabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(0, 426);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(880, 31);
            this.copy.TabIndex = 1;
            this.copy.Text = "Copy to clipboard";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputlabel.ForeColor = System.Drawing.Color.White;
            this.outputlabel.Location = new System.Drawing.Point(0, 0);
            this.outputlabel.Multiline = true;
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.ReadOnly = true;
            this.outputlabel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputlabel.Size = new System.Drawing.Size(880, 420);
            this.outputlabel.TabIndex = 2;
            this.outputlabel.Text = "-- This text has been generated using LOVE Editor 1.0 by Nerdya. This is a pre-re" +
    "lease.\r\nfunction love.draw()\r\nend";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.copy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Output";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button copy;
        public System.Windows.Forms.TextBox outputlabel;
    }
}