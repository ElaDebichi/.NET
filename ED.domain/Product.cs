using System;
using System.Collections.Generic;
using System.Text;

namespace ED.domain
{
    public class Product
    {
        public int ProductId
        {
            // set{ id = value; }
            // get{ return id; }

            set;
            get;
        }
        public DateTime DateProd
        {
            set;
            get;

        }
        public string Description
        {
            set;
            get;
        }
        public string Label
        {
            set;
            get;
        }
        public double Price
        {
            set;
            get;
        }
        public int Quantity
        {
            set;
            get;
        }
        public override string ToString()
        {
            return base.ToString();

        }
        public void GetMyType()
        {
            Console.WriteLine("this is a product");
        }
    }
}
