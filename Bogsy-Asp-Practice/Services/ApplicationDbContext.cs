using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bogsy_Asp_Practice.Services
{
    public class ApplicationDbContext : IdentityDbContext //make sure naay using Microsoft Entity Framecore
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }     
    }
}
