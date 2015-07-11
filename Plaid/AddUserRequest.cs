namespace Plaid
{
    using System.Collections.Generic;

    public class AddUserRequest
    {
        public AddUserRequest()
        {
            options=new Dictionary<string, object>();
        }
        public string client_id { get; set; }
        public string secret { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public Dictionary<string, object> options { get; set; } 
    }
}