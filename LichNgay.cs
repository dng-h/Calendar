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
    public partial class LichNgay : UserControl
    {
        private static LichNgay _instance;
        public static LichNgay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LichNgay();
                return _instance;
            }
        }
        public LichNgay()
        {
            InitializeComponent();
        }

        private void LichNgay_Load(object sender, EventArgs e)
        {
            tbxSolarYear.Text = "";
            tbxSolarMonth.Text = "";
            tbxSolarDay.Text = "";
            tbxLunarYear.Text = "";
            tbxLunarMonth.Text = "";
            tbxLunarDay.Text = "";
            DateTime date = DateTime.Now;
            tbxSolarYear.Text = date.Year.ToString();
            tbxSolarMonth.Text = date.Month.ToString();
            tbxSolarDay.Text = date.Day.ToString();
            tinhThu(date.Year, date.Month, date.Day);
            ChuyenDoi chuyenDoi = new ChuyenDoi();
            string lunarDate = chuyenDoi.convertSolarToLunar(date.Day, date.Month, date.Year);
            int index = 0;
            for(int i = 0; i < lunarDate.Length; i++)
            {
                if (lunarDate[i] != '/')
                {
                    tbxLunarDay.Text += lunarDate[i];
                }    
                else
                {
                    index = i + 1;
                    break;
                }    
            }    
            for(int i = index; i < lunarDate.Length; i++)
            {
                if (lunarDate[i] != '/')
                {
                    tbxLunarMonth.Text += lunarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            for (int i = index; i < lunarDate.Length; i++)
            {
                tbxLunarYear.Text += lunarDate[i];
            }
            tinhCanChi(tbxLunarYear.Text);
        }

        private void tinhThu(int year, int month, int day)
        {
            var thu = new DateTime(year, month, day).DayOfWeek;
            switch (thu)
            {
                case DayOfWeek.Monday:
                    lblThu.Text = "Thứ hai"; break;
                case DayOfWeek.Tuesday:
                    lblThu.Text = "Thứ ba"; break;
                case DayOfWeek.Wednesday:
                    lblThu.Text = "Thứ tư"; break;
                case DayOfWeek.Thursday:
                    lblThu.Text = "Thứ năm"; break;
                case DayOfWeek.Friday:
                    lblThu.Text = "Thứ sáu"; break;
                case DayOfWeek.Saturday:
                    lblThu.Text = "Thứ bảy"; break;
                case DayOfWeek.Sunday:
                    lblThu.Text = "Chủ nhật"; break;
            }
        }

        private void btnSearchLunar_Click(object sender, EventArgs e)
        {
            tbxLunarYear.Text = "";
            tbxLunarMonth.Text = "";
            tbxLunarDay.Text = "";
            int day = int.Parse(tbxSolarDay.Text);
            int month = int.Parse(tbxSolarMonth.Text);
            int year = int.Parse(tbxSolarYear.Text);
            tinhThu(year, month, day);
            if (month > 12 || month < 1)
            {
                DialogResult result = MessageBox.Show("Sai ngày tháng, xin mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                if(result == DialogResult.OK) return;
            }
            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    if(day > 29)
                    {
                        DialogResult result = MessageBox.Show("Sai ngày tháng, xin mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                        if (result == DialogResult.OK) return;
                    }    
                }
                if (year % 4 != 0)
                {
                    if(day > 28)
                    {
                        DialogResult result = MessageBox.Show("Sai ngày tháng, xin mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                        if (result == DialogResult.OK) return;
                    }    
                }
            }
            if (new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(month))
            {
                if(day > 31)
                {
                    DialogResult result = MessageBox.Show("Sai ngày tháng, xin mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                    if (result == DialogResult.OK) return;
                }    
            } 
            if(new int[] {4,6,9,11}.Contains(month))
            {
                if(day > 30)
                {
                    DialogResult result = MessageBox.Show("Sai ngày tháng, xin mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                    if (result == DialogResult.OK) return;
                }    
            }
            ChuyenDoi chuyenDoi = new ChuyenDoi();
            string lunarDate = chuyenDoi.convertSolarToLunar(day, month, year);
            int index = 0;
            for (int i = 0; i < lunarDate.Length; i++)
            {
                if (lunarDate[i] != '/')
                {
                    tbxLunarDay.Text += lunarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            for (int i = index; i < lunarDate.Length; i++)
            {
                if (lunarDate[i] != '/')
                {
                    tbxLunarMonth.Text += lunarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            for (int i = index; i < lunarDate.Length; i++)
            {
                tbxLunarYear.Text += lunarDate[i];
            }
            tinhCanChi(tbxLunarYear.Text);
        }

        private void btnSearchSolar_Click(object sender, EventArgs e)
        {
            tbxSolarYear.Text = "";
            tbxSolarMonth.Text = "";
            tbxSolarDay.Text = "";
            int day = int.Parse(tbxLunarDay.Text);
            int month = int.Parse(tbxLunarMonth.Text);
            int year = int.Parse(tbxLunarYear.Text);
            int lunarLeap;
            if (chbxNhuan.Checked)
            {
                lunarLeap = 1;
            }
            else lunarLeap = 0;
            ChuyenDoi chuyenDoi = new ChuyenDoi();
            string solarDate = chuyenDoi.convertLunarToSolar(day, month, year, lunarLeap);
            if(solarDate == "0/0/0")
            {
                DialogResult result = MessageBox.Show("Sai ngày tháng, xin mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.OK) return;
            }    
            int index = 0;
            for (int i = 0; i < solarDate.Length; i++)
            {
                if (solarDate[i] != '/')
                {
                    tbxSolarDay.Text += solarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            for (int i = index; i < solarDate.Length; i++)
            {
                if (solarDate[i] != '/')
                {
                    tbxSolarMonth.Text += solarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            for (int i = index; i < solarDate.Length; i++)
            {
                tbxSolarYear.Text += solarDate[i];
            }
            day = int.Parse(tbxSolarDay.Text);
            month = int.Parse(tbxSolarMonth.Text);
            year = int.Parse(tbxSolarYear.Text);
            tinhThu(year, month, day);
        }

        private void tinhCanChi(string Year)
        {
            int lunarYear = int.Parse(Year);
            string lYear = "";
            switch ((lunarYear + 6) % 10)
            {
                case 0:
                    lYear = "Giáp "; break;
                case 1:
                    lYear = "Ất "; break;
                case 2:
                    lYear = "Bính "; break;
                case 3:
                    lYear = "Đinh "; break;
                case 4:
                    lYear = "Mậu "; break;
                case 5:
                    lYear = "Kỷ "; break;
                case 6:
                    lYear = "Canh "; break;
                case 7:
                    lYear = "Tân "; break;
                case 8:
                    lYear = "Nhâm "; break;
                case 9:
                    lYear = "Quý "; break;
            }
            switch((lunarYear + 8)%12)
            {
                case 0:
                    lYear += "Tý"; break;
                case 1:
                    lYear += "Sửu"; break;
                case 2:
                    lYear += "Dần"; break;
                case 3:
                    lYear += "Mão"; break;
                case 4:
                    lYear += "Thìn"; break;
                case 5:
                    lYear += "Tỵ"; break;
                case 6:
                    lYear += "Ngọ"; break;
                case 7:
                    lYear += "Mùi"; break;
                case 8:
                    lYear += "Thân"; break;
                case 9:
                    lYear += "Dậu"; break;
                case 10:
                    lYear += "Tuất"; break;
                case 11:
                    lYear += "Hợi"; break;
            }
            lblCanChi.Text = lYear;
        }

        private void tbxLunarYear_TextChanged(object sender, EventArgs e)
        {
            if (tbxLunarYear.Text == "") return;
            tinhCanChi(tbxLunarYear.Text);
        }

        private void btnLastSolarYear_Click(object sender, EventArgs e)
        {
            int solarYear = int.Parse(tbxSolarYear.Text);
            solarYear--;
            tbxSolarYear.Text = solarYear.ToString();
        }

        private void btnNextSolarYear_Click(object sender, EventArgs e)
        {
            int solarYear = int.Parse(tbxSolarYear.Text);
            solarYear++;
            tbxSolarYear.Text = solarYear.ToString();
        }

        private void btnLastSolarMonth_Click(object sender, EventArgs e)
        {
            int solarMonth = int.Parse(tbxSolarMonth.Text);
            int solarYear = int.Parse(tbxSolarYear.Text);
            solarMonth--;
            if (solarMonth == 0)
            {
                solarMonth = 12;
                solarYear--;
            }
            tbxSolarYear.Text = solarYear.ToString();
            tbxSolarMonth.Text = solarMonth.ToString();
        }

        private void btnNextSolarMonth_Click(object sender, EventArgs e)
        {
            int solarMonth = int.Parse(tbxSolarMonth.Text);
            int solarYear = int.Parse(tbxSolarYear.Text);
            solarMonth++;
            if (solarMonth == 13)
            {
                solarMonth = 1;
                solarYear++;
            }
            tbxSolarYear.Text = solarYear.ToString();
            tbxSolarMonth.Text = solarMonth.ToString();
        }

        private void btnLastLunarYear_Click(object sender, EventArgs e)
        {
            int lunarYear = int.Parse(tbxLunarYear.Text);
            lunarYear--;
            tbxLunarYear.Text = lunarYear.ToString();
        }

        private void btnNextLunarYear_Click(object sender, EventArgs e)
        {
            int lunarYear = int.Parse(tbxLunarYear.Text);
            lunarYear++;
            tbxLunarYear.Text = lunarYear.ToString();
        }

        private void btnLastLunarMonth_Click(object sender, EventArgs e)
        {
            int lunarMonth = int.Parse(tbxLunarMonth.Text);
            int lunarYear = int.Parse(tbxLunarYear.Text);
            lunarMonth--;
            if (lunarMonth == 0)
            {
                lunarMonth = 12;
                lunarYear--;
            }
            tbxLunarYear.Text = lunarYear.ToString();
            tbxLunarMonth.Text = lunarMonth.ToString();
        }

        private void btnNextLunarMonth_Click(object sender, EventArgs e)
        {
            int lunarMonth = int.Parse(tbxLunarMonth.Text);
            int lunarYear = int.Parse(tbxLunarYear.Text);
            lunarMonth++;
            if (lunarMonth == 13)
            {
                lunarMonth = 1;
                lunarYear++;
            }
            tbxLunarYear.Text = lunarYear.ToString();
            tbxLunarMonth.Text = lunarMonth.ToString();
        }
    }
}
