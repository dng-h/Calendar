namespace Calendar
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
            this.pnlLich = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnLichThang = new System.Windows.Forms.Button();
            this.btnLichNgay = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLich
            // 
            this.pnlLich.Location = new System.Drawing.Point(1, 127);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(700, 323);
            this.pnlLich.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnLichThang);
            this.pnlControl.Controls.Add(this.btnLichNgay);
            this.pnlControl.Location = new System.Drawing.Point(1, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(700, 118);
            this.pnlControl.TabIndex = 1;
            // 
            // btnLichThang
            // 
            this.btnLichThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLichThang.Location = new System.Drawing.Point(418, 41);
            this.btnLichThang.Name = "btnLichThang";
            this.btnLichThang.Size = new System.Drawing.Size(219, 39);
            this.btnLichThang.TabIndex = 1;
            this.btnLichThang.Text = "Xem lịch theo tháng";
            this.btnLichThang.UseVisualStyleBackColor = true;
            this.btnLichThang.Click += new System.EventHandler(this.btnLichThang_Click);
            // 
            // btnLichNgay
            // 
            this.btnLichNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLichNgay.Location = new System.Drawing.Point(54, 41);
            this.btnLichNgay.Name = "btnLichNgay";
            this.btnLichNgay.Size = new System.Drawing.Size(219, 39);
            this.btnLichNgay.TabIndex = 0;
            this.btnLichNgay.Text = "Xem lịch theo ngày";
            this.btnLichNgay.UseVisualStyleBackColor = true;
            this.btnLichNgay.Click += new System.EventHandler(this.btnLichNgay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlLich);
            this.Name = "frmMain";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLich;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnLichThang;
        private System.Windows.Forms.Button btnLichNgay;
    }
}

