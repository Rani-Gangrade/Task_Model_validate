using Microsoft.EntityFrameworkCore;

namespace Task_Model_validate.Models
{
    public class StdDBcontext:DbContext
    {
        public StdDBcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StdModel> StdModels { get; set; }

    }
}
