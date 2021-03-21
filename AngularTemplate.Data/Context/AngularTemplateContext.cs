using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularTemplate.Domain.Entities;
using AngularTemplate.Data.Mappings;
using AngularTemplate.Data.Extensions;

namespace AngularTemplate.Data.Context
{
    public class AngularTemplateContext: DbContext
    {
        public AngularTemplateContext(DbContextOptions<AngularTemplateContext> options) : base(options)
        {

        }

        #region "DbSets"

        public DbSet<User> Users { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}