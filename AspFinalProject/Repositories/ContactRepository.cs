using AspFinalProject.Models.Contexts;
using AspFinalProject.Models.Entities;

namespace AspFinalProject.Repositories
{
    public class ContactRepository : AccountRepository<ContactEntity>
    {
        public ContactRepository(AppDbContext context) : base(context)
        {
        }
    }
}
