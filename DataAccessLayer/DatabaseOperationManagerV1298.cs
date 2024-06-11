using Dapper;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer
{
    public class DatabaseOperationManagerV1298 : DatabaseOperationBase, IDatabaseOperationManager
    {
        /// <summary>
        /// Cause issue with null value converstion to byte[] 
        /// </summary>
        /// <returns></returns>
        protected override List<UserItem> GetUserItems_ByStoredProcedure(string userName)
        {
            int i = 0;

            List<UserItem> items =  connection.Query<UserItem>("dbo.sp_DecodeStrItem", new { @strUserId = userName, @displayAll = 1 }, commandType: CommandType.StoredProcedure).ToList();

            foreach (var item in items)
            {
                item.Slot = i++;
                if (item?.ItemCount != 0)
                {
                    item.Countable = GetItemByNumId(item.Num).Countable;
                }
            }

            return items;
        }

        private List<UserItem> GetUserItems_BySqlStatement(string userName)
        {
            var items = new List<UserItem>() { new UserItem { ItemCount=0, Num=0, Slot=0, CurrentDuarbility=0 } };
            var strItemAsVarBinary = connection.QuerySingle<byte[]>($"select cast((select strItem from USERDATA where strUserId = '{userName}') as varbinary(400));");

            for (int i = 1; i < 50; i++)
            {
                var qNum = BitConverter.ToInt32(strItemAsVarBinary[(i * 8 - 8)..(i * 8 - 7 + 4)]);
                var item = new UserItem
                {
                    Slot = i,
                    Num = qNum,
                    CurrentDuarbility = BitConverter.ToInt16(strItemAsVarBinary[(i * 8 - 4)..(i * 8 - 2)]),
                    ItemCount = BitConverter.ToInt16(strItemAsVarBinary[(i * 8 - 2)..(i * 8)]),
                    StrName = connection.QueryFirstOrDefault<string>($"select strName from ITEM where Num={qNum};"),
                    MaxDuarbility = connection.QueryFirstOrDefault<short>($"select Duration from ITEM where Num={qNum};"),
                };
                items.Add(item);
            }

            return items;
        }

        #region Private Methods

        /// <summary>
        /// Method convert List of user inventory items to byte array
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        protected override byte[] GetStrItemFromUserItemList(List<UserItem> items)
        {
            var updatedArray = new byte[400];

            foreach (UserItem item in items)
            {
                byte[] temporary = BitConverter.GetBytes(item.Num);
                updatedArray[8 * (item.Slot)] = temporary[0];
                updatedArray[8 * (item.Slot) + 1] = temporary[1];
                updatedArray[8 * (item.Slot) + 2] = temporary[2];
                updatedArray[8 * (item.Slot) + 3] = temporary[3];
                temporary = BitConverter.GetBytes(item.MaxDuarbility);
                updatedArray[8 * (item.Slot) + 4] = temporary[0];
                updatedArray[8 * (item.Slot) + 5] = temporary[1];
                temporary = BitConverter.GetBytes(item.ItemCount);
                updatedArray[8 * (item.Slot) + 6] = temporary[0];
                updatedArray[8 * (item.Slot) + 7] = temporary[1];
            }

            return updatedArray;
        }

        #endregion
    }
}

// TEST retrive ITEM BY STOREDPROC VS SQL STATEMENT
//public void CallFlow()
//{

//    var items2 = GetUserItems_ByStoredProcedure();
//    var updatedBinaryData2 = GetStrItemFromUserItemList(items2);
//    SaveChanges("PlayerName", updatedBinaryData2);

//    var items = GetUserItems_BySqlStatement();
//    var updatedBinaryData = GetStrItemFromUserItemList(items);
//    SaveChanges("PlayerName", updatedBinaryData);
//}


//Console.WriteLine(updatedArray.SequenceEqual(bytyyy));

//Notes: 
//Dapper 2 way of calling procedure 
// https://www.learndapper.com/stored-procedures

//1) 
//var userInventory = conn.Query<List<UserItem>>("dbo.sp_DecodeStrItem", new { @strUserId = "PlayerName", @displayAll = 1 }, commandType: CommandType.StoredProcedure).ToList();

//foreach (var item in userInventory)
//{
//    Console.WriteLine(item.ToString());
//}

//2) 

//var procedure = "sp_DecodeStrItem";
//var values = new { @strUserId = "PlayerName", @displayAll = 1 };
//var results = conn.Query(procedure, values, commandType: CommandType.StoredProcedure).ToList();