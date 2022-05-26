namespace Store.Domain.StoreContext.Entities
{
    public class Product
    {
        public Product(string tittle, string description, string image, decimal price, decimal quantityOnHand)
        {
            Tittle = tittle;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public string Tittle { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public decimal QuantityOnHand { get; private set; }

        public override string ToString()
        {
            return Tittle;
        }

        public void DecreaseQuantity(decimal quantity)
        {
            QuantityOnHand -= quantity;
        }
    }
}
