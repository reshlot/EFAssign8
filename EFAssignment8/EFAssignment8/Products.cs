using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment8
{
    public  class Products
    {
        static AdvancedDBEntities db;
        public void EFRead()
        {
            try
            {
                db = new AdvancedDBEntities();
                foreach (Product p in db.Products)
                {
                    Console.WriteLine("ID: " + p.Productid);
                    Console.WriteLine("Product Name: " + p.ProductName);
                    Console.WriteLine("Description: " + p.Description);
                    Console.WriteLine("Price: " + p.Price);
                    Console.WriteLine("Release Date: " + p.ReleaseDate);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void EFInsert()
        {
            try
            {
                db = new AdvancedDBEntities();
                Product Product = new Product();

                Console.WriteLine("Enter ID: ");
                Product.Productid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name: ");
                Product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Product Description: ");
                Product.Description = Console.ReadLine();
                Console.WriteLine("Enter Product Price: ");
                Product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Release date: ");
                Product.ReleaseDate = DateTime.Parse(Console.ReadLine());

                db.Products.Add(Product);
                db.SaveChanges();

                Console.WriteLine("Product Record Inserted");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void EFUpdate()
        {
            try
            {
                db = new AdvancedDBEntities();
                Product Product = new Product();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Product = db.Products.SingleOrDefault(e => e.Productid == id);

                if (Product == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    Console.WriteLine("Enter Product Name: ");
                    Product.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter Product Description: ");
                    Product.Description = Console.ReadLine();
                    Console.WriteLine("Enter Product Price: ");
                    Product.Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Release date: ");
                    Product.ReleaseDate = DateTime.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Product Record Updated");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        public void EFDelete()
        {
            try
            {
                db = new AdvancedDBEntities();
                Product Product = new Product();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Product = db.Products.SingleOrDefault(e => e.Productid == id);

                if (Product == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    db.Products.Remove(Product);
                    db.SaveChanges();

                    Console.WriteLine("Product Record Deleted");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
    

