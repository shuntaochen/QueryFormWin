using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ServerListQueryFormDll
{
    public class FileHeper
    {
        public static void ExportFile(string absolutePath, string content)
        {
            if (string.IsNullOrEmpty(absolutePath)) throw new Exception("Absolute path must be specified!");
            InitSavePathDirectory(absolutePath);
            using (StreamWriter sw = new StreamWriter(absolutePath))
            {
                sw.Write(content);
            }
        }

        private static void InitSavePathDirectory(string absolutePath)
        {
            var index = absolutePath.LastIndexOf("\\");
            var dir = absolutePath.Substring(0, index);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
