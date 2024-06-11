using ClassDefinitions.Models.InventoryEditor;

namespace ItemEditor.Static
{
    public static class StaticValues
    {
        public static string PlayerName = "";

        public static Font ItemInfoFont = new Font("Tahoma", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
        public static Font ItemCountInfoFont = new Font("Tahoma", 9.8F, FontStyle.Bold, GraphicsUnit.Point);

        public static Dictionary<string, ItemInfoModel> ItemDictionary = new Dictionary<string, ItemInfoModel>()
            {
               {"Countable"       , new ItemInfoModel("Countable Stack", Color.White )},

               {"Damage"         , new ItemInfoModel("Attack Power", Color.White )},
               {"Weight"         , new ItemInfoModel("Weight", Color.White )},
               {"Duration"       , new ItemInfoModel("Duration", Color.White )},
               {"Ac"             , new ItemInfoModel("Defense Ability", Color.White )},
               {"ReqStr"         , new ItemInfoModel("Required Strength", Color.White )},
               {"ReqSta"         , new ItemInfoModel("Required Health", Color.White )},
               {"ReqDex"         , new ItemInfoModel("Required Dexterity", Color.White )},
               {"ReqIntel"       , new ItemInfoModel("Required Intelligence", Color.White )},
               {"ReqCha"         , new ItemInfoModel("Required Magic Power", Color.White )},
               {"DaggerAc"       , new ItemInfoModel("Defense Ability (Dagger)", Color.Chartreuse )},
               {"SwordAc"        , new ItemInfoModel("Defense Ability (Sword)", Color.Chartreuse )},
               {"MaceAc"         , new ItemInfoModel("Defense Ability (Club)", Color.Chartreuse )},
               {"AxeAc"          , new ItemInfoModel("Defense Ability (Axe)", Color.Chartreuse )},
               {"SpearAc"        , new ItemInfoModel("Defense Ability (Spear)", Color.Chartreuse )},
               {"BowAc"          , new ItemInfoModel("Defense Ability (Bow)", Color.Chartreuse )},
               {"FireDamage"     , new ItemInfoModel("Fire Damage", Color.Chartreuse )},
               {"IceDamage"      , new ItemInfoModel("Ice Damage", Color.Chartreuse )},
               {"LightningDamage", new ItemInfoModel("Lightning Damage", Color.Chartreuse )},
               {"PoisonDamage"   , new ItemInfoModel("Poison Damage", Color.Chartreuse )},
               {"HPDrain"        , new ItemInfoModel("HP Drain", Color.Chartreuse )},
               {"MPDamage"       , new ItemInfoModel("MP Damage", Color.Chartreuse )},
               {"MPDrain"        , new ItemInfoModel("MP Drain", Color.Chartreuse )},
               {"MirrorDamage"   , new ItemInfoModel("Mirror Damage", Color.Chartreuse )},
               {"StrB"           , new ItemInfoModel("Strength Bonus", Color.Chartreuse )},
               {"StaB"           , new ItemInfoModel("Health Bonus", Color.Chartreuse )},
               {"DexB"           , new ItemInfoModel("Dexterity Bonus", Color.Chartreuse )},
               {"IntelB"         , new ItemInfoModel("Intelligence Bonus", Color.Chartreuse )},
               {"ChaB"           , new ItemInfoModel("Magic Power Bonus", Color.Chartreuse )},
               {"MaxHpB"         , new ItemInfoModel("Max Hp Bonus", Color.Chartreuse )},
               {"MaxMpB"         , new ItemInfoModel("Max Mp Bonus", Color.Chartreuse )},
               {"FireR"          , new ItemInfoModel("Fire Resistance", Color.Chartreuse )},
               {"ColdR"          , new ItemInfoModel("Cold Resistance", Color.Chartreuse )},
               {"LightningR"     , new ItemInfoModel("Lightning Resistance", Color.Chartreuse )},
               {"MagicR"         , new ItemInfoModel("Magic Resistance", Color.Chartreuse )},
               {"PoisonR"        , new ItemInfoModel("Poison Resistance", Color.Chartreuse )},
               {"CurseR"         , new ItemInfoModel("Curse Resistance", Color.Chartreuse )},
            };

        public static List<string> Skipable = new List<string>()
        {
             "Countable",
                "Damage",
                "Weight",
                //"Duration",
                "Ac",
                "ReqStr",
                "ReqSta",
                "ReqDex",
                "ReqIntel",
                "ReqCha",
                "DaggerAc",
                "SwordAc",
                "MaceAc",
                "AxeAc",
                "SpearAc",
                "BowAc",
                "FireDamage",
                "IceDamage",
                "LightningDamage",
                "PoisonDamage",
                "HPDrain",
                "MPDamage",
                "MPDrain",
                "MirrorDamage",
                "StrB",
                "StaB",
                "DexB",
                "IntelB",
                "ChaB",
                "MaxHpB",
                "MaxMpB",
                "FireR",
                "ColdR",
                "LightningR",
                "MagicR",
                "PoisonR",
                "CurseR"
        };
    }
}
