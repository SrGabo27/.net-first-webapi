using System.Collections.Generic;
using System.Threading.Tasks;
using first_app.Domain.Models;

namespace first_app.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
