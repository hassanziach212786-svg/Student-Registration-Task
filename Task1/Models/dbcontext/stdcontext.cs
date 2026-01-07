using Microsoft.EntityFrameworkCore;
namespace Task1.Models.dbcontext
{

    public class stdcontext:DbContext
    {

   
       
            public stdcontext(DbContextOptions<stdcontext> options) : base(options) { }

        public DbSet<Stdform> Registrations { get; set; }

    }







}

