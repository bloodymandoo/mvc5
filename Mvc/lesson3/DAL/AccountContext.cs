using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using lesson3.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace lesson3.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext()
            : base("AccountContext")
        {

        }
        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysUserRole> SysUserRole { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}