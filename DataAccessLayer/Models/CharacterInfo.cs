namespace DataAccessLayer
{
    public class CharacterInfo
    {
        public string Name { get; set; }
        public byte Level { get; set; }
        public string ClanName { get; set; }

        public CharacterInfo(string strUserId, byte level, string IDName)
        {
            this.Name = strUserId;
            this.Level = level;
            this.ClanName = IDName;
        }
    }
}