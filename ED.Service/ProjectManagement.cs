using System;
using System.Collections.Generic;
using System.Text;
using ED.domain;

namespace ED.Service
{
    public delegate List<Product> FindProduct(string letter, List<Product> list);
    public class ProjectManagement
    {
        public List<Product> Products { set; get; }
        public FindProduct FindProduct { set; get; }
        public List<Product> FindProductByFirstChar(string l, FindProduct Body)
        {
            return Body(l, Products);
           
        }

    }
}
