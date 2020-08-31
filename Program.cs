using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue30082020
{
    class Program
    {
        static void Display(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "lola", 1456, "street 1", 15, 44));
            customers.Add(new Customer(2, "lola", 1476, "street 4", 75, 64));
            customers.Add(new Customer(3, "lola", 1458, "street 5", 18, 47));
            customers.Add(new Customer(4, "lola", 1466, "street 6", 65, 24));
            customers.Add(new Customer(5, "lola", 1423, "street 7", 75, 43));

            MyQueue myQueue = new MyQueue();
            myQueue.Initi(customers);
            Console.WriteLine(myQueue.DequeueProtectzia().ToString());
            Display(myQueue.DequeueCustomer(2));
            Console.WriteLine(myQueue.DequeueProtectzia().ToString());
            Console.ReadLine();
        }
    }
}
