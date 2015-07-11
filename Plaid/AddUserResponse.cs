using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaid
{

    public class AddUserResponse
    {
        public string type { get; set; }
        public Mfa[] mfa { get; set; }
        public Account[] accounts { get; set; }
        public Transaction[] transactions { get; set; }
        public string access_token { get; set; }

        public bool MfaRequired { get; set; }
    }
    public class Mfa
    {
        public string mask { get; set; }
        public string type { get; set; }
    }


    public class Account
    {
        public string _id { get; set; }
        public string _item { get; set; }
        public string _user { get; set; }
        public Balance balance { get; set; }
        public Meta meta { get; set; }
        public string type { get; set; }
        public string institution_type { get; set; }
    }

    public class Balance
    {
        public float available { get; set; }
        public float current { get; set; }
    }

    public class Meta
    {
        public string number { get; set; }
        public string name { get; set; }
        public int limit { get; set; }
    }

    public class Transaction
    {
        public string _account { get; set; }
        public string _id { get; set; }
        public float amount { get; set; }
        public string date { get; set; }
        public string name { get; set; }
        public TransactionMeta meta { get; set; }
        public bool pending { get; set; }
        public Type type { get; set; }
        public string[] category { get; set; }
        public string category_id { get; set; }
        public Score score { get; set; }
    }

    public class TransactionMeta
    {
        public Location location { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public Coordinates coordinates { get; set; }
        public string zip { get; set; }
    }

    public class Coordinates
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Type
    {
        public string primary { get; set; }
    }

    public class Score
    {
        public Location1 location { get; set; }
        public float name { get; set; }
    }

    public class Location1
    {
        public int city { get; set; }
        public int state { get; set; }
        public int address { get; set; }
        public int zip { get; set; }
    }

}
