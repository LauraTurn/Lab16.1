using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab16._1Validation.Models
{
    public class NUser
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }

        public static List<NUser> FullInfo = new List<NUser>();
    }

}
