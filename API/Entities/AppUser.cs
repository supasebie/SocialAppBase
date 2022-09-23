namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "UserNameError"!;

        public byte[] PasswordHash { get; set; } = new byte[0]!;

        public byte[] PasswordSalt { get; set; } = new byte[0]!;
    }
}