using System.Threading.Tasks;
using System.Collections.Generic;
using first_app.Domain.Models;

namespace first_app.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
    }
}
