using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Filtering.Demo
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Address? ShippingAddress { get; set; }

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}