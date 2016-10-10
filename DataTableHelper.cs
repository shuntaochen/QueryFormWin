using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ServerListQueryFormDll
{
    public partial class DataTableHelper
    {
        private static IList<string> _colNameCollection = new List<string>();
        private static IDictionary<string, bool> _colCheckStatusIndicator = new Dictionary<string, bool>();
        /// <summary>
        /// public member,filter datatable with whole index
        /// </summary>
        /// <param name="source"></param>
        /// <param name="filterText"></param>
        /// <returns></returns>
        public static DataTable GetFilteredDatatable(DataTable source, String filterText)
        {
            if (source == null) return null;
            DataTable dt = CopyDtDef(source.Columns);
            ImportDtFilteredData(source, dt, filterText);
            return dt;
        }
        /// <summary>
        /// Get a dictionary with all the dt cols included,and set the value to be false;
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static IDictionary<string, bool> GetDataTableColumnNameFalseDict(DataTable dt)
        {
            if (dt == null) return null;
            IDictionary<string, bool> dic = new Dictionary<string, bool>();
            foreach (DataColumn col in dt.Columns)
            {
                dic[col.ColumnName] = false;
            }
            return dic;
        }
        private static void ImportDtFilteredData(DataTable source, DataTable dt, string filterText)
        {
            string filter = string.Empty;
            if (_colNameCollection.Count == 0) return;
            _colNameCollection.ToList().ForEach(colName =>
            {
                filter += BuildStringTypeColFilter(source, colName, filterText);
            });
            filter = filter.EndsWith("or") ? filter.Substring(0, filter.Length - 2).Trim() : filter;
            source.Select(filter).ToList().ForEach(row =>
            {
                dt.ImportRow(row);
            });
        }

        private static string BuildStringTypeColFilter(DataTable source, string colName, string filterText)
        {
            if (source.Columns[colName].DataType == typeof(string))
            {
                return string.Format("{0} like '%{1}%' or", colName, filterText);
            }
            return string.Empty;
        }

        private static DataTable CopyDtDef(DataColumnCollection dataColumnCollection)
        {
            DataTable retDt = new DataTable();
            InitColNameCollection(dataColumnCollection, retDt);
            return retDt;
        }

        private static void InitColNameCollection(DataColumnCollection dataColumnCollection, DataTable retDt)
        {
            _colNameCollection.Clear();
            foreach (DataColumn column in dataColumnCollection)
            {
                retDt.Columns.Add(new DataColumn(column.ColumnName));
                _colNameCollection.Add(column.ColumnName);
            }
        }
    }
}
