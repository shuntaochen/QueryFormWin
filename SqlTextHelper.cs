using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerListQueryFormDll
{
    public class SqlTextHelper
    {
        public static string GetTblSqlByName(string tbName) {
            return string.Format("select * from {0}",tbName);
        }
    }
}
