using System;
using System.Collections.Generic;
using System.Text;

namespace ED.Service
{
    public static class MyExtentionProduct
    {
        public static void UpperName(this ProjectManagement pm)
        {
            foreach (var item in pm.Products)
            {
                item.Label = item.Label.ToUpper();
            }
        }
        public static bool InCategory(this ProjectManagement pm, string cat)
        {
            foreach (var item in pm.Products)
            {
                if (item.category.name == cat)
                {
                    return true;
                }  
            }
            return false;
        }
    }
}
