using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Rehearse
{
    public class Customer
    {
        public int Id ;
        public string Name ;
        public List<Order> Orders ;

        public Customer()
        { 
            Orders = new List<Order>(); // always initiaze list to an emty list so that u don't have a null reference error every time a add somwting to order list 
        }

            public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id , string name) : this() // this.() use so that empty constructor is called before constructor with Id and init list orders  
        {
            this.Name = name;
            this.Id = id ;

        }
    }
}
