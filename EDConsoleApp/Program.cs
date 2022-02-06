using ED.domain;
using System;

namespace EDConsoleApp
{
    class Program
    {
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
            Console.WriteLine(Provider.count);
            provider.Id = 1;
            provider.Nom = "ela";
            provider.Email = "mary@gmail.com";
            provider.Password = "test123456";
            provider.ConfirmPassword = "test123456";
            Console.WriteLine(provider);
            //Console.WriteLine(provider.Login("ela", "test123456"));
            //Console.WriteLine(provider.Login("ela", "test123456", "mary@gmail.com"));
            bool isApp;
            Provider.SetIsApproved(provider.ConfirmPassword, provider.Password, out isApp);
            Console.WriteLine(provider.IsApproved);


          //  Provider.SetIsApproved(provider);
           // Console.WriteLine(provider.IsApproved);

            Product product = new Product();
            product.GetMyType();



        }
    }
}

