using System.Diagnostics.Contracts;

namespace Workspace
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Customer> Customer { get; set; }

    }
}
