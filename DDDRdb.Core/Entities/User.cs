using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDRdb.Core.Entities
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Dept { get; set; }
        public string Org { get; set; }
        public string Authority { get; set; }
    }
}
