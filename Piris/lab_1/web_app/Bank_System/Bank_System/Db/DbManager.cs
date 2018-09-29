using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Bank_System.Db
{
    public class DbManager
    {
        private static DbManager _instanse;
        public OdbcConnection OdbcConnection { get; set; }
        public bool Status { get; set; }

        private DbManager()
        {
            OdbcConnection = new OdbcConnection("Driver={Devart ODBC Driver for MySQL};server=localhost;user id=root;persistsecurityinfo=False;database=lab_1;pwd=123addon123;");            
        }

        public static DbManager GetInstanse()
        {
            return _instanse ?? (_instanse = new DbManager());
        }        

        public void ConnectToDb()
        {
            try
            {
                OdbcConnection.Open();
            }
            catch (OdbcException e)
            {
                Status = false;
            }

            Status = true;
        }

        public List<object[]> SendQuery(string query)
        {
            if (OdbcConnection.State == ConnectionState.Open)
            {
                var command = new OdbcCommand(query, OdbcConnection);
                var reader = command.ExecuteReader();
                var result = new List<object[]>();
                while (reader.Read())
                {
                    var row = new object[reader.FieldCount];
                    reader.GetValues(row);                    
                    result.Add(row);
                }
                
                return result;
            }

            return null;
        }

        public object[] GetLastRowAdded(string tableName)
        {
            if (OdbcConnection.State == ConnectionState.Open)
            {
                var lastId = SendQuery($"select Max(Id) from {tableName}")[0][0].ToString();                
                return SendQuery($"select * from {tableName} where Id='{lastId}'")[0];
            }

            return null;
        }
    }
}