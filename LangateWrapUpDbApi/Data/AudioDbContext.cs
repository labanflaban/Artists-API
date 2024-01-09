using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LangateWrapUpDbApi.Data
{
    public class AudioDbContext: DbContext
    {
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:ghwrapupsqlserver.database.windows.net,1433;Initial Catalog=Artists;Persist Security Info=False;User ID=ghwrapupadmin;Password=Vatol0c0123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");
        }
    }
}
