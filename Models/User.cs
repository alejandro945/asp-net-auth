namespace asp_net_auth.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
     
    }
}
