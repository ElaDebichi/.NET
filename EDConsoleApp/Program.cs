using ED.domain;
using ED.Service;
using System;
using System.Collections.Generic;

namespace EDConsoleApp
{
    class Program
    {
        /*
        public static void InputProduct(ref string product)
        {
            while (product == "")
            {
                System.Console.Write("Please type in your product name: ");
                product = System.Console.ReadLine() ?? "";
            }
        }

        public static void InputPrice(out double price)
        {
            price = 0;

            while (price <= 0)
            {
                try
                {
                    System.Console.Write("Please type in your product price: ");
                    price = Double.Parse(System.Console.ReadLine());

                    if (price <= 0)
                        System.Console.WriteLine("Price has to be greater than 0.");
                }
                catch
                {
                    System.Console.WriteLine("Product has to be numerical.");
                }

            }
        }

        public static void Output(string product, double price, int qnt = 0)
        {
            System.Console.WriteLine("Product name: " + product);
            System.Console.WriteLine("Product price: " + price);

            if (qnt != 0)
                System.Console.WriteLine("Quantity: " + qnt);
        }

        */

        public static List<Product> FindProductFN(string l, List<Product> list)
        {
            List<Product> list1 = new List<Product>();
            foreach (var item in list)
            {
                if (item.Label.StartsWith(l))
                {
                    list1.Add(item);

                }
            }
            return list1;
        }
        public static void Main(string[] args)
        {
            /*
            string product = "", product2 = "";
            double price, price2;

            InputProduct(ref product);
            InputPrice(out price);

            Output(product, price, 19);

            InputProduct(ref product2);
            InputPrice(out price2);

            Output(product2, price2);

            //Tannery exemple
            int n = 10;
            string result = (n > 0) ? "Greater than 0" : "Not greater than 0";
            Console.WriteLine("{0} is {1}", n, result);
            */

            Provider provider = new Provider();
            Provider provider1 = new Provider();
            Provider provider2 = new Provider();
           // Console.WriteLine(Provider.count);
            provider.Id = 1;
            provider.Nom = "ela";
            provider.Email = "mary@gmail.com";
            provider.Password = "test123456";
            provider.ConfirmPassword = "test123456";
            //Console.WriteLine(provider.Login("ela", "test123456"));
            //Console.WriteLine(provider.Login("ela", "test123456", "mary@gmail.com"));
            //bool isApp;
            //Provider.SetIsApproved(provider.ConfirmPassword, provider.Password, out isApp);
            //Console.WriteLine(provider.IsApproved);


            //  Provider.SetIsApproved(provider);
            // Console.WriteLine(provider.IsApproved);

////////////////categories///////////////////////////////////////
            Category category1 = new Category();
            category1.categoryId = 1;
            category1.name = "clothes";

            Category category2 = new Category();
            category2.categoryId = 1;
            category2.name = "fruits";

            Category category3 = new Category();
            category3.categoryId = 1;
            category3.name = "electro";

////////////////products///////////////////////////////////////////////
            Product product1 = new Product();
            product1.Label = "coffee maker";
            product1.Description = "description1";
            product1.Price = 120;
            product1.category = category1;

            //product1.GetMyType();
            Product product2 = new Product();
            product2.Label = "apple";
            product2.Description = "description2";
            product2.Price =265;
            product1.category= category2;
             // product2.GetMyType();

             Product product3 = new Product();
            product3.Label = "shirt";
            product3.Description = "description3";
            product3.Price = 354;
            product1.category= category3;
             //  product3.GetMyType();

            List < Product > products = new List<Product>();

            products.Add(product1);
           
            

            provider.products = products;


           provider.getDetails();

            Product prod = new Product()
            {
                Description = "des",
                Label = "label",
                Price = 3445
            };

            provider.GetProducts("description", "description1");



            provider.Find = delegate (Product product) {
                return null;
            };
            provider.Find.Invoke(null);


//////////////////////////////////////////////////////////////////////////////////////////////////////////

            ProjectManagement pm = new ProjectManagement();
            pm.Products = products;
             pm.FindProduct = FindProductFN;
             pm.FindProduct("a", products);
             pm.FindProductByFirstChar("a", FindProductFN);
            /*pm.FindProductByFirstChar("a",
                (string l, List<Product> list) =>
                {
                    List<Product> list1 = new List<Product>();
                    foreach (var item in list)
                    {
                        if (item.Label.StartsWith(l))
                        { list1.Add(item); }
                    }
                    return list1;
                }
               );*/


            pm.UpperName();
            Console.WriteLine("List of products in PM: ");

            foreach (var item in pm.Products)
            {
                Console.Write("Label: ");
                Console.WriteLine(item.Label);
                Console.Write("Category: ");
                Console.WriteLine(item.category.name);

            }
            Console.WriteLine("In Category: ");
            Console.WriteLine(pm.InCategory("electro"));
            ////////////////////////////////////////////////////////////////////////////////////

            Chemical ch1 = new Chemical();
            ch1.City = "tunis";
            Chemical ch2 = new Chemical();
            ch.City = "ariana";



        }




        public IList<Product> FindSmth(Product product)
        {
            Console.WriteLine("findsmth");
            return null;
        }
    }
}

