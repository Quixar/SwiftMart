using SwiftMart.AddressEntity;
using SwiftMart.Status;
using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.OrderEntities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<ProductEntity.Product>? Products { get; set; } = new List<ProductEntity.Product>();
        public OrderStatus Status { get; set; }
        public Address? DeliveryAddress { get; set; }
        public DateOnly CreatedDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
