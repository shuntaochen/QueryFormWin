// <copyright company="Microsoft Corporation"> 
// Copyright © Microsoft Corporation. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace ServerListQueryFormDll
{

    public partial class SrvListQueryFrm : FormBase, IQueryView
    {
        private QueryPresenter _presenter;

        public SrvListQueryFrm()
        {
            InitializeComponent();
            _presenter = new QueryPresenter(this);
            this.txtDbHost.KeyUp += initView;
            this.txtDbName.KeyUp += initView;
            this.txtTbName.KeyUp += initView;
            this.txtFilter.KeyUp += initView;

            this.txtDbHost.MouseUp += initView;
            this.txtDbName.MouseUp += initView;
            this.txtTbName.MouseUp += initView;
            this.txtFilter.MouseUp += initView;
            dgvQueryResult.CellPainting += base.dgv_CellPainting;
        }


        void initView(object sender, EventArgs e)
        {
            _presenter.InitView(this);
        }

        /// <summary>
        /// ctor with 3 parameters
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="defSql"></param>
        /// <param name="outputPath"></param>
        public SrvListQueryFrm(String conStr, String defSql, String outputPath)
            : this()
        {
            this.ConnectionString = conStr;
            this.SqlText = defSql;
            this.Output = outputPath;
        }

        public SrvListQueryFrm(string dbHost, string dbName, string tbName, string outputPath)
            : this(new WindowsAuthConStrBuilder(dbHost, dbName).Build().GetConStr(),
                SqlTextHelper.GetTblSqlByName(tbName), outputPath)
        {
            this.DbHost = dbHost;
            this.DbName = dbName;
            this.TbName = tbName;
        }


        /// <summary>
        /// export selected col
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DicExportCols == null || this.DicExportCols.Count(pair => pair.Value == true) == 0)
                {
                    MessageBox.Show("Please specify at least one column to export! ");
                    return;
                }
                _presenter.ExportChosenCols(this);
                MessageBox.Show("Export success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class Query
        {
            public String ConStr { get; set; }
            public string Sql { get; set; }
        }
        /// <summary>
        /// query data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem((c) =>
            {
                try
                {
                    var q = c as Query;
                    DataTable dt = SqlHelper.Query(q.ConStr, q.Sql);
                    dgvQueryResult.Invoke(new Action(() =>
                    {
                        UnFilteredShowDataSrc = dt;
                        ShowDataSrc = dt;
                        base.RenderDgvSet(dgvQueryResult);
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }, new Query { ConStr = this.ConnectionString, Sql = this.SqlText });
        }

        public string DbHost
        {
            get
            {
                return txtDbHost.Text;
            }
            set
            {
                txtDbHost.Text = value;
            }
        }

        public string DbName
        {
            get
            {
                return txtDbName.Text;
            }
            set
            {
                txtDbName.Text = value;
            }
        }

        public string TbName
        {
            get
            {
                return txtTbName.Text;
            }
            set
            {
                txtTbName.Text = value;
            }
        }

        public string Filter
        {
            get
            {
                return txtFilter.Text;
            }
            set
            {
                txtFilter.Text = value;
            }
        }

        public IDictionary<string, bool> DicExportCols
        {
            get
            {
                return base.dgvHeaderDict;
            }
            set
            {
                dgvHeaderDict = value;
            }
        }


        public string Output { get { return txtOutput.Text; } set { txtOutput.Text = value; } }

        public string ConnectionString
        {
            get
            {
                return txtConStr.Text;
            }
            set
            {
                this.txtConStr.Text = value;
            }
        }

        public string SqlText
        {
            get
            {
                return rchtxtSql.Text;
            }
            set
            {
                rchtxtSql.Text = value;
            }
        }

        public DataTable ShowDataSrc
        {
            get
            {
                return this.dgvQueryResult.DataSource as DataTable;
            }
            set
            {
                dgvQueryResult.DataSource = value;
            }
        }

        public DataTable UnFilteredShowDataSrc { get; set; }
    }
}

