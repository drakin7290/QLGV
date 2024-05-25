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

namespace GUI
{
    public partial class UserControlDays : UserControl
    {
        GiaoVien_DTO gv;
        DateTime ngayday;
        Action callback;
        public UserControlDays(GiaoVien_DTO _gv, DateTime _ngayday, Action _callback)
        {
            InitializeComponent();
            this.gv = _gv;
            this.ngayday = _ngayday;
            this.callback = _callback;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days (int numday, int sotiet)
        {
            lbDays.Text = numday.ToString();
            lbPeriod.Text = sotiet.ToString();
            if (sotiet > 0)
            {
                lbPeriod.Visible = true;
            }
            Color color = Color.White;
            if (sotiet > 0 && sotiet < 4)
            {
                color = Color.Coral;
            }
            else if (sotiet >=4 && sotiet < 8)
            {
                color = Color.OrangeRed;
            }
            else if (sotiet >= 8)
            {
                color = Color.Red;
            }
            btnControl.BackColor = color;
            lbPeriod.BackColor = color;
            lbDays.BackColor = color;
        }

        public void ShowInfoDayDetail()
        {

        }

        private void lbPeriod_Click(object sender, EventArgs e)
        {
            btnControl_Click(sender, e);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            ChiTietThoiKhoaBieu cttkb = new ChiTietThoiKhoaBieu(this.gv, this.ngayday);
            cttkb.ShowDialog();
            this.callback();
        }

        private void lbDays_Click(object sender, EventArgs e)
        {
            btnControl_Click(sender, e);
        }
    }
}
