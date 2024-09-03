namespace SunPiontOfSaleFinalProject.Entiteis.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public OrderHeader? order { get; set; }
        public int productId { get; set; }
        public Product? product { get; set; }
        public double QTY { get; set; }
        public double Price { get; set; }
        public double? Descount { get; set; }
    }
}
