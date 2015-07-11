namespace Plaid
{
    public class Institution
    {
        public Credentials credentials { get; set; }
        public bool has_mfa { get; set; }
        public string id { get; set; }
        public string[] mfa { get; set; }
        public string name { get; set; }
        public string[] products { get; set; }
        public string type { get; set; }
        public class Credentials
        {
            public string password { get; set; }
            public string username { get; set; }
        }
    }
}