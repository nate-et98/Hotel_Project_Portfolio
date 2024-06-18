
namespace Hotel_Project_Portfolio
{
    partial class BookRes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gstFName = new System.Windows.Forms.TextBox();
            this.gstLName = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lstRoomNum = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check-In Date";
            // 
            // SDate
            // 
            this.SDate.Location = new System.Drawing.Point(207, 132);
            this.SDate.Name = "SDate";
            this.SDate.Size = new System.Drawing.Size(282, 26);
            this.SDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Check-Out Date";
            // 
            // EDate
            // 
            this.EDate.Location = new System.Drawing.Point(207, 186);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(282, 26);
            this.EDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of Guests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Room Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gstFName
            // 
            this.gstFName.Location = new System.Drawing.Point(207, 46);
            this.gstFName.Name = "gstFName";
            this.gstFName.Size = new System.Drawing.Size(282, 26);
            this.gstFName.TabIndex = 9;
            // 
            // gstLName
            // 
            this.gstLName.Location = new System.Drawing.Point(207, 86);
            this.gstLName.Name = "gstLName";
            this.gstLName.Size = new System.Drawing.Size(282, 26);
            this.gstLName.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(207, 250);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lstRoomNum
            // 
            this.lstRoomNum.FormattingEnabled = true;
            this.lstRoomNum.ItemHeight = 20;
            this.lstRoomNum.Location = new System.Drawing.Point(207, 308);
            this.lstRoomNum.Name = "lstRoomNum";
            this.lstRoomNum.Size = new System.Drawing.Size(120, 104);
            this.lstRoomNum.TabIndex = 12;
            this.lstRoomNum.SelectedIndexChanged += new System.EventHandler(this.lstRoomNum_SelectedIndexChanged);
            // 
            // BookRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 515);
            this.Controls.Add(this.lstRoomNum);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gstLName);
            this.Controls.Add(this.gstFName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookRes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BookRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker SDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gstFName;
        private System.Windows.Forms.TextBox gstLName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox lstRoomNum;
    }
}