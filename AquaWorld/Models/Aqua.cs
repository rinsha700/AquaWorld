using System.ComponentModel.DataAnnotations;

namespace AquaWorld.Models
{
    public class Aqua
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string PhoneNumber { get; set; }
    }
}
