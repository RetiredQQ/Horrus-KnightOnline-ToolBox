using Dapper;
using DataAccessLayer.Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DataAccessLayer
{
    public abstract class DatabaseOperationBase
    {
        public static string connectionString { get; set; } = string.Empty;
        protected SqlConnection? _connection;

        protected SqlConnection connection
        {
            get
            {
                if (_connection == null || this._connection.State == ConnectionState.Closed)
                {
                    return this._connection = new SqlConnection(connectionString);
                }

                return _connection;
            }
        }

        protected abstract byte[] GetStrItemFromUserItemList(List<UserItem> items);

        protected abstract List<UserItem> GetUserItems_ByStoredProcedure(string userName);

        public void CreateConnectionString(string DataSource, string User, string Password, string InitialCatalog)
        {
            // ConnectionString Property explanation https://learn.microsoft.com/en-Us/dotnet/api/system.data.sqlclient.sqlconnection.connectionstring?view=dotnet-plat-ext-7.0&viewFallbackFrom=net-6.0
            connectionString = $"Data Source={DataSource};" +
                 $"User Id={User};" +
                 $"Password={Password};" +
                 $"Initial Catalog={InitialCatalog}";

            connection.ConnectionString = connectionString;
        }

        /// <summary>
        /// Test that the server is connected
        /// </summary>
        /// <returns>true if the connection is opened</returns>
        public (bool, SqlException?) IsServerConnected()   
        {
            using (connection)
            {
                try
                {
                    connection.Open();
                    return (true, null);
                }
                catch (SqlException e)
                {
                    return (false, e);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public int GetUserCoins(string userName)
        {
            IEnumerable<int> result = connection.Query<int>($"SELECT [Gold] FROM [dbo].[USERDATA] WHERE strUserId = '{userName}';");
            return result.FirstOrDefault();
        }


        public int InsertIntoItems(string query)
        {
            return connection.Execute(query);
        }

        public DataTable GetTableSchema(string connectionString, string tableName)
        {
            DataTable schemaTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT column_name, DATA_TYPE, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        schemaTable.Load(reader);
                    }
                }
            }
            return schemaTable;
        }

        public ItemDAO GetItemByNumId(int num)
        {
            return connection.Query<ItemDAO>($"SELECT * FROM [dbo].[ITEM] WHERE [NUM] = {num};").ToList().First();
        }

        public List<ItemDAO> SearchItemsTableWithConstrains(string serachPramsQuery)
        {
            List<ItemDAO> result = connection.Query<ItemDAO>($"SELECT * FROM [dbo].[ITEM] {serachPramsQuery};").ToList();
            return result;
        }

        public void SaveChanges(string strUserId, List<UserItem> items, int coinsAmount)
        {
            var updatedBinaryData = GetStrItemFromUserItemList(items);
            //connection.Query("dbo.sp_EncodeStrItem", new { @strUserId = strUserId, @binaryData = updatedBinaryData }, commandType: CommandType.StoredProcedure);
            //connection.Query($"UPDATE [dbo].[USERDATA] SET [Gold] = {coinsAmount} WHERE strUserId = '{strUserId}'");

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();

            // ExecuteSqlTransaction
            try
            {
                command.Transaction = transaction;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.sp_EncodeStrItem";

                // Add parameters
                command.Parameters.AddWithValue("@strUserId", strUserId);
                command.Parameters.AddWithValue("@binaryData", updatedBinaryData);
                command.ExecuteNonQuery();

                // Update Coins
                command.CommandType = CommandType.Text;
                command.CommandText = $"UPDATE [dbo].[USERDATA] SET [Gold] = {coinsAmount} WHERE strUserId = '{strUserId}';";
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Debug.WriteLine("  Message: {0}", ex.Message);

                try
                {
                    // Attempt to Rollback transaction if an exception occurs
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Debug.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Debug.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public List<UserItem> GetUserInventory(string userName)
        {
            return GetUserItems_ByStoredProcedure(userName);
        }

        /// <summary>
        /// Gets all character names with matching level and clan name 
        /// </summary>
        public List<CharacterInfo> GetAllCharacterInfo()
        {
            List<CharacterInfo> result = connection.Query<CharacterInfo>($" SELECT u.[strUserId], u.[level], k.IDName from [dbo].[USERDATA] u Left JOIN KNIGHTS k on u.Knights = k.IDNum order by u.[strUserId];").ToList();
            return result;
        }

        public int VerifyIfRequiredProceduresExists(string objectName , string type = "P")
        { 
            return connection.Query<int>($"SELECT COUNT(*) FROM sys.objects WHERE type = '{type}' AND OBJECT_ID = OBJECT_ID('{objectName}');").First();
        }
    }
}