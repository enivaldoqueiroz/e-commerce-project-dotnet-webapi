namespace EShop.Orders.Core.Entities
{
    public class OrderItem : IEntityBase
    {
        public OrderItem(Guid produtoId, int quatity, decimal price)
        {
            Id = Guid.NewGuid();
            ProdutoId = produtoId;
            Quatity = quatity;
            Price = price;
        }

        public Guid Id { get; private set; }
        public Guid ProdutoId { get; private set; }
        public int Quatity { get; private set; }
        public decimal Price { get; set; }
    }
}
