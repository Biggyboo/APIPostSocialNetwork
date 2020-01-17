using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIPost.Models
{
    public class APIPostContext : DbContext
    {
        public APIPostContext (DbContextOptions<APIPostContext> options)
            : base(options)
        {
        }

        public DbSet<APIPost.Models.Post> Post { get; set; }
    }
}
