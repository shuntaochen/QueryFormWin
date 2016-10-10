using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ServerListQueryFormDll
{
    public interface IQueryView
    {
        DataTable UnFilteredShowDataSrc { get; set; }
        DataTable ShowDataSrc { get; set; }
        string DbHost { get; set; }
        string DbName { get; set; }
        string TbName { get; set; }
        string Filter { get; set; }
        string Output { get; set; }
        string ConnectionString { get; set; }
        string SqlText { get; set; }
        IDictionary<string, bool> DicExportCols { get; set; }
    }
}
