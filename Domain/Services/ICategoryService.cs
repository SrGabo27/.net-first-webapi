using System.Collections.Generic;
using System.Threading.Tasks;
using first_app.Domain.Models;
using first_app.Domain.Services.Communication;

namespace first_app.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
    }
}
