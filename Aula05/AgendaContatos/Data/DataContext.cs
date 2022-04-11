

using Microsoft.EntityFrameworkCore;

namespace AgendaContatos.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}