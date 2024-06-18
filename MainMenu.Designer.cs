
namespace Hotel_Project_Portfolio
{
    partial class MainMenu
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
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSQLTEST = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookReservationToolStripMenuItem,
            this.modifyReservationToolStripMenuItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // bookReservationToolStripMenuItem
            // 
            this.bookReservationToolStripMenuItem.Name = "bookReservationToolStripMenuItem";
            this.bookReservationToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.bookReservationToolStripMenuItem.Text = "Book Reservation";
            this.bookReservationToolStripMenuItem.Click += new System.EventHandler(this.bookReservationToolStripMenuItem_Click);
            // 
            // modifyReservationToolStripMenuItem
            // 
            this.modifyReservationToolStripMenuItem.Name = "modifyReservationToolStripMenuItem";
            this.modifyReservationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modifyReservationToolStripMenuItem.Text = "Modify Reservation";
            this.modifyReservationToolStripMenuItem.Click += new System.EventHandler(this.modifyReservationToolStripMenuItem_Click);
            // 
            // lblSQLTEST
            // 
            this.lblSQLTEST.AutoSize = true;
            this.lblSQLTEST.Location = new System.Drawing.Point(12, 421);
            this.lblSQLTEST.Name = "lblSQLTEST";
            this.lblSQLTEST.Size = new System.Drawing.Size(140, 20);
            this.lblSQLTEST.TabIndex = 1;
            this.lblSQLTEST.Text = "SQL TEST LABEL";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSQLTEST);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyReservationToolStripMenuItem;
        private System.Windows.Forms.Label lblSQLTEST;
    }
}

