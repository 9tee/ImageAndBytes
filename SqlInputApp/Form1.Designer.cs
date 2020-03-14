namespace SqlInputApp
{
    partial class Form1
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
            this.ConnectionStringTb = new System.Windows.Forms.TextBox();
            this.ConnectBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ImagePathTb = new System.Windows.Forms.TextBox();
            this.ImageChooseBt = new System.Windows.Forms.Button();
            this.addStudentBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionStringTb
            // 
            this.ConnectionStringTb.Location = new System.Drawing.Point(6, 19);
            this.ConnectionStringTb.Name = "ConnectionStringTb";
            this.ConnectionStringTb.Size = new System.Drawing.Size(434, 20);
            this.ConnectionStringTb.TabIndex = 0;
            // 
            // ConnectBt
            // 
            this.ConnectBt.Location = new System.Drawing.Point(446, 19);
            this.ConnectBt.Name = "ConnectBt";
            this.ConnectBt.Size = new System.Drawing.Size(75, 20);
            this.ConnectBt.TabIndex = 2;
            this.ConnectBt.Text = "Connect";
            this.ConnectBt.UseVisualStyleBackColor = true;
            this.ConnectBt.Click += new System.EventHandler(this.ConnectBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectionStringTb);
            this.groupBox1.Controls.Add(this.ConnectBt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection String:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 137);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // ImagePathTb
            // 
            this.ImagePathTb.Location = new System.Drawing.Point(129, 82);
            this.ImagePathTb.Name = "ImagePathTb";
            this.ImagePathTb.Size = new System.Drawing.Size(323, 20);
            this.ImagePathTb.TabIndex = 5;
            // 
            // ImageChooseBt
            // 
            this.ImageChooseBt.Location = new System.Drawing.Point(458, 82);
            this.ImageChooseBt.Name = "ImageChooseBt";
            this.ImageChooseBt.Size = new System.Drawing.Size(75, 20);
            this.ImageChooseBt.TabIndex = 6;
            this.ImageChooseBt.Text = "Chọn ảnh";
            this.ImageChooseBt.UseVisualStyleBackColor = true;
            this.ImageChooseBt.Click += new System.EventHandler(this.ImageChooseBt_Click);
            // 
            // addStudentBt
            // 
            this.addStudentBt.Location = new System.Drawing.Point(236, 152);
            this.addStudentBt.Name = "addStudentBt";
            this.addStudentBt.Size = new System.Drawing.Size(165, 23);
            this.addStudentBt.TabIndex = 10;
            this.addStudentBt.Text = "Nhập";
            this.addStudentBt.UseVisualStyleBackColor = true;
            this.addStudentBt.Click += new System.EventHandler(this.addStudentBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 229);
            this.Controls.Add(this.addStudentBt);
            this.Controls.Add(this.ImageChooseBt);
            this.Controls.Add(this.ImagePathTb);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectionStringTb;
        private System.Windows.Forms.Button ConnectBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox ImagePathTb;
        private System.Windows.Forms.Button ImageChooseBt;
        private System.Windows.Forms.Button addStudentBt;
    }
}

