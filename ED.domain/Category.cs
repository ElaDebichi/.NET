using System;
using System.Collections.Generic;
using System.Text;

namespace ED.domain
{
    class Category
    {
        public int categoryId { set; get; }
        public string name { set; get; }
        public IList<Product> products { set; get; }
    }
}
