namespace EShop.Orders.Core.Entities
{
    public class OrderItem : IEntityBase
    {
        public OrderItem(Guid id, Guid produtoId, int quatity, decimal price)
        {
            Id = id;
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
