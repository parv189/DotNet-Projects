namespace MyJWT3
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = String.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }    
    }
}
