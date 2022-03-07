using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ED.domain
{
    public class Bill
    {
        public DateTime Date { set; get; }

        public double Price { set; get; }

        public Client Client { set; get; }

       // [ForeignKey("Client")]
        public int ClientFk { set; get; }

       // [ForeignKey("Product")]
        public int ProductFk { set; get; }

        public Product Product { get; set; }
    }
}
