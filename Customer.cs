using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue30082020
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthYear, string address, int protection, int totalPurchases)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
            TotalPurchases = totalPurchases;
        }

        public override string ToString()
        {
            return base.ToString() +$"{Id} { Name } { BirthYear}  { Address } { Protection}  { TotalPurchases} ";
            
        }
    }
}
