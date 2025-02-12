﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ED.domain
{
    public delegate IList<Product> Find (Product product); //Find is the Non Type Delegate
    public class Provider : Concept
    {

        public static int count;
        public string confirmPassword;
        public string password;

        public Provider()
        {
            count++;
        }
        [Key]
        public int Id {set; get;} //propriété khater feha get w set sinn attribut 
        public string Nom
        {set; get;}
        [DataType(DataType.Password),
            MinLength(8),
            Required]
        public string Password
        {
            set
            {
                if (value.Length < 5 || value.Length > 20)
                    Console.WriteLine("longueur");
                else
                    password = value;
            }
            get { return password; }

        }
        [Compare("Password"), NotMapped]
        public string ConfirmPassword
        {
            set
            {
                if (value == Password)
                { confirmPassword = value;
                    System.Console.WriteLine("passwords match");
                }
                else
                { System.Console.WriteLine("passwords don't match"); }
            }
            get { return confirmPassword; }
        }
        [Required, EmailAddress]
        public string Email
        {
            set;
            get;
        }
        public Boolean IsApproved
        {
            set;
            get;
        }

        //public Find Find { set; get; }
        //=>> This is commented because it envoked the following error:
        //No suitable constructor was found for entity type 'Find'. The following constructors had parameters that could not be bound to properties of the entity type: cannot bind 'object', 'method' in 'Find(object object, IntPtr method)'.


        public IList<Product> products { set; get; }
        public override string ToString()
        {
            //return base.ToString();
            return $"id= {Id}, name= {Nom}, email= {Email}";
        }

        //************************************

        public bool Login(string nom, string password, string email = null)
        {
           if(email != null)  return nom == Nom && password == Password && email==Email  ;
            else return nom == Nom && password == Password;
        }
        //*****************************************
        /*public static void SetIsApproved(Provider provider)
        {
                provider.IsApproved = provider.Password == provider.ConfirmPassword;          }
        }*/
        public static void SetIsApproved(string confirmPassword, string password, out bool isApproved) // ref/out
        {
            isApproved = password == confirmPassword;
        }
        public sealed override void getDetails()
        {
            System.Console.WriteLine("Nom: "+Nom+", email: "+Email+", products: ");
            foreach (var prod in products)
                Console.WriteLine(prod.ToString());

        }


        public IEnumerable<Product> GetProviderProducts(string filterType, string filterValue)
        {
           

            foreach (var product in products)
            {
                if (filterType.ToUpper() == "DESCRIPTION")
                    if (filterValue == product.Description)
                       yield return product;
                // products.Add(product);

                if (filterType.ToUpper() == "DATEPROD")
                    if (filterValue == product.DateProd.ToString())
                        yield return product;
                      //  products.Add(product);
            }
           

        }
         
        public void GetProducts(string filterType, string filterValue)
        {
            IList<Product> products = new List<Product>();

            foreach(var product in products)
            {
                if (filterType.ToUpper() == "DESCRIPTION")
                    if (filterValue == product.Description)
                        // yield product;
                        products.Add(product);

                if (filterType.ToUpper() == "DATEPROD")
                    if (filterValue == product.DateProd.ToString())
                        products.Add(product);

                /*
                   if (filterType.ToUpper() == "DATEPROD")
                        if (DateTime.Parse(filterValue) == product.DateProd)
                            products.Add(product);

               
                if (filterType.ToUpper() == "DATEPROD")

                 DateTime datetime;
                 DateTime.TryParse(filterValue, out datetime);
                
                    if (DateTime == product.DateProd)
                        products.Add(product);
                */

                if (filterType.ToUpper() == "LABEL")
                    if (filterValue == product.Label)
                        products.Add(product);

                if (filterType.ToUpper() == "PRICE")
                    if (filterValue == product.Price.ToString())
                        products.Add(product);
            }
            foreach (var product in products) 
                Console.WriteLine(product.ToString());
        }
    }
}
