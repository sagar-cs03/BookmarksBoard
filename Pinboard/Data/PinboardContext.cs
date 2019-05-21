using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pinboard.Models
{
    public class PinboardContext : DbContext
    {
        public PinboardContext(DbContextOptions<PinboardContext> options)
            : base(options)
        {
        }

        public DbSet<Pinboard.Models.User> Users { get; set; }
        public DbSet<Pinboard.Models.Bookmark> Bookmarks { get; set; }
    }
}