using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class ChuyenDoi
    {
        public int Julius(int day, int month, int year)
        {
            int a = (int) Math.Floor((decimal) (14 - month) / 12);
            int y = year + 4800 - a;
            int m = month + 12 * a - 3;
            int jd = day + (int) Math.Floor((decimal) (153 * m + 2) / 5) + 365 * y + (int) Math.Floor((decimal) y / 4) - (int) Math.Floor((decimal) y / 100) + (int) Math.Floor((decimal) y / 400) - 32045;
            if (jd < 2299161)
            {
                jd = day + (int) Math.Floor((decimal) (153 * m + 2) / 5) + 365 * y + (int) Math.Floor((decimal) y / 4) - 32083;
            }
            return jd;
        }

        public string toDate(int jd)
        {
            int a, b, c, d, e, m, day, month, year;
            if (jd > 2299160)
            {
                a = jd + 32044;
                b = (int) Math.Floor((decimal) (4 * a + 3) / 146097);
                c = a - (int) Math.Floor((decimal)(b * 146097) / 4);
            }
            else
            {
                b = 0;
                c = jd + 32082;
            }
            d = (int) Math.Floor((decimal)(4 * c + 3) / 1461);
            e = c - (int) Math.Floor((decimal) (1461 * d) / 4);
            m = (int) Math.Floor((decimal)(5 * e + 2) / 153);
            day = e - (int) Math.Floor((decimal)(153 * m + 2) / 5) + 1;
            month = m + 3 - 12 * (int) Math.Floor((decimal)m / 10);
            year = b * 100 + d - 4800 + (int) Math.Floor((decimal) m / 10);
            return day.ToString() + "/" + month.ToString() + "/" + year.ToString();
        }

        public int getNewMoonDay(int k)
        {
            double T, T2, T3, dr, Jd1, M, Mpr, F, C1, deltat, JdNew;
            T = k / 1236.85;
            T2 = T * T;
            T3 = T2 * T;
            dr = Math.PI / 180;
            Jd1 = 2415020.75933 + 29.53058868 * k + 0.0001178 * T2 - 0.000000155 * T3;
            Jd1 = Jd1 + 0.00033 * Math.Sin((166.56 + 132.87 * T - 0.009173 * T2) * dr);
            M = 359.2242 + 29.10535608 * k - 0.0000333 * T2 - 0.00000347 * T3;
            Mpr = 306.0253 + 385.81691806 * k + 0.0107306 * T2 + 0.00001236 * T3;
            F = 21.2964 + 390.67050646 * k - 0.0016528 * T2 - 0.00000239 * T3;
            C1 = (0.1734 - 0.000393 * T) * Math.Sin(M * dr) + 0.0021 * Math.Sin(2 * dr * M);
            C1 = C1 - 0.4068 * Math.Sin(Mpr * dr) + 0.0161 * Math.Sin(dr * 2 * Mpr);
            C1 = C1 - 0.0004 * Math.Sin(dr * 3 * Mpr);
            C1 = C1 + 0.0104 * Math.Sin(dr * 2 * F) - 0.0051 * Math.Sin(dr * (M + Mpr));
            C1 = C1 - 0.0074 * Math.Sin(dr * (M - Mpr)) + 0.0004 * Math.Sin(dr * (2 * F + M));
            C1 = C1 - 0.0004 * Math.Sin(dr * (2 * F - M)) - 0.0006 * Math.Sin(dr * (2 * F + Mpr));
            C1 = C1 + 0.0010 * Math.Sin(dr * (2 * F - Mpr)) + 0.0005 * Math.Sin(dr * (2 * Mpr + M));
            if (T < -11)
            {
                deltat = 0.001 + 0.000839 * T + 0.0002261 * T2 - 0.00000845 * T3 - 0.000000081 * T * T3;
            }
            else
            {
                deltat = -0.000278 + 0.000265 * T + 0.000262 * T2;
            };
            JdNew = Jd1 + C1 - deltat;
            return (int)Math.Floor(JdNew + 0.5 + 7.0 / 24);
        }

        public int getSunLongitude(int jdn)
        {
            double T, T2, dr, M, L0, DL, L;
            T = (jdn - 2451545.5 - 7.0 / 24) / 36525;
            T2 = T * T;
            dr = Math.PI / 180;
            M = 357.52910 + 35999.05030 * T - 0.0001559 * T2 - 0.00000048 * T * T2;
            L0 = 280.46645 + 36000.76983 * T + 0.0003032 * T2;
            DL = (1.914600 - 0.004817 * T - 0.000014 * T2) * Math.Sin(dr * M);
            DL = DL + (0.019993 - 0.000101 * T) * Math.Sin(dr * 2 * M) + 0.000290 * Math.Sin(dr * 3 * M);
            L = L0 + DL;
            L = L * dr;
            L = L - Math.PI * 2 * (int) Math.Floor(L / (Math.PI * 2));
            return (int)Math.Floor(L / Math.PI * 6);
        }

        public int getLunarMonth11(int yy)
        {
            int k, off, nm, sunLong;
            off = Julius(31, 12, yy) - 2415021;
            k = (int) Math.Floor(off / 29.530588853);
            nm = getNewMoonDay(k);
            sunLong = getSunLongitude(nm);
            if (sunLong >= 9)
            {
                nm = getNewMoonDay(k - 1);
            }
            return nm;
        }

        public int getLeapMonthOffset(int a11)
        {
            int k, last, arc, i;
            k = (int) Math.Floor((a11 - 2415021.076998695) / 29.530588853 + 0.5);
            last = 0;
            i = 1;
            arc = getSunLongitude(getNewMoonDay(k + i));
            do
            {
                last = arc;
                i++;
                arc = getSunLongitude(getNewMoonDay(k + i));
            } while (arc != last && i < 14);
            return i - 1;
        }

        public string convertSolarToLunar(int dd, int mm, int yy)
        {
            int k, dayNumber, monthStart, a11, b11, lunarDay, lunarMonth, lunarYear, lunarLeap;
            dayNumber = Julius(dd, mm, yy);
            k = (int) Math.Floor((dayNumber - 2415021.076998695) / 29.530588853);
            monthStart = getNewMoonDay(k + 1);
            if (monthStart > dayNumber)
            {
                monthStart = getNewMoonDay(k);
            }
            a11 = getLunarMonth11(yy);
            b11 = a11;
            if (a11 >= monthStart)
            {
                lunarYear = yy;
                a11 = getLunarMonth11(yy - 1);
            }
            else
            {
                lunarYear = yy + 1;
                b11 = getLunarMonth11(yy + 1);
            }
            lunarDay = dayNumber - monthStart + 1;
            int diff = (int) Math.Floor((decimal) (monthStart - a11) / 29);
            lunarLeap = 0;
            lunarMonth = diff + 11;
            if (b11 - a11 > 365)
            {
                int leapMonthDiff = getLeapMonthOffset(a11);
                if (diff >= leapMonthDiff)
                {
                    lunarMonth = diff + 10;
                    if (diff == leapMonthDiff)
                    {
                        lunarLeap = 1;
                    }
                }
            }
            if (lunarMonth > 12)
            {
                lunarMonth = lunarMonth - 12;
            }
            if (lunarMonth >= 11 && diff < 4)
            {
                lunarYear -= 1;
            }
            return lunarDay.ToString() + "/" + lunarMonth.ToString() + "/" + lunarYear.ToString();
        }

        public string convertLunarToSolar(int day, int month, int year, int lunarLeap)
        {
            int k, a11, b11, off, leapOff, leapMonth, monthStart;
            if (month < 11)
            {
                a11 = getLunarMonth11(year - 1);
                b11 = getLunarMonth11(year);
            }
            else
            {
                a11 = getLunarMonth11(year);
                b11 = getLunarMonth11(year + 1);
            }
            off = month - 11;
            if (off < 0)
            {
                off += 12;
            }
            if (b11 - a11 > 365)
            {
                leapOff = getLeapMonthOffset(a11);
                leapMonth = leapOff - 2;
                if (leapMonth < 0)
                {
                    leapMonth += 12;
                }
                if (lunarLeap != 0 && month != leapMonth)
                {
                    return "0/0/0";
                }
                else if (lunarLeap != 0 || off >= leapOff)
                {
                    off += 1;
                }
            }
            k = (int) Math.Floor(0.5 + (a11 - 2415021.076998695) / 29.530588853);
            monthStart = getNewMoonDay(k + off);
            string solarDate = toDate(monthStart + day - 1);
            string tmp = "";
            int index = 0;
            for (int i = 0; i < solarDate.Length; i++)
            {
                if (solarDate[i] != '/')
                {
                    tmp += solarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            int dd = int.Parse(tmp);
            tmp = "";
            for (int i = index; i < solarDate.Length; i++)
            {
                if (solarDate[i] != '/')
                {
                    tmp += solarDate[i];
                }
                else
                {
                    index = i + 1;
                    break;
                }
            }
            int mm = int.Parse(tmp);
            tmp = "";
            for (int i = index; i < solarDate.Length; i++)
            {
                tmp += solarDate[i];
            }
            int yy = int.Parse(tmp);
            ChuyenDoi cd = new ChuyenDoi();
            string lunar = cd.convertSolarToLunar(dd, mm, yy);
            string lunar1 = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            if (lunar == lunar1) return solarDate;
            else return "0/0/0";
        }
    }
}