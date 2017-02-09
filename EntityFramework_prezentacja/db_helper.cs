using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_prezentacja
{
    class db_helper
    {
        public static string change_db(string data_source= "localhost:1521/testowa",string user="system",string password="admin1")
        {
            const string providerName = "Oracle.ManagedDataAccess.Client";
            string metaData = "res://*/model_Samochod.csdl|res://*/model_Samochod.ssdl|res://*/model_Samochod.msl";

            Oracle.ManagedDataAccess.Client.OracleConnectionStringBuilder oracleBuilder = new Oracle.ManagedDataAccess.Client.OracleConnectionStringBuilder();
            oracleBuilder.DataSource = data_source;
            oracleBuilder.UserID = user;
            oracleBuilder.Password = password;

            System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder efBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder();
            efBuilder.Metadata = metaData;
            efBuilder.Provider = providerName;
            efBuilder.ProviderConnectionString = oracleBuilder.ConnectionString;

            return efBuilder.ConnectionString;
        }
    }
}
