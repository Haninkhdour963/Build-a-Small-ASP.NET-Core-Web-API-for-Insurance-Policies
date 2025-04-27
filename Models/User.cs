namespace IPolicyAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // In real projects, passwords must be hashed!
    }
}
