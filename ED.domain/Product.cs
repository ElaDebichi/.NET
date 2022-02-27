using System;
using System.Collections.Generic;
using System.Text;

namespace ED.domain
{
    public class Product : Concept
    {

        public int ProductId{// set{ id = value; } get{ return id; }
            set;
            get;}
        public DateTime DateProd {set; get;}
        public string Description {set; get;}
        public string Label {set; get;}
        public double Price {set; get;}
        public int Quantity {set; get;}

        public string ImageName { get; set; }

        public virtual Category category { set; get; }
        public IList<Provider> providers { set; get; }

        public override string ToString()
        {
            return $"label= {Label}, description= {Description}, price= {Price}";
        }
        public void GetMyType()
        {
            Console.WriteLine("this is a product");
        }
        public override void getDetails() // if sealed child classes can't inherit
        {
            System.Console.WriteLine("description: " + Description);

        }
    }
}
