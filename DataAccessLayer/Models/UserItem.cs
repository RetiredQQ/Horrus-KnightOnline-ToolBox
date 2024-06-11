using Dapper.Contrib.Extensions;
using System;

namespace DataAccessLayer.Models
{
    public class UserItem
    {
        public UserItem(int slot, int num, string? strName, short maxDurability, short currentDurability, short itemCount, int countable/*, byte? itemFlag,int? itemExpireTime, int? itemSerial*/)
        {
            Num = num;
            StrName = strName;
            MaxDuarbility = maxDurability;
            CurrentDuarbility = currentDurability;
            ItemCount = itemCount;
            Slot = slot;
            Countable = countable;
            //ItemFlag = itemFlag;
            //ItemExpireTime = itemExpireTime;
            //ItemSerial = itemSerial;
        }

        public UserItem(UserItem userItem)
        {
            Num = userItem.Num;
            StrName = userItem.StrName;
            MaxDuarbility = userItem.MaxDuarbility;
            CurrentDuarbility = userItem.CurrentDuarbility;
            ItemCount = userItem.ItemCount;
            Slot = userItem.Slot;
            Countable = userItem.Countable;
            //ItemFlag = userItem.ItemFlag;
            //ItemExpireTime = userItem.ItemExpireTime;
            //ItemSerial = userItem.ItemSerial;
        }

        public UserItem()
        {
        }

        public int Slot { get; set; }
        public int Num { get; set; }
        public string? StrName { get; set; }
        public short MaxDuarbility { get; set; }
        public short CurrentDuarbility { get; set; }
        public short ItemCount { get; set; }
        public int Countable { get; set; }
        //public byte? ItemFlag { get; set; }
        //public int? ItemExpireTime { get; set; }
        //public int? ItemSerial { get; set; }
    }
}