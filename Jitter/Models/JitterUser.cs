using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jitter.Models
{
    public class JitterUser
    {
        public int JitterUserId { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string Handle { get; set; }
        public string LastName { get; set; }
        public string Picture { get; set; }
    }
}