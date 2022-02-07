using System;
using System.Collections.Generic;
using System.Text;

namespace ED.domain
{
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
