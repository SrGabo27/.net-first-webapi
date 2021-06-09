using System.Threading.Tasks;
using first_app.Domain.Repositories;
using first_app.Persistence.Contexts;

namespace first_app.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        
        public UnitOfWork( AppDbContext context )
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
