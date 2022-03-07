using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ED.domain
{
   // [Table("Product")]

    public class Biological : Product
    {
        public string Herbs { get; set; }
        public override string ToString()
        {
            return base.ToString();
           // return $"{nameof(Biological)}: {Biological}";
        }
        public new void GetMyType()
        {
            Console.WriteLine("this is a biological product");
        }
      
    } 
}
