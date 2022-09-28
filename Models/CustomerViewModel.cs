using System.Collections.Generic;

namespace mvc_assignment_dorien.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public List<CustomerOrder> Orders { get; set; }
    }
}
