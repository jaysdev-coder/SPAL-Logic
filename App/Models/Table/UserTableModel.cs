using AWRD.QueryService.Model;
namespace SPAL.App.Models.Table;

public class UserTableModel : ITableModel
{
    public static string Label => "User";
    public Guid? UserGuid { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; }
    public string? Salt { get; set; }
}