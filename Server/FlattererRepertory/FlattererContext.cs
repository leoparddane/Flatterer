using Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace FlattererRepertory
{
    public class FlattererContext : DbContext
    {
        public FlattererContext(DbContextOptions<FlattererContext> options) : base(options)
        {
        }
        DbSet<User> user { get; set; }
        DbSet<Question> question { get; set; }

    }
}
