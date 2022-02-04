namespace asp_net_auth.Models
{
    public class User : Person
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string Name, string LastName, DateTime Birth, int ID, string Username, string Password) : base(Name,LastName,Birth)
        {
           this.ID = ID;
           this.Username = Username;
           this.Password = Password;
        }

     
    }
}
