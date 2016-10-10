using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace ServerListQueryFormDll
{
    /// <summary>
    /// Responsibility: init view,fill view data, export view chosen cols
    /// </summary>
    public class QueryPresenter
    {
        public QueryPresenter(IQueryView view)
        {
            InitView(view);
        }

        public DataTable Query(string constr, string sql)
        {
            return SqlHelper.Query(constr, sql);
        }

        public void FillViewData(IQueryView view)
        {
            DataTable dt = SqlHelper.Query(view.ConnectionString, view.SqlText);
            view.UnFilteredShowDataSrc = dt;
            view.ShowDataSrc = dt;
        }

        public void ExportChosenCols(IQueryView view)
        {
            var dt = view.ShowDataSrc;
            string content = "";
            foreach (DataRow row in dt.Rows)
            {
                string rowContent = "";
                view.DicExportCols.ToList().ForEach(pair =>
                {
                    rowContent += pair.Value ? (row[pair.Key].ToString().ToUpper() + ":") : "";
                });
                content += rowContent.Trim().TrimEnd(':') + "\r\n";
            }
            FileHeper.ExportFile(view.Output, content);
        }


        internal void InitView(IQueryView view)
        {
            view.ConnectionString = new WindowsAuthConStrBuilder(view.DbHost, view.DbName).Build().GetConStr();
            view.SqlText = SqlTextHelper.GetTblSqlByName(view.TbName);
            if (!string.IsNullOrEmpty(view.Filter) && view.UnFilteredShowDataSrc != null)
                view.ShowDataSrc = DataTableHelper.GetFilteredDatatable(view.UnFilteredShowDataSrc, view.Filter);
            else
                view.ShowDataSrc = view.UnFilteredShowDataSrc;
        }

    }
}
