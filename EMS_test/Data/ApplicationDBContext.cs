using EMS_test.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS_test.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {    
        }

        public DbSet<UserInfo> users { get; set; }
        public DbSet<ForgotPassword> forgots { get; set; }
    }
}
