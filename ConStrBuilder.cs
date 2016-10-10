using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerListQueryFormDll
{
    public interface IConStrBuilder
    {
        IConStrBuilder Build();
        String GetConStr();
    }

    public class SqlAuthConStrBuilder : IConStrBuilder
    {

        string _dbHost;
        string _dbName;
        string _uid;
        string _pwd;
        string _connectionString;
        public SqlAuthConStrBuilder(String dbHost, String dbName, String uid, String pwd)
        {
            _dbHost = dbHost;
            _dbName = dbName;
            _uid = uid;
            _pwd = pwd;
        }


        public IConStrBuilder Build()
        {
            _connectionString = String.Format("Data Source={0};Database={1};User Id={2};Password={3}", _dbHost, _dbName, _uid, _pwd);
            return this;
        }

        public string GetConStr()
        {
            return _connectionString;
        }
    }

    public class WindowsAuthConStrBuilder : IConStrBuilder
    {
        string _dbHost;
        string _dbName;
        string _connectionString;
        public WindowsAuthConStrBuilder(String dbHost, String dbName)
        {
            _dbHost = dbHost;
            _dbName = dbName;
        }
        public IConStrBuilder Build()
        {
            _connectionString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;", _dbHost, _dbName);
            return this;
        }

        public String GetConStr()
        {
            return _connectionString;
        }

    }
}
