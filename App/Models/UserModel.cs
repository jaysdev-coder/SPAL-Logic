using AWRD.DataService.Model;
namespace SPAL.App.Models;

public class UserModel : ITableModel
{
    public static string Label => "User";
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}