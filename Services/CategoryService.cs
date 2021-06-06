using System.Collections.Generic;
using System.Threading.Tasks;
using first_app.Domain.Services;
using first_app.Domain.Models;
using first_app.Domain.Repositories;

namespace first_app.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
