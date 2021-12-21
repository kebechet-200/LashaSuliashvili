using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice_1
{
    public static class LinqOperations
    {
        public static void EachClientOrderList(List<Customer> clist, List<Order> olist)
        {
            var quantity = from d in clist
                           from o in olist
                           where (d.CustomerID == o.CustomerID)
                           select o.CustomerID;

            foreach (var item in clist)
            {
                var orderItem = (from q in quantity
                                 where q == item.CustomerID
                                 select q).Count();

                Console.WriteLine($"{item.CustomerID} : {orderItem}");
            }
        }

        public static void EachClientSumList(List<Customer> clist, List<Order> olist)
        {
            var quantity = from o in olist
                           select new { o.CustomerID, o.Price };

            foreach (var item in clist)
            {
                var orderItem = (from q in quantity
                                 where q.CustomerID == item.CustomerID
                                 select q.Price).Sum();

                Console.WriteLine($"{item.CustomerID} : {orderItem}");
            }
        }

        public static void EachClientMinList(List<Customer> clist, List<Order> olist)
        {
            var quantity = from o in olist
                           select new { o.CustomerID, o.Price };

            foreach (var item in clist)
            {
                var orderItem = (from q in quantity
                                 where q.CustomerID == item.CustomerID
                                 select q.Price).Min();

                Console.WriteLine($"{item.CustomerID} : {orderItem}");
            }
        }

        public static void OnlyClientsMoreThanOneOrder(List<Customer> clist, List<Order> olist)
        {
            var quantity = from d in clist
                           from o in olist
                           where (d.CustomerID == o.CustomerID)
                           select o.CustomerID;

            foreach (var item in clist)
            {
                var orderItem = (from q in quantity
                                 where q == item.CustomerID
                                 select q).Count();

                if (orderItem > 1)
                    Console.WriteLine($"{item.CustomerID} : {orderItem}");
            }
        }

        public static void OnlyClientsMoreThanAvgTen(List<Customer> clist, List<Order> olist)
        {
            var quantity = from d in clist
                           from o in olist
                           where (d.CustomerID == o.CustomerID)
                           select new { o.CustomerID, o.Price };

            foreach (var item in clist)
            {
                var orderItem = (from q in quantity
                                 where q.CustomerID == item.CustomerID
                                 select q.Price).Sum();

                if (orderItem > 10)
                    Console.WriteLine($"{item.CustomerID} : {orderItem}");
            }
        }
    }
}
