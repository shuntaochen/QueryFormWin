using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServerListQueryFormDll
{
    public class FormBase : Form
    {
        protected IDictionary<string, bool> dgvHeaderDict;

        public FormBase()
        {

        }
        /// <summary>
        /// Extract to UserControl;InitDgv
        /// </summary>
        /// <param name="dgv"></param>
        protected void RenderDgvSet(DataGridView dgv)
        {
            RemoveThisColCkbs();
            InitDgvHeaderDict(dgv);
            InitFstLoad();
        }

        private void RemoveThisColCkbs()
        {
            if (dgvHeaderDict == null) return;
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(CheckBox) && dgvHeaderDict.ContainsKey(ctl.Text))
                    this.Controls.Remove(ctl);
            }
        }

        protected void InitFstLoad()
        {
            if (dgvHeaderDict != null)
            {
                var key = dgvHeaderDict.Keys.First();
                dgvHeaderDict[key] = true;
            }
        }
        private void InitDgvHeaderDict(DataGridView dgv)
        {
            DataTable dt = dgv.DataSource as DataTable;
            dgvHeaderDict = DataTableHelper.GetDataTableColumnNameFalseDict(dt);
        }
        /// <summary>
        /// cell painting event, create checkbox control in col header for selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgvQueryResult = sender as DataGridView;
            DataTable dt = dgvQueryResult.DataSource as DataTable;
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                CheckBox ck = new CheckBox();
                ck.Text = dt.Columns[e.ColumnIndex].ColumnName;
                ck.Checked = GetCkCheckStatus(ck);
                //solve resizing col
                foreach (Control ctl in this.Controls)
                {
                    if (ctl.Text == ck.Text && dgvHeaderDict.ContainsKey(ck.Text))
                        this.Controls.Remove(ctl);
                }
                this.Controls.Add(ck);
                ck.CheckedChanged += Ck_CheckedChanged;
                Point p = dgvQueryResult.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                p.Offset(dgvQueryResult.Left, dgvQueryResult.Top + 1);
                ck.Location = p;
                var s = dgvQueryResult.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Size;
                ck.Size = new Size(s.Width - 20, s.Height - 2);
                ck.Visible = true;
                ck.BringToFront();
            }
        }

        private bool GetCkCheckStatus(CheckBox ck)
        {
            if (dgvHeaderDict != null)
                return dgvHeaderDict[ck.Text];
            return false;
        }

        protected void Ck_CheckedChanged(object sender, EventArgs e)
        {
            var ckBox = sender as CheckBox;
            var colName = ckBox.Text;
            if (dgvHeaderDict != null && dgvHeaderDict.ContainsKey(colName)) dgvHeaderDict[colName] = (dgvHeaderDict[colName] == true ? false : true);
        }
    }
}
