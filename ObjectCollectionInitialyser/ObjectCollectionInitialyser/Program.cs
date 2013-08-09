using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ObjectCollectionInitialyser
{
  internal static class Program
  {

    private static void Main(string[] args)
    {
      List<Order> orderList = setupOrders();



      //var ordersAfterDecember = orderList.Where(o => o.OrderDate > DateTime.Parse("12/8/2007"));

      /*
      var ordersAfterDecmber = from o in orderList
                               where o.OrderDate > DateTime.Parse("12/8/2007")
                               select o;
      foreach (var o in ordersAfterDecmber) Console.WriteLine(o.OrderDate);
      */


     // var orders = from o in orderList select new { o.OrderID, o.OrderAmount };

      //foreach (var ord in orders) Console.WriteLine(ord.OrderAmount + " " + ord.OrderID);


      //var myOrders = orderList.Select(o => new {o.OrderID, o.OrderAmount});




      //var myOrders = orderList.Where(o => o.OrderAmount == orderList.Select(i => i.OrderAmount).Max());
     // var maxOrder = from o in orderList select o.OrderAmount;

      //var orders = from o in orderList where o.OrderAmount == maxOrder.Max() select o ;
      //foreach (var o in orders) Console.WriteLine(o.OrderDate + " " + o.OrderAmount + " " + o.OrderID);


      //var orders = orderList.Where(o => o.OrderItems.Any(oi => oi.ProductName == "Widgets"));

      //var orders = orderList.Select(o => o.OrderAmount).Sum();


      //var orders = (from o in orderList select o.OrderAmount).Average();


      //var orders = orderList.Where(o => o.OrderItems.Count > 2).Count();



      //var orders = orderList.SelectMany(o => o.OrderItems, (o, oi) => new { o.OrderID, oi.ProductName, oi.OrderItemID });


      var orders = from o in orderList select new Order { OrderID = o.OrderID + 1000, OrderDate = DateTime.Now };



      foreach (var ord in orders)
      {
        Console.WriteLine(ord.OrderID + " - " + ord.OrderDate);
      }




      
      Console.ReadLine();
    }



    static private List<Order> setupOrders()
        {
            List<Order> orderList = new List<Order>();

            Order o1 = new Order();
            o1.OrderDate = DateTime.Parse("12/7/2007 1:05 PM");
            o1.OrderID = 9009;
      o1.OrderAmount = 250m;

            OrderItem oi1 = new OrderItem();
            oi1.OrderItemID = 123;
            oi1.ProductName = "FooBar";
            oi1.Quantity = 2;
            o1.OrderItems.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.OrderItemID = 124;
            oi2.ProductName = "BazQuirk";
            oi2.Quantity = 3;
            o1.OrderItems.Add(oi2);

            Order o2 = new Order();
            o2.OrderDate = DateTime.Parse("12/8/2007 9:15 AM");
            o2.OrderID = 9010;
      o2.OrderAmount = 200m;

            OrderItem oi3 = new OrderItem();
            oi3.OrderItemID = 125;
            oi3.ProductName = "FooBar";
            oi3.Quantity = 1;
            o2.OrderItems.Add(oi3);

            OrderItem oi4 = new OrderItem();
            oi4.OrderItemID = 126;
            oi4.ProductName = "Gadgets";
            oi4.Quantity = 5;
            o2.OrderItems.Add(oi4);

            OrderItem oi5 = new OrderItem();
            oi5.OrderItemID = 127;
            oi5.ProductName = "Bazquirk";
            oi5.Quantity = 1;
            o2.OrderItems.Add(oi5);

            OrderItem oi6 = new OrderItem();
            oi6.OrderItemID = 128;
            oi6.ProductName = "Widgets";
            oi6.Quantity = 6;
            o2.OrderItems.Add(oi6);

            Order o3 = new Order();
            o3.OrderDate = DateTime.Parse("12/9/2007 4:50 PM");
            o3.OrderID = 9011;
      o3.OrderAmount = 275;

            OrderItem oi7 = new OrderItem();
            oi7.OrderItemID = 129;
            oi7.ProductName = "Widgets";
            oi7.Quantity = 3;
            o3.OrderItems.Add(oi7);

            OrderItem oi8 = new OrderItem();
            oi8.OrderItemID = 130;
            oi8.ProductName = "Gadgets";
            oi8.Quantity = 5;
            o3.OrderItems.Add(oi8);

            Order o4 = new Order();
            o4.OrderDate = DateTime.Parse("12/10/2007 1:23 PM");
            o4.OrderID = 9012;
      o4.OrderAmount = 154m;

            OrderItem oi9 = new OrderItem();
            oi9.OrderItemID = 131;
            oi9.ProductName = "Widgets";
            oi9.Quantity = 1;
            o4.OrderItems.Add(oi9);

            orderList.Add(o1);
            orderList.Add(o2);
            orderList.Add(o3);
            orderList.Add(o4);

            return orderList;
        }

    }


        class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public Order(int orderID, DateTime orderDate)
        {
            OrderID = orderID;
            OrderDate = orderDate;
        }
    }

    class OrderItem
    {
        public int OrderItemID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    class Address
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
  }

