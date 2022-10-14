using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
        public class Customer
        {
            public string Firstname { get; set; }
            public string lastName { get; set; }

          /*  public override bool Equals(object obj)
            {
                Customer otherCustomerObject = obj as Customer;
                if(otherCustomerObject == null)
                {
                    return false;
                }
                return
                       this.Firstname == otherCustomerObject.Firstname &&
                       this.lastName == otherCustomerObject.lastName;
            }

            public override int GetHashCode()
            {
                return this.Firstname.GetHashCode() ^ this.lastName.GetHashCode();
            }*/
        }
    public class GoldCustomer
    {
        
    }

    public class Employee
    {
        public int ID { get; set; }
    }
}
