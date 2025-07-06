using AWRD.DataService.Model;
namespace SPAL.App.Models.Table;

public class UserTableModel : ITableModel
{
    public static string Label => "User";
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}