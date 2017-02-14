using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionLayer.Tables;

namespace ConnectionLayer.Repositories
{
    public static class Account_Repository
    {
        public static void AddAcc(tbl_Account acc)
        {
           using (var ctx = new FiraAdmin_Context())
            {
                ctx.Accounts.Add(acc);
                ctx.SaveChanges();
            }
        }

        public static List<tbl_Account> GetAccounts()
        {
            using (var ctx = new FiraAdmin_Context())
            {
                return ctx.Accounts.ToList();
                
            }
        }

        public static void Clear()
        {
            using (var ctx = new FiraAdmin_Context())
            {
                var toremove = ctx.Accounts.Where(x=>x.Id != 1);
                ctx.Accounts.RemoveRange(toremove);
                ctx.SaveChanges();

            }
        }
    }
}
