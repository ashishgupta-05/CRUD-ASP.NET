using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTestAssignment2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Category CategoryName { get; set; }
    }
}
