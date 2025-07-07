namespace SPAL.App.Models
{
    public class UserReadModel
    {
        public Guid UserGuid { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}
