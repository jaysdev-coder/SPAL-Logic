using SPAL.App.Models;

namespace SPAL.App.Clients
{
    public interface ISqlServiceT<T> : IQueryService where T : ITableModel
    {
        abstract Task<IReadOnlyCollection<T>> SubmitQuery(string query);
        abstract Task Submit(string query);
        abstract Task<IReadOnlyCollection<T>> GetResultStream(string query);
    }
}
