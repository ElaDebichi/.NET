using System;
using System.Collections.Generic;
using System.Text;
using ED.domain;
using System.Linq;

namespace ED.Service
{
    public delegate List<Product> FindProduct(string letter, List<Product> list);
    public class ProjectManagement
    {
        public List<Product> Products { set; get; }
        public List<Provider> Providers { set; get; }
        public FindProduct FindProduct { set; get; }
        public List<Product> FindProductByFirstChar(string l, FindProduct Body)
        {
            return Body(l, Products);  
        }

        public List<Provider> GetProviderByName(string name)
        {
            return  Providers
                    .Where(p=>p.Nom == name)
                    .ToList();
        }
        public Provider GetFirstProviderByName(string name)
        {
            return Providers
                    .Where(p => p.Nom.StartsWith(name))
                    .First();
        }
        public Provider GetProviderById(int id)
        {
            return Providers
                    .Where(p => p.Id == id)
                    .SingleOrDefault();
                  
        }
        public List<Chemical> Get5Chemical(double price)
            {
            return Products
                    .OfType<Chemical>()
                    .Where(p => p.Price > price)
                    .Take(5)
                    .ToList();

        }
        /*public List<Product> Get5Chemical1(double price)
        {
            return Products
                    .Where(p => p.Price > price && p is Chemical)
                    .Take(5)
                    .ToList();

        }*/
        public List<Product> GetProductPrice(double price)
        {
            return Products
                    .Where(p => p.Price > price)
                    .Skip(2)
                    .ToList();
        }
        public Double GetAveragePrice()
        {
            return Products
                      .Average(p => p.Price);

        }
        public Double GetMaxPrice()
        {
            return Products
                      .Max(p => p.Price);

        }
        public int GetCountProduct(string city)
        {
            return Products
                    .OfType<Chemical>()
                    .Where(p => p.City == city)
                    .Count();

        }
        public List<Chemical> GetChemicalCity()
        {
            return Products
                    .OfType<Chemical>()
                    .OrderBy(p => p.City)
                    .ToList();

        }
        /*public List<List<Chemical>> GetChemicalGroupByCity()
        {
            return Products
                    .OfType<Chemical>()
                    .OrderBy(p => p.City)
                    .GroupBy(p => p.City)
                    .Select(group => group.ToList())
                    .ToList();

                    

        }*/
        public List<IGrouping<String,Chemical>> GetChemicalGroupByCity1()
        {
            return Products
                    .OfType<Chemical>()
                    .OrderBy(p => p.City)
                    .GroupBy(p => p.City)
                    .ToList();

                    

        }
        



    }
}
