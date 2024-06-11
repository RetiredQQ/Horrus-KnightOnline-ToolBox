using DataAccessLayer.Models;
using System.Data;
using System.Data.SqlClient;
using static DataAccessLayer.DatabaseOperationBase;

namespace DataAccessLayer.Interfaces
{
    public interface IDatabaseOperationManager
    {
        public void SaveChanges(string strUserId, List<UserItem> items, int coinsAmount);
        public List<ItemDAO> SearchItemsTableWithConstrains(string serachPramsQuery);
        public List<UserItem> GetUserInventory(string userName);
        public void CreateConnectionString(string DataSource, string User, string Password, string InitialCatalog);
        public (bool, SqlException?) IsServerConnected();
        public int GetUserCoins(string userName);
        public ItemDAO GetItemByNumId(int num);
        public List<CharacterInfo> GetAllCharacterInfo();
        public int VerifyIfRequiredProceduresExists(string objectName, string type = "P");

        /// <summary>
        /// method of - Item Creator Project
        /// </summary>
        /// <param name="query">query statemenet</param>
        /// <returns>Db Error code</returns>
        public int InsertIntoItems(string query);

        /// <summary>
        /// Get Table Schema from DB - Item Creator Method
        /// </summary>
        /// <param name="connectionString">The connectionString</param>
        /// <param name="tableName">Database tableName</param>
        /// <returns>DataTable</returns>
        public DataTable GetTableSchema(string connectionString, string tableName);

    }
}