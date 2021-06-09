using System.Threading.Tasks;

namespace first_app.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
