using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Practice_1
{
    public static class ParseOrder
    {
        private const string _path = "../../../Orders.txt";
        private static List<Order> _orderList = new List<Order>();

        public static List<Order> OrderParser()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('|');
                    Order c = new Order();
                    c.OrderID = Convert.ToInt32(line[0]);
                    c.Date = DateTime.ParseExact(line[1], "yyyyMMdd", CultureInfo.InvariantCulture);
                    c.Product = line[2];
                    c.Price = Convert.ToDecimal(line[3]);
                    c.CustomerID = Convert.ToInt32(line[4]);
                    _orderList.Add(c);
                }
            }
            return _orderList;
        }
    }
}
