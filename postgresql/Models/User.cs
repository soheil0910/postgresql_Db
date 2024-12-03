namespace postgresql.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? lastnem  { get; set; }

    }
}


///SELECT * FROM "Users";
