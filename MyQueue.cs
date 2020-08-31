using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queue30082020
{
    class MyQueue
    {
        private List<Customer> _customers=new List<Customer>();

        public void Enqueque(Customer customer)
        {
            _customers.Add(customer);
        }

       public Customer Dequeque()
        {
            Customer first = _customers[0];
            _customers.RemoveAt(0);
            return first;
        }

        public void Initi(List<Customer> customers)
        {
            _customers = customers;
        }

        public void Clear()
        {
            _customers.Clear();
        }

        public Customer whoIsNext()
        {
            return _customers[0];
        }

        public int Count {
            get
            {
                return _customers.Count;
            }
                
                }

        public void SortByProtection()
        {

            _customers.Sort(CompareProtection);
        }

        public void SortByTotalPurchases()
        {

            _customers.Sort(ComparePurchases);
        }

        public void SortByBirthYear()
        {

            _customers.Sort(ComparePurchases);
        }





        private static int CompareProtection(Customer customer1, Customer customer2)
        {
            int x = customer1.Protection;
            int y = customer2.Protection;

            if (x == y)
                return 0;
            else if (x > y)
                return 1;
            else
                return -1;
        
        }


        private static int ComparePurchases(Customer customer1, Customer customer2)
        {
            int x = customer1.TotalPurchases;
            int y = customer2.TotalPurchases;

            if (x == y)
                return 0;
            else if (x > y)
                return 1;
            else
                return -1;

        }

        private static int CompareBirth(Customer customer1, Customer customer2)
        {
            int x = customer1.BirthYear;
            int y = customer2.BirthYear;

            if (x == y)
                return 0;
            else if (x > y)
                return 1;
            else
                return -1;

        }

        public List <Customer> DequeueCustomer(int num)
        {
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < num; i++)
            {
                customers.Add(_customers[0]);
                _customers.RemoveAt(0);
            }
            return customers;
        }

        public void AniRakSheela(Customer customer)
        {
            _customers.Insert(0, customer);
        }

        public Customer DequeueProtectzia()
        {
            int max = _customers[0].Protection;
            Customer customer = _customers[0];
            int ind = 0;
            for (int i = 1; i < _customers.Count; i++)
            {
                if (max < _customers[i].Protection)
                {
                    max = _customers[i].Protection;
                    customer = _customers[i];
                    ind = i;
                }
            }

            _customers.RemoveAt(ind);

            return customer;
        
        }




    }
}
