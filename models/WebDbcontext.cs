using Microsoft.EntityFrameworkCore;

namespace Clinic_Management_System.models
{
    public class WebDbcontext:DbContext
    {
        public WebDbcontext(DbContextOptions<WebDbcontext> options):base(options)
        {
         
        }
        public DbSet<DataModel> DataModels{ get; set; }
    }
}
