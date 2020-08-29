using DataManager.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataManager
{
    public partial class DataManagerGateway<T> where T : new()
    {
        public IDbConnection GetConnection(DataBaseType dataBase)
        {
            switch (dataBase)
            {
                case DataBaseType.MSSQL:
                    //TODO Return MSSQL Connection Instance
                    
                    break;
                case DataBaseType.MYSQL:
                    //TODO Return MYSQL Connection Instance
                    break;
                case DataBaseType.POSTRESQL:
                    //TODO Return POSTRESQ Connection Instance
                    
                    break;
                default:
                    throw new Exception(Variables.Invalid_Database_Connection);

            }
            return null;
        }
    }
}
