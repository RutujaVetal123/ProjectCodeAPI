using Microsoft.EntityFrameworkCore;
using ProjectCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Data
{
    public class ProjectCodeDbContext : DbContext
    {
        public ProjectCodeDbContext(DbContextOptions<ProjectCodeDbContext> options) : base(options)
        {

        }
        public DbSet<CodeDetails> CodeDetails { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
