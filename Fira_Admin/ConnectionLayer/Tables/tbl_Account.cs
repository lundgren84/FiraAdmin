using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLayer.Tables
{
   public class tbl_Account
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        
        public bool Admin { get; set; }
    }
}
