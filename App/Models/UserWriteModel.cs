namespace SPAL.App.Models
{
    public class UserWriteModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; }
        public string? Salt { get; set; }
    }
}
