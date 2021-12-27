using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first
            List<Customer> customerList = ParseCustomer.CustomerParser();
            List<Order> orderList = ParseOrder.OrderParser();

            //first
            Console.WriteLine("First -> Each Client Order List");
            LinqOperations.EachClientOrderList(customerList, orderList);

            //// second 
            Console.WriteLine("---------------");
            Console.WriteLine("Second -> Each Client Sum List");
            LinqOperations.EachClientSumList(customerList, orderList);

            //// third
            Console.WriteLine("---------------");
            Console.WriteLine("Third -> Each Client Min List");
            LinqOperations.EachClientMinList(customerList, orderList);

            // fourth
            Console.WriteLine("---------------");
            Console.WriteLine("Fourth -> Only Clients With More Than One Order");
            LinqOperations.OnlyClientsMoreThanOneOrder(customerList, orderList);

            //fifth
            Console.WriteLine("---------------");
            Console.WriteLine("Fifth -> Only Clients With More Than Average 10");
            LinqOperations.OnlyClientsMoreThanAvgTen(customerList, orderList);
        }
    }
}
