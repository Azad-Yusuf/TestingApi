namespace Workspace
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // Add other properties relevant to a customer

        // Navigation properties
        public ICollection<Order> Orders { get; set; }
    }
}
