namespace Calendar
{
    partial class LichNgay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.tbxSolarYear = new System.Windows.Forms.TextBox();
            this.tbxSolarMonth = new System.Windows.Forms.TextBox();
            this.tbxLunarMonth = new System.Windows.Forms.TextBox();
            this.tbxSolarDay = new System.Windows.Forms.TextBox();
            this.tbxLunarDay = new System.Windows.Forms.TextBox();
            this.btnSearchLunar = new System.Windows.Forms.Button();
            this.btnSearchSolar = new System.Windows.Forms.Button();
            this.chbxNhuan = new System.Windows.Forms.CheckBox();
            this.lblThu = new System.Windows.Forms.Label();
            this.tbxLunarYear = new System.Windows.Forms.TextBox();
            this.btnLastSolarYear = new System.Windows.Forms.Button();
            this.btnNextSolarYear = new System.Windows.Forms.Button();
            this.btnNextSolarMonth = new System.Windows.Forms.Button();
            this.btnLastSolarMonth = new System.Windows.Forms.Button();
            this.btnNextLunarYear = new System.Windows.Forms.Button();
            this.btnLastLunarYear = new System.Windows.Forms.Button();
            this.btnLastLunarMonth = new System.Windows.Forms.Button();
            this.btnNextLunarMonth = new System.Windows.Forms.Button();
            this.lblCanChi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblYear.Location = new System.Drawing.Point(59, 56);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(67, 29);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Năm";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMonth.Location = new System.Drawing.Point(59, 126);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(84, 29);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Tháng";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDay.Location = new System.Drawing.Point(59, 204);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(72, 29);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Ngày";
            // 
            // tbxSolarYear
            // 
            this.tbxSolarYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxSolarYear.Location = new System.Drawing.Point(170, 53);
            this.tbxSolarYear.Name = "tbxSolarYear";
            this.tbxSolarYear.Size = new System.Drawing.Size(174, 36);
            this.tbxSolarYear.TabIndex = 3;
            // 
            // tbxSolarMonth
            // 
            this.tbxSolarMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxSolarMonth.Location = new System.Drawing.Point(170, 123);
            this.tbxSolarMonth.Name = "tbxSolarMonth";
            this.tbxSolarMonth.Size = new System.Drawing.Size(174, 36);
            this.tbxSolarMonth.TabIndex = 5;
            // 
            // tbxLunarMonth
            // 
            this.tbxLunarMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxLunarMonth.Location = new System.Drawing.Point(440, 123);
            this.tbxLunarMonth.Name = "tbxLunarMonth";
            this.tbxLunarMonth.Size = new System.Drawing.Size(174, 36);
            this.tbxLunarMonth.TabIndex = 6;
            // 
            // tbxSolarDay
            // 
            this.tbxSolarDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxSolarDay.Location = new System.Drawing.Point(170, 201);
            this.tbxSolarDay.Name = "tbxSolarDay";
            this.tbxSolarDay.Size = new System.Drawing.Size(174, 36);
            this.tbxSolarDay.TabIndex = 7;
            // 
            // tbxLunarDay
            // 
            this.tbxLunarDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxLunarDay.Location = new System.Drawing.Point(440, 201);
            this.tbxLunarDay.Name = "tbxLunarDay";
            this.tbxLunarDay.Size = new System.Drawing.Size(174, 36);
            this.tbxLunarDay.TabIndex = 8;
            // 
            // btnSearchLunar
            // 
            this.btnSearchLunar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearchLunar.Location = new System.Drawing.Point(145, 260);
            this.btnSearchLunar.Name = "btnSearchLunar";
            this.btnSearchLunar.Size = new System.Drawing.Size(212, 50);
            this.btnSearchLunar.TabIndex = 9;
            this.btnSearchLunar.Text = "Tra cứu ngày âm";
            this.btnSearchLunar.UseVisualStyleBackColor = true;
            this.btnSearchLunar.Click += new System.EventHandler(this.btnSearchLunar_Click);
            // 
            // btnSearchSolar
            // 
            this.btnSearchSolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearchSolar.Location = new System.Drawing.Point(418, 260);
            this.btnSearchSolar.Name = "btnSearchSolar";
            this.btnSearchSolar.Size = new System.Drawing.Size(212, 50);
            this.btnSearchSolar.TabIndex = 10;
            this.btnSearchSolar.Text = "Tra cứu ngày dương";
            this.btnSearchSolar.UseVisualStyleBackColor = true;
            this.btnSearchSolar.Click += new System.EventHandler(this.btnSearchSolar_Click);
            // 
            // chbxNhuan
            // 
            this.chbxNhuan.AutoSize = true;
            this.chbxNhuan.Location = new System.Drawing.Point(495, 165);
            this.chbxNhuan.Name = "chbxNhuan";
            this.chbxNhuan.Size = new System.Drawing.Size(119, 20);
            this.chbxNhuan.TabIndex = 11;
            this.chbxNhuan.Text = "Là tháng nhuận";
            this.chbxNhuan.UseVisualStyleBackColor = true;
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblThu.Location = new System.Drawing.Point(165, 11);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(81, 29);
            this.lblThu.TabIndex = 12;
            this.lblThu.Text = "label1";
            // 
            // tbxLunarYear
            // 
            this.tbxLunarYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxLunarYear.Location = new System.Drawing.Point(440, 53);
            this.tbxLunarYear.Name = "tbxLunarYear";
            this.tbxLunarYear.Size = new System.Drawing.Size(174, 36);
            this.tbxLunarYear.TabIndex = 13;
            this.tbxLunarYear.TextChanged += new System.EventHandler(this.tbxLunarYear_TextChanged);
            // 
            // btnLastSolarYear
            // 
            this.btnLastSolarYear.Location = new System.Drawing.Point(282, 53);
            this.btnLastSolarYear.Name = "btnLastSolarYear";
            this.btnLastSolarYear.Size = new System.Drawing.Size(25, 32);
            this.btnLastSolarYear.TabIndex = 15;
            this.btnLastSolarYear.Text = "<";
            this.btnLastSolarYear.UseVisualStyleBackColor = true;
            this.btnLastSolarYear.Click += new System.EventHandler(this.btnLastSolarYear_Click);
            // 
            // btnNextSolarYear
            // 
            this.btnNextSolarYear.Location = new System.Drawing.Point(313, 53);
            this.btnNextSolarYear.Name = "btnNextSolarYear";
            this.btnNextSolarYear.Size = new System.Drawing.Size(25, 32);
            this.btnNextSolarYear.TabIndex = 16;
            this.btnNextSolarYear.Text = ">";
            this.btnNextSolarYear.UseVisualStyleBackColor = true;
            this.btnNextSolarYear.Click += new System.EventHandler(this.btnNextSolarYear_Click);
            // 
            // btnNextSolarMonth
            // 
            this.btnNextSolarMonth.Location = new System.Drawing.Point(313, 123);
            this.btnNextSolarMonth.Name = "btnNextSolarMonth";
            this.btnNextSolarMonth.Size = new System.Drawing.Size(25, 32);
            this.btnNextSolarMonth.TabIndex = 17;
            this.btnNextSolarMonth.Text = ">";
            this.btnNextSolarMonth.UseVisualStyleBackColor = true;
            this.btnNextSolarMonth.Click += new System.EventHandler(this.btnNextSolarMonth_Click);
            // 
            // btnLastSolarMonth
            // 
            this.btnLastSolarMonth.Location = new System.Drawing.Point(282, 123);
            this.btnLastSolarMonth.Name = "btnLastSolarMonth";
            this.btnLastSolarMonth.Size = new System.Drawing.Size(25, 32);
            this.btnLastSolarMonth.TabIndex = 18;
            this.btnLastSolarMonth.Text = "<";
            this.btnLastSolarMonth.UseVisualStyleBackColor = true;
            this.btnLastSolarMonth.Click += new System.EventHandler(this.btnLastSolarMonth_Click);
            // 
            // btnNextLunarYear
            // 
            this.btnNextLunarYear.Location = new System.Drawing.Point(579, 53);
            this.btnNextLunarYear.Name = "btnNextLunarYear";
            this.btnNextLunarYear.Size = new System.Drawing.Size(25, 32);
            this.btnNextLunarYear.TabIndex = 21;
            this.btnNextLunarYear.Text = ">";
            this.btnNextLunarYear.UseVisualStyleBackColor = true;
            this.btnNextLunarYear.Click += new System.EventHandler(this.btnNextLunarYear_Click);
            // 
            // btnLastLunarYear
            // 
            this.btnLastLunarYear.Location = new System.Drawing.Point(548, 53);
            this.btnLastLunarYear.Name = "btnLastLunarYear";
            this.btnLastLunarYear.Size = new System.Drawing.Size(25, 32);
            this.btnLastLunarYear.TabIndex = 22;
            this.btnLastLunarYear.Text = "<";
            this.btnLastLunarYear.UseVisualStyleBackColor = true;
            this.btnLastLunarYear.Click += new System.EventHandler(this.btnLastLunarYear_Click);
            // 
            // btnLastLunarMonth
            // 
            this.btnLastLunarMonth.Location = new System.Drawing.Point(548, 123);
            this.btnLastLunarMonth.Name = "btnLastLunarMonth";
            this.btnLastLunarMonth.Size = new System.Drawing.Size(25, 32);
            this.btnLastLunarMonth.TabIndex = 23;
            this.btnLastLunarMonth.Text = "<";
            this.btnLastLunarMonth.UseVisualStyleBackColor = true;
            this.btnLastLunarMonth.Click += new System.EventHandler(this.btnLastLunarMonth_Click);
            // 
            // btnNextLunarMonth
            // 
            this.btnNextLunarMonth.Location = new System.Drawing.Point(579, 123);
            this.btnNextLunarMonth.Name = "btnNextLunarMonth";
            this.btnNextLunarMonth.Size = new System.Drawing.Size(25, 32);
            this.btnNextLunarMonth.TabIndex = 24;
            this.btnNextLunarMonth.Text = ">";
            this.btnNextLunarMonth.UseVisualStyleBackColor = true;
            this.btnNextLunarMonth.Click += new System.EventHandler(this.btnNextLunarMonth_Click);
            // 
            // lblCanChi
            // 
            this.lblCanChi.AutoSize = true;
            this.lblCanChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCanChi.Location = new System.Drawing.Point(435, 11);
            this.lblCanChi.Name = "lblCanChi";
            this.lblCanChi.Size = new System.Drawing.Size(81, 29);
            this.lblCanChi.TabIndex = 25;
            this.lblCanChi.Text = "label1";
            // 
            // LichNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCanChi);
            this.Controls.Add(this.btnNextLunarMonth);
            this.Controls.Add(this.btnLastLunarMonth);
            this.Controls.Add(this.btnLastLunarYear);
            this.Controls.Add(this.btnNextLunarYear);
            this.Controls.Add(this.btnLastSolarMonth);
            this.Controls.Add(this.btnNextSolarMonth);
            this.Controls.Add(this.btnNextSolarYear);
            this.Controls.Add(this.btnLastSolarYear);
            this.Controls.Add(this.tbxLunarYear);
            this.Controls.Add(this.lblThu);
            this.Controls.Add(this.chbxNhuan);
            this.Controls.Add(this.btnSearchSolar);
            this.Controls.Add(this.btnSearchLunar);
            this.Controls.Add(this.tbxLunarDay);
            this.Controls.Add(this.tbxSolarDay);
            this.Controls.Add(this.tbxLunarMonth);
            this.Controls.Add(this.tbxSolarMonth);
            this.Controls.Add(this.tbxSolarYear);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Name = "LichNgay";
            this.Size = new System.Drawing.Size(700, 324);
            this.Load += new System.EventHandler(this.LichNgay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox tbxSolarYear;
        private System.Windows.Forms.TextBox tbxSolarMonth;
        private System.Windows.Forms.TextBox tbxLunarMonth;
        private System.Windows.Forms.TextBox tbxSolarDay;
        private System.Windows.Forms.TextBox tbxLunarDay;
        private System.Windows.Forms.Button btnSearchLunar;
        private System.Windows.Forms.Button btnSearchSolar;
        private System.Windows.Forms.CheckBox chbxNhuan;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.TextBox tbxLunarYear;
        private System.Windows.Forms.Button btnLastSolarYear;
        private System.Windows.Forms.Button btnNextSolarYear;
        private System.Windows.Forms.Button btnNextSolarMonth;
        private System.Windows.Forms.Button btnLastSolarMonth;
        private System.Windows.Forms.Button btnNextLunarYear;
        private System.Windows.Forms.Button btnLastLunarYear;
        private System.Windows.Forms.Button btnLastLunarMonth;
        private System.Windows.Forms.Button btnNextLunarMonth;
        private System.Windows.Forms.Label lblCanChi;
    }
}
