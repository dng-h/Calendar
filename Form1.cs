using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLichNgay_Click(object sender, EventArgs e)
        {
            pnlLich.Controls.Add(LichNgay.Instance);
            LichNgay.Instance.Dock = DockStyle.Fill;
            LichNgay.Instance.BringToFront();
            btnLichNgay.Enabled = false;
            btnLichThang.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlLich.Controls.Add(LichNgay.Instance);
            LichNgay.Instance.Dock = DockStyle.Fill;
            LichNgay.Instance.BringToFront();
            btnLichNgay.Enabled = false;
        }

        private void btnLichThang_Click(object sender, EventArgs e)
        {
            pnlLich.Controls.Add(LichThang.Instance);
            LichThang.Instance.Dock = DockStyle.Fill;
            LichThang.Instance.BringToFront();
            btnLichThang.Enabled = false;
            btnLichNgay.Enabled = true;
        }
    }
}
