namespace GUI
{
    partial class BCGiaoVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BAOCAO_GIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLGVDataSet = new GUI.QLGVDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GIAOVIENTableAdapter = new GUI.QLGVDataSetTableAdapters.GIAOVIENTableAdapter();
            this.BAOCAO_GIAOVIENTableAdapter = new GUI.QLGVDataSetTableAdapters.BAOCAO_GIAOVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAO_GIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLGVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIAOVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BAOCAO_GIAOVIENBindingSource
            // 
            this.BAOCAO_GIAOVIENBindingSource.DataMember = "BAOCAO_GIAOVIEN";
            this.BAOCAO_GIAOVIENBindingSource.DataSource = this.QLGVDataSet;
            // 
            // QLGVDataSet
            // 
            this.QLGVDataSet.DataSetName = "QLGVDataSet";
            this.QLGVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BAOCAO_GIAOVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1108, 455);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // GIAOVIENBindingSource
            // 
            this.GIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.GIAOVIENBindingSource.DataSource = this.QLGVDataSet;
            // 
            // GIAOVIENTableAdapter
            // 
            this.GIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // BAOCAO_GIAOVIENTableAdapter
            // 
            this.BAOCAO_GIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // BCGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 479);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BCGiaoVien";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.BCGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAO_GIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLGVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIAOVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GIAOVIENBindingSource;
        private QLGVDataSet QLGVDataSet;
        private QLGVDataSetTableAdapters.GIAOVIENTableAdapter GIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource BAOCAO_GIAOVIENBindingSource;
        private QLGVDataSetTableAdapters.BAOCAO_GIAOVIENTableAdapter BAOCAO_GIAOVIENTableAdapter;
    }
}