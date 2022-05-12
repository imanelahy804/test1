using Microsoft.EntityFrameworkCore;
using iman_elahy_hw09.Models;
namespace iman_elahy_hw09.data
{
    public class memberDBContext:DbContext
    {
        protected override   void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=MemberDB;Data Source=DESKTOP-BJ7SRVH\SQL2019;TrustServerCertificate=True");
        }
        public DbSet<Member> members { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Library> libraries { get; set; }
        public DbSet<City> citys { get; set; }

    }
}
