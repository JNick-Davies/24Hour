using _24Hours.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hours.Models
{
    public class UserDetail : User
    {
        public DateTimeOffset CreatedOn { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public User UserID { get; set; }

    }
}
