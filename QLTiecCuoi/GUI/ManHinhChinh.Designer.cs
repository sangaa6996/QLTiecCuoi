﻿namespace GUI
{
    partial class ManHinhChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnhToolStripMenuItem,
            this.tiệcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sảnhToolStripMenuItem
            // 
            this.sảnhToolStripMenuItem.Name = "sảnhToolStripMenuItem";
            this.sảnhToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.sảnhToolStripMenuItem.Text = "Sảnh";
            // 
            // tiệcToolStripMenuItem
            // 
            this.tiệcToolStripMenuItem.Name = "tiệcToolStripMenuItem";
            this.tiệcToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.tiệcToolStripMenuItem.Text = "Tiệc";
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManHinhChinh";
            this.Text = "ManHinhChinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiệcToolStripMenuItem;
    }
}