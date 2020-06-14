﻿namespace QuanLyQuanCafe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phímTắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAllTable = new System.Windows.Forms.Button();
            this.btn1stFloor = new System.Windows.Forms.Button();
            this.btn2ndFloor = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.đăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phímTắtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // phímTắtToolStripMenuItem
            // 
            this.phímTắtToolStripMenuItem.Name = "phímTắtToolStripMenuItem";
            this.phímTắtToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.phímTắtToolStripMenuItem.Text = "Phím tắt";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // đăngToolStripMenuItem
            // 
            this.đăngToolStripMenuItem.Name = "đăngToolStripMenuItem";
            this.đăngToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.đăngToolStripMenuItem.Text = "Đăng xuất ";
            // 
            // btnAllTable
            // 
            this.btnAllTable.Location = new System.Drawing.Point(13, 37);
            this.btnAllTable.Name = "btnAllTable";
            this.btnAllTable.Size = new System.Drawing.Size(75, 33);
            this.btnAllTable.TabIndex = 2;
            this.btnAllTable.Text = "Tất cả bàn";
            this.btnAllTable.UseVisualStyleBackColor = true;
            // 
            // btn1stFloor
            // 
            this.btn1stFloor.Location = new System.Drawing.Point(94, 37);
            this.btn1stFloor.Name = "btn1stFloor";
            this.btn1stFloor.Size = new System.Drawing.Size(75, 33);
            this.btn1stFloor.TabIndex = 3;
            this.btn1stFloor.Text = "Tầng 1";
            this.btn1stFloor.UseVisualStyleBackColor = true;
            // 
            // btn2ndFloor
            // 
            this.btn2ndFloor.Location = new System.Drawing.Point(175, 37);
            this.btn2ndFloor.Name = "btn2ndFloor";
            this.btn2ndFloor.Size = new System.Drawing.Size(75, 33);
            this.btn2ndFloor.TabIndex = 4;
            this.btn2ndFloor.Text = "Tầng 2";
            this.btn2ndFloor.UseVisualStyleBackColor = true;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(13, 76);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(439, 529);
            this.pnlTable.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.btn2ndFloor);
            this.Controls.Add(this.btn1stFloor);
            this.Controls.Add(this.btnAllTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ QUÁN CAFE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phímTắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngToolStripMenuItem;
        private System.Windows.Forms.Button btnAllTable;
        private System.Windows.Forms.Button btn1stFloor;
        private System.Windows.Forms.Button btn2ndFloor;
        private System.Windows.Forms.FlowLayoutPanel pnlTable;
    }
}