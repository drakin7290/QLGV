using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Globalization;

namespace GUI
{
    public partial class FormThoiKhoaBieu : Form
    {
        int month, year;
        GiaoVien_DTO gv;
        public FormThoiKhoaBieu(GiaoVien_DTO _gv)
        {
            InitializeComponent();
            this.gv = _gv;
        }

        private void FormThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            displayDays();
            lbNameTeacher.Text = gv.name;
        }

        private void displayDays()
        {
            dayContainer.Controls.Clear();
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;

            DateTime startOfTheMonth = new DateTime(this.year, this.month, 1);

            int days = DateTime.DaysInMonth(this.year, this.month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i=1; i<dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            List<LichDayTheoThang_DTO> lichdaytheothang = ThoiKhoaBieu_BUS.LayLichDayTheoThang(gv.id, this.month);
            for (int i=1; i<=days; i++)
            {
                DateTime ngayday = DateTime.Parse(String.Format(@"{0}/{1}/{2}", this.month, i, this.year));
                UserControlDays ucdays = new UserControlDays(this.gv, ngayday);
                
                int sotiet = 0;
                if (lichdaytheothang != null && lichdaytheothang.Count() > 0)
                {
                    List<LichDayTheoThang_DTO> filterDay = lichdaytheothang.Where(a => DateTime.Compare(a.ngayday, ngayday) == 0).ToList();
                    if (filterDay != null && filterDay.Count() > 0)
                    {
                        sotiet = filterDay[0].sotiet;
                    }
                }
                ucdays.days(i, sotiet);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.month > 1)
            {
                month--;
            } else
            {
                this.month = 12;
                year--;
            }
            displayDays();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (month < 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }
            displayDays();
        }
    }
}
