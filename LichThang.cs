using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class LichThang : UserControl
    {
        private static LichThang _instance;
        public static LichThang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LichThang();
                return _instance;
            }
        }
        public LichThang()
        {
            InitializeComponent();
        }

        private void LichThang_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            tbxYear.Text = date.Year.ToString();
            tbxMonth.Text = date.Month.ToString();
        }
        private void loadLich(string y, string m)
        {
            int syear = int.Parse(y);
            int smonth = int.Parse(m);
            var firstDay = new DateTime(syear, smonth, 1).DayOfWeek;
            string[,] month = new string[6, 7];
            int dayOfMonth = 0;
            if (new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(smonth)) dayOfMonth = 31;
            if (new int[] { 4, 6, 9, 11 }.Contains(smonth)) dayOfMonth = 30;
            if (smonth == 2)
            {
                if (syear % 4 == 0) dayOfMonth = 29;
                else dayOfMonth = 28;
            }
            int k = 7;
            switch (firstDay)
            {
                case DayOfWeek.Monday:
                    k = 0; break;
                case DayOfWeek.Tuesday:
                    k = 1; break;
                case DayOfWeek.Wednesday:
                    k = 2; break;
                case DayOfWeek.Thursday:
                    k = 3; break;
                case DayOfWeek.Friday:
                    k = 4; break;
                case DayOfWeek.Saturday:
                    k = 5; break;
                case DayOfWeek.Sunday:
                    k = 6; break;
            }
            int day = 1;
            for (int i = 0; i < 7; i++)
            {
                if (i < k) month[0, i] = "";
                else
                {
                    month[0, i] = day.ToString();
                    day++;
                }
            }
            int numberOfWeek = 0;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    month[i, j] = day.ToString();
                    day++;
                    if (day > dayOfMonth)
                    {
                        numberOfWeek = i;
                        break;
                    }
                }
            }
            ChuyenDoi change = new ChuyenDoi();
            int count = 0;
            for (int i = 0; i <= numberOfWeek; i++)
            {
                string[] week = new string[7];
                for (int j = 0; j < 7; j++)
                {
                    if (month[i, j] == "") week[j] = "";
                    else
                    {
                        count++;
                        if (count > dayOfMonth) break;
                        day = int.Parse(month[i, j]);
                        string date = change.convertSolarToLunar(day, smonth, syear);
                        if (i == 0 && j == k)
                        {
                            week[j] = month[i, j] + " <";
                            for (int l = 0; l < date.Length - 5; l++)
                            {
                                week[j] += date[l];
                            }
                            week[j] += ">";
                            continue;
                        }
                        if (date[0] == '1' && date[1] == '/')
                        {
                            week[j] = month[i, j] + " <";
                            for (int l = 0; l < date.Length - 5; l++)
                            {
                                week[j] += date[l];
                            }
                            week[j] += ">";
                        }
                        else
                        {
                            week[j] = month[i, j] + " <";
                            for (int l = 0; l < date.Length; l++)
                            {
                                if (date[l] == '/') break;
                                week[j] += date[l];
                            }
                            week[j] += ">";
                        }
                    }   
                }
                ListViewItem item = new ListViewItem(week);
                lsvMonth.Items.Add(item);
            }
        }

        private void tbxMonth_TextChanged(object sender, EventArgs e)
        {
            if (tbxMonth.Text == "" || tbxYear.Text == "") return;
            else
            {
                lsvMonth.Items.Clear();
                loadLich(tbxYear.Text, tbxMonth.Text);
            }
        }

        private void tbxYear_TextChanged(object sender, EventArgs e)
        {
            if (tbxMonth.Text == "" || tbxYear.Text == "") return;
            else
            {
                lsvMonth.Items.Clear();
                loadLich(tbxYear.Text, tbxMonth.Text);
            }
        }

        private void btnLastYear_Click(object sender, EventArgs e)
        {
            int year = int.Parse(tbxYear.Text);
            tbxYear.Text = (year-1).ToString();
        }

        private void btnNextYear_Click(object sender, EventArgs e)
        {
            int year = int.Parse(tbxYear.Text);
            tbxYear.Text = (year + 1).ToString();
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            int month = int.Parse(tbxMonth.Text);
            int year = int.Parse(tbxYear.Text);
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else month--;
            tbxYear.Text = year.ToString();
            tbxMonth.Text = month.ToString();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            int month = int.Parse(tbxMonth.Text);
            int year = int.Parse(tbxYear.Text);
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else month++;
            tbxYear.Text = year.ToString();
            tbxMonth.Text = month.ToString();
        }
    }
}
