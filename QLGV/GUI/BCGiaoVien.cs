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
            // TODO: This line of code loads data into the 'QLGVDataSet.BAOCAO_GIAOVIEN' table. You can move, or remove it, as needed.
            this.BAOCAO_GIAOVIENTableAdapter.Fill(this.QLGVDataSet.BAOCAO_GIAOVIEN);
            // TODO: This line of code loads data into the 'QLGVDataSet.GIAOVIEN' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
