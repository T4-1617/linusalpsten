using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift0920_01
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNr { get; set; }
        public string fullName { get { return string.Format("{0} {1}", firstName, lastName); } }
    }

    public class Customer : Person
    {
        public int customerID { get; set; }
    }

    public class Employee : Person
    {
        public int employeeNr { get; set; }
        public string title { get; set; }
        public int salary { get; set; }
    }

    public class SupplyContact : Person
    {
        public string company { get; set; }
    }
}
