using Microsoft.EntityFrameworkCore;

namespace BercaCafe_API.Context
{
    public class BercaCafeContext : DbContext
    {
        public BercaCafeContext(DbContextOptions<BercaCafeContext> options) : base(options)
        {

        }
    }
}
