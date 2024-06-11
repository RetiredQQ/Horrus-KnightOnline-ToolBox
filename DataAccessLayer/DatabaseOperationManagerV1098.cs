using Dapper;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer
{
    public class DatabaseOperationManagerV1098 : DatabaseOperationBase, IDatabaseOperationManager
    {
        /// <summary>
        /// Cause issue with null value converstion to byte[] 
        /// </summary>
        /// <returns></returns>
        protected override List<UserItem> GetUserItems_ByStoredProcedure(string userName)
        {
            int itemSlotIndex = 1;

            List<UserItem> items = connection.Query<UserItem>("dbo.sp_DecodeStrItem", new { @strUserId = userName, @displayAll = 1 }, commandType: CommandType.StoredProcedure).ToList();

            foreach (var item in items)
            {
                item.Slot = itemSlotIndex++;
                if (item?.ItemCount != 0)
                {
                    item.Countable = GetItemByNumId(item.Num).Countable;
                }
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
            var updatedArray = new byte[600];
            //var strItemTime  = new byte[300];
            //int i = 0;

            foreach (UserItem item in items)
            {
                byte[] temporary = BitConverter.GetBytes(item.Num);
                updatedArray[8 * (item.Slot-1)]     = temporary[0];
                updatedArray[8 * (item.Slot-1) + 1] = temporary[1];
                updatedArray[8 * (item.Slot-1) + 2] = temporary[2];
                updatedArray[8 * (item.Slot-1) + 3] = temporary[3];
                temporary = BitConverter.GetBytes(item.MaxDuarbility);
                updatedArray[8 * (item.Slot - 1) + 4] = temporary[0];
                updatedArray[8 * (item.Slot - 1) + 5] = temporary[1];
                temporary = BitConverter.GetBytes(item.ItemCount);
                updatedArray[8 * (item.Slot - 1) + 6] = temporary[0];
                updatedArray[8 * (item.Slot - 1) + 7] = temporary[1];

                //temporary = BitConverter.GetBytes(item.ItemFlag.Value);
                //strItemTime[2 * (item.Slot - 1)]     = temporary[0];
                //strItemTime[2 * (item.Slot - 1) + 1] = temporary[1];
                //temporary = BitConverter.GetBytes(item.ItemExpireTime.Value);
                //strItemTime[4 * (item.Slot - 1) ]    = temporary[0];
                //strItemTime[4 * (item.Slot - 1) + 1] = temporary[1];
                //strItemTime[4 * (item.Slot - 1) + 2] = temporary[2];
                //strItemTime[4 * (item.Slot - 1) + 3] = temporary[3];
                //i++;
            }

            //var result = connection.Query($" update USERDATA set strItemSerial = {strItemTime} where strUserID = 'Test' ");

            return updatedArray;
        }

        #endregion
    }
}