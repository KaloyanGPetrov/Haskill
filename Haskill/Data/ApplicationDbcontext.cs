using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Haskill.Data
{
    public class ApplicationDbcontext : IdentityDbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        { }




    }
}
