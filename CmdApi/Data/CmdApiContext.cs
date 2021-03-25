using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CmdApi.Models
{
    public class CmdApiContext : DbContext
    {
        public CmdApiContext (DbContextOptions<CmdApiContext> options)
            : base(options)
        {
        }

        public DbSet<CmdApi.Models.Places> Places { get; set; }
    }
}
