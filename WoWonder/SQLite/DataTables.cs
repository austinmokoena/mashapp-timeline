﻿using SQLite;
using WoWonderClient.Classes.Global;

namespace WoWonder.SQLite
{
    public class DataTables
    {
        [Table("LoginTb")]
        public class LoginTb
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdLogin { get; set; }

            public string UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string AccessToken { get; set; }
            public string Cookie { get; set; }
            public string Email { get; set; }
            public string Status { get; set; }
            public string Lang { get; set; }
        }

        [Table("SettingsTb")]
        public class SettingsTb : GetSiteSettingsObject.ConfigObject
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdSettings { get; set; }

            public new string CurrencyArray { get; set; }
            public new string CurrencySymbolArray { get; set; }
            public new string PageCategories { get; set; }
            public new string GroupCategories { get; set; }
            public new string BlogCategories { get; set; }
            public new string ProductsCategories { get; set; }
            public new string JobCategories { get; set; }
            public new string Genders { get; set; }
            public new string Family { get; set; }
            public new string MovieCategory { get; set; }
            public new string PostColors { get; set; }
            public new string Fields { get; set; }
            public new string PageSubCategories { get; set; }
            public new string GroupSubCategories { get; set; }
            public new string ProductsSubCategories { get; set; }
            public new string PageCustomFields { get; set; }
            public new string GroupCustomFields { get; set; }
            public new string ProductCustomFields { get; set; }
            public new string PostReactionsTypes { get; set; }
            public new string ProPackages { get; set; }
        }

        [Table("MyContactsTb")]
        public class MyContactsTb : UserDataObject
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdMyFollowing { get; set; }

            public new string ApiNotificationSettings { get; set; }
            public new string Details { get; set; }
        }

        [Table("MyProfileTb")]
        public class MyProfileTb : UserDataObject
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdMyProfile { get; set; }

            public new string ApiNotificationSettings { get; set; }
            public new string Details { get; set; }
        }

        [Table("SearchFilterTb")]
        public class SearchFilterTb
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdSearchFilter { get; set; }

            public string Gender { get; set; }
            public string Country { get; set; }
            public string Status { get; set; }
            public string Verified { get; set; }
            public string ProfilePicture { get; set; }
            public string FilterByAge { get; set; }
            public string AgeFrom { get; set; }
            public string AgeTo { get; set; }
        }

        [Table("NearByFilterTb")]
        public class NearByFilterTb
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdNearByFilter { get; set; }

            public int DistanceValue { get; set; }
            public string Gender { get; set; }
            public int Status { get; set; }
            public string Relationship { get; set; }
        }


        [Table("GiftsTb")]
        public class GiftsTb : GiftObject.DataGiftObject
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdGift { get; set; }
        }

        [Table("StickersTb")]
        public class StickersTb
        {
            [PrimaryKey, AutoIncrement]
            public int AutoIdStickers { get; set; }

            public string PackageId { get; set; }
            public string Name { get; set; }
            public string Count { get; set; }
            public bool Visibility { get; set; }

            public string StickerList { get; set; }
        }

    }
}