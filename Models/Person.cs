namespace asp_net_auth.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }

        public Person(string Name, string LastName, DateTime Birth)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Birth = Birth;
        }
    }
}
