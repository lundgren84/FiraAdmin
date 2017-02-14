using ConnectionLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer
{
    public class FiraAdmin_Context : DbContext
    {
        public FiraAdmin_Context()
        {

        }
        public DbSet<tbl_Account> Accounts { get; set; }
    }
}
