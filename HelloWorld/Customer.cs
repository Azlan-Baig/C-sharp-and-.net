using System.Collections.Generic;

namespace HelloWorld
{
    public class Customer
    {

        public string Name;
        public int Id;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()   //Means the constructor with no parameter will be called first.
        {
            this.Id = id;
        }

        public Customer(int id , string name)
            : this(id) //Means the constructor that accepts the id arguement will be called first before executing this constructor.
        {
            this.Name = name;
        }

    }
}
