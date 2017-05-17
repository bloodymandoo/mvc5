using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using lesson3.Models;

namespace lesson3.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser{UserName="Tom",Email="Tom@sohu.com",Password="1"},
                new SysUser{UserName="Jerry",Email="Jerry@sohu.com",Password="2"}
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRole = new List<SysRole>
            {
                new SysRole{RoleName="Administrators",RoleDesc="Admin have all the..."},
                new SysRole{RoleName="General Users",RoleDesc="General Users have ...."}
            };
            sysRole.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();

        }
    }
}