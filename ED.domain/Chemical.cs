using System;
using System.Collections.Generic;
using System.Text;

namespace ED.domain
{
    public class Chemical : Product
    {

        public string LabName { get; set; }
        public string City { get; set; }
        public string StreetAdress { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
        public void GetMyType()
        {
            Console.WriteLine("this is a chemical product");
        }
    }
}
