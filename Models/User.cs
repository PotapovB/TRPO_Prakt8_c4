namespace TRPO_Prakt8.Models
{
    public partial class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Role { get; set; }

        public string PasswordHash { get; set; }
    }
}
