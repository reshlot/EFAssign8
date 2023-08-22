using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment8
{
    internal class Orders
    {
        static AdvancedDBEntities db;
        public void EFRead()
        {
            try
            {
                db = new AdvancedDBEntities();
                foreach (Order o in db.Orders)
                {
                    Console.WriteLine("Order ID: " + o.Orderld);
                    Console.WriteLine("Order Date: " + o.OrderDate);
                    Console.WriteLine("Quantity: " + o.Quantity);
                    Console.WriteLine("Discount: " + o.Discount);
                    Console.WriteLine("Shipped : " + o.IsShipped);
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
                Order Order = new Order();

                Console.WriteLine("Enter ID: ");
                Order.Orderld = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Date: ");
                Order.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Quantity: ");
                Order.Quantity = short.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Discount: ");
                Order.Discount = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order is Shipped or Not: ");
                Order.IsShipped = bool.Parse(Console.ReadLine());

                db.Orders.Add(Order);
                db.SaveChanges();

                Console.WriteLine("Order Record Inserted");

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
                Order Order = new Order();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Order = db.Orders.SingleOrDefault(e => e.Orderld == id);

                if (Order == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    Console.WriteLine("Enter Order Date: ");
                    Order.OrderDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Quantity: ");
                    Order.Quantity = short.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Discount: ");
                    Order.Discount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order is Shipped or Not: ");
                    Order.IsShipped = bool.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Order Record Updated");

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
                Order Order = new Order();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Order = db.Orders.SingleOrDefault(e => e.Orderld == id);

                if (Order == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    db.Orders.Remove(Order);
                    db.SaveChanges();

                    Console.WriteLine("Order Record Deleted");

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
    

