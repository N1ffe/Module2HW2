namespace Module2HW2
{
    public class Cart
    {
        public Cart()
        {
            Products = new (Product product, int count)[10];
            TotalPrice = 0;
            Length = 0;
            CartManager = new CartManager();
        }
        public Cart((Product product, int count)[] products, int totalPrice, int length)
            : this()
        {
            Products = products;
            TotalPrice = totalPrice;
            Length = length;
        }
        public (Product product, int count)[] Products { get; set; }
        public int TotalPrice { get; set; }
        public int Length { get; set; }
        public CartManager CartManager { get; private set; }
    }
}
