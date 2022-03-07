using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ED.domain
{
    public class Client
    {
        [Key]
        public int Cin { get; set; }

        public DateTime Birthdate { set; get; }

        public string Email { set; get; }

        public string Firstname { set; get; }

        public string Lastname { set; get; }

        public IList<Bill> Bills{ set; get; }
        public IList<Product> Products{ set; get; }
      
    }
}
