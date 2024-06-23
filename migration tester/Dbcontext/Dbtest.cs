using Microsoft.EntityFrameworkCore;
using migration_tester.Model;

namespace migration_tester.Dbcontext
{
    public class Dbtest : DbContext
    {
        IConfiguration _configuration { get; set; }
        public DbSet<Test> tests { get; set; }

        public Dbtest(DbContextOptions<Dbtest> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  
            base.OnModelCreating(modelBuilder);

            // Map entities to tables  
            //modelBuilder.Entity<WalletModel>().ToTable("users");
            modelBuilder.Entity<Test>();
        }
    }
}
