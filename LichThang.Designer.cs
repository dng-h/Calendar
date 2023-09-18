namespace Calendar
{
    partial class LichThang
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
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.Mon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Thu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvMonth = new System.Windows.Forms.ListView();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnLastYear = new System.Windows.Forms.Button();
            this.btnNextYear = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblYear.Location = new System.Drawing.Point(42, 17);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(67, 29);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Năm";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMonth.Location = new System.Drawing.Point(361, 17);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(84, 29);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Tháng";
            // 
            // tbxYear
            // 
            this.tbxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxYear.Location = new System.Drawing.Point(115, 14);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(172, 36);
            this.tbxYear.TabIndex = 2;
            this.tbxYear.TextChanged += new System.EventHandler(this.tbxYear_TextChanged);
            // 
            // tbxMonth
            // 
            this.tbxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxMonth.Location = new System.Drawing.Point(463, 14);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(172, 36);
            this.tbxMonth.TabIndex = 3;
            this.tbxMonth.TextChanged += new System.EventHandler(this.tbxMonth_TextChanged);
            // 
            // Mon
            // 
            this.Mon.Text = "Mon";
            this.Mon.Width = 75;
            // 
            // Tue
            // 
            this.Tue.Text = "Tue";
            this.Tue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tue.Width = 75;
            // 
            // Wed
            // 
            this.Wed.Text = "Wed";
            this.Wed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wed.Width = 75;
            // 
            // Thu
            // 
            this.Thu.Text = "Thu";
            this.Thu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Thu.Width = 75;
            // 
            // Fri
            // 
            this.Fri.Text = "Fri";
            this.Fri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fri.Width = 75;
            // 
            // Sat
            // 
            this.Sat.Text = "Sat";
            this.Sat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sat.Width = 75;
            // 
            // Sun
            // 
            this.Sun.Text = "Sun";
            this.Sun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sun.Width = 75;
            // 
            // lsvMonth
            // 
            this.lsvMonth.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mon,
            this.Tue,
            this.Wed,
            this.Thu,
            this.Fri,
            this.Sat,
            this.Sun});
            this.lsvMonth.HideSelection = false;
            this.lsvMonth.Location = new System.Drawing.Point(3, 81);
            this.lsvMonth.Name = "lsvMonth";
            this.lsvMonth.Size = new System.Drawing.Size(694, 230);
            this.lsvMonth.TabIndex = 4;
            this.lsvMonth.UseCompatibleStateImageBehavior = false;
            this.lsvMonth.View = System.Windows.Forms.View.Details;
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Location = new System.Drawing.Point(572, 14);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(28, 34);
            this.btnLastMonth.TabIndex = 5;
            this.btnLastMonth.Text = "<";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnLastYear
            // 
            this.btnLastYear.Location = new System.Drawing.Point(225, 14);
            this.btnLastYear.Name = "btnLastYear";
            this.btnLastYear.Size = new System.Drawing.Size(28, 34);
            this.btnLastYear.TabIndex = 6;
            this.btnLastYear.Text = "<";
            this.btnLastYear.UseVisualStyleBackColor = true;
            this.btnLastYear.Click += new System.EventHandler(this.btnLastYear_Click);
            // 
            // btnNextYear
            // 
            this.btnNextYear.Location = new System.Drawing.Point(250, 14);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(28, 34);
            this.btnNextYear.TabIndex = 7;
            this.btnNextYear.Text = ">";
            this.btnNextYear.UseVisualStyleBackColor = true;
            this.btnNextYear.Click += new System.EventHandler(this.btnNextYear_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(597, 14);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(28, 34);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // LichThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnNextYear);
            this.Controls.Add(this.btnLastYear);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.lsvMonth);
            this.Controls.Add(this.tbxMonth);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Name = "LichThang";
            this.Size = new System.Drawing.Size(700, 324);
            this.Load += new System.EventHandler(this.LichThang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.ColumnHeader Mon;
        private System.Windows.Forms.ColumnHeader Tue;
        private System.Windows.Forms.ColumnHeader Wed;
        private System.Windows.Forms.ColumnHeader Thu;
        private System.Windows.Forms.ColumnHeader Fri;
        private System.Windows.Forms.ColumnHeader Sat;
        private System.Windows.Forms.ColumnHeader Sun;
        private System.Windows.Forms.ListView lsvMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnLastYear;
        private System.Windows.Forms.Button btnNextYear;
        private System.Windows.Forms.Button btnNextMonth;
    }
}
