using Microsoft.EntityFrameworkCore;
using postgresql.Models;

namespace postgresql.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }

        ///SELECT * FROM "Users";


        //  NuGet Packages

        //Npgsql.EntityFrameworkCore.PostgreSQL

        //Microsoft.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore.Design
        //Microsoft.EntityFrameworkCore.Tools




    }
}
