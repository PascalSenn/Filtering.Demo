using System.ComponentModel.DataAnnotations;

namespace Filtering.Demo
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }
}