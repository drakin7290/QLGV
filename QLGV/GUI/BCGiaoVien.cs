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
    public partial class BCGiaoVien : Form
    {
        public BCGiaoVien()
        {
            InitializeComponent();
        }

        private void BCGiaoVien_Load(object sender, EventArgs e)
        {
            BaoCao_DTO report = new BaoCao_DTO();
            this.reportViewer1.RefreshReport();
        }
    }
}
