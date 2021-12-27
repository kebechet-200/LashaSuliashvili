using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice_1
{
    public static class ParseCustomer
    {
        private const string _path = "../../../Customers.txt";
        private static List<Customer> _customerList = new List<Customer>();
        
        public static List<Customer> CustomerParser()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('|');
                    Customer c = new Customer();
                    c.CustomerID = Convert.ToInt32(line[0]);
                    c.CustomerName = (line[1]);
                    _customerList.Add(c);
                }
            }
            return _customerList;
        }
    }
}
