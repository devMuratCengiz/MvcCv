
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcCv.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCv.DataAccess.Context
{
    public class SqlDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public SqlDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
