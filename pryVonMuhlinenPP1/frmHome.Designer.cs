﻿namespace pryVonMuhlinenPP1
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultGraphicSellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripMenuItem,
            this.sellsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.productsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // welcomeToolStripMenuItem
            // 
            this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
            this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.welcomeToolStripMenuItem.Text = "Welcome!";
            this.welcomeToolStripMenuItem.Click += new System.EventHandler(this.welcomeToolStripMenuItem_Click);
            // 
            // sellsToolStripMenuItem
            // 
            this.sellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultToolStripMenuItem1,
            this.consultByDateToolStripMenuItem,
            this.consultGraphicSellsToolStripMenuItem,
            this.registerToolStripMenuItem1,
            this.deleteSellsToolStripMenuItem});
            this.sellsToolStripMenuItem.Name = "sellsToolStripMenuItem";
            this.sellsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sellsToolStripMenuItem.Text = "Sells";
            // 
            // consultToolStripMenuItem1
            // 
            this.consultToolStripMenuItem1.Name = "consultToolStripMenuItem1";
            this.consultToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.consultToolStripMenuItem1.Text = "Consult sells";
            this.consultToolStripMenuItem1.Click += new System.EventHandler(this.consultToolStripMenuItem1_Click);
            // 
            // consultByDateToolStripMenuItem
            // 
            this.consultByDateToolStripMenuItem.Name = "consultByDateToolStripMenuItem";
            this.consultByDateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultByDateToolStripMenuItem.Text = "Consult sells by date";
            this.consultByDateToolStripMenuItem.Click += new System.EventHandler(this.consultByDateToolStripMenuItem_Click);
            // 
            // consultGraphicSellsToolStripMenuItem
            // 
            this.consultGraphicSellsToolStripMenuItem.Name = "consultGraphicSellsToolStripMenuItem";
            this.consultGraphicSellsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultGraphicSellsToolStripMenuItem.Text = "Consult Graphic Sells";
            this.consultGraphicSellsToolStripMenuItem.Click += new System.EventHandler(this.consultGraphicSellsToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.registerToolStripMenuItem1.Text = "Register sells";
            this.registerToolStripMenuItem1.Click += new System.EventHandler(this.registerToolStripMenuItem1_Click);
            // 
            // deleteSellsToolStripMenuItem
            // 
            this.deleteSellsToolStripMenuItem.Name = "deleteSellsToolStripMenuItem";
            this.deleteSellsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteSellsToolStripMenuItem.Text = "Delete sells";
            this.deleteSellsToolStripMenuItem.Click += new System.EventHandler(this.deleteSellsToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // consultToolStripMenuItem
            // 
            this.consultToolStripMenuItem.Name = "consultToolStripMenuItem";
            this.consultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultToolStripMenuItem.Text = "Consult clients";
            this.consultToolStripMenuItem.Click += new System.EventHandler(this.consultToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerToolStripMenuItem.Text = "Register client";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete client";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultToolStripMenuItem2,
            this.registerToolStripMenuItem2,
            this.editToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // consultToolStripMenuItem2
            // 
            this.consultToolStripMenuItem2.Name = "consultToolStripMenuItem2";
            this.consultToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.consultToolStripMenuItem2.Text = "Consult products";
            this.consultToolStripMenuItem2.Click += new System.EventHandler(this.consultToolStripMenuItem2_Click);
            // 
            // registerToolStripMenuItem2
            // 
            this.registerToolStripMenuItem2.Name = "registerToolStripMenuItem2";
            this.registerToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.registerToolStripMenuItem2.Text = "Register products";
            this.registerToolStripMenuItem2.Click += new System.EventHandler(this.registerToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editToolStripMenuItem.Text = "Edit products";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleteProductToolStripMenuItem.Text = "Delete product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Image = global::pryVonMuhlinenPP1.Properties.Resources.ice_cream_cone_ice_cream;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem welcomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem consultByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultGraphicSellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
    }
}