using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //database for publish
            optionsBuilder.UseSqlServer("Server=db41442.public.databaseasp.net; Database=db41442; User Id=db41442; Password=Yj3-8!eFmQ=9; Encrypt=True;");
            //database for dev
            //optionsBuilder.UseSqlServer("Data Source=.; Database=MVC_Project; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
