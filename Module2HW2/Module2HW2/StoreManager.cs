namespace Module2HW2
{
    public class StoreManager
    {
        public Cart? Cart { get; private set; }
        public StoreManager()
        {
            Cart = new Cart();
        }
        public void Show(Product[] products)
        {
            Console.WriteLine(string.Format("{0, -3} {1, -11} {2, -3}", "ID", "Name", "Price"));
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(string.Format("{0, -3} {1, -11} {2, -3}", products[i].ID, products[i].Name, products[i].Price));
            }
        }
        public void Buy(Product[] products)
        {
            Product? product = null;
            int id, count, price = 0, j = 0;
            string continue_ = string.Empty;
            (Product product, int count)[] cartProducts = new (Product product, int count)[10];
            Show(products);
            Console.WriteLine();
            do
            {
                Console.Write("Enter product id: ");
                id = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].ID == id)
                    {
                        product = products[i];
                        break;
                    }
                }
                if (product is not null)
                {
                    Console.Write("Enter amount: ");
                    count = Convert.ToInt32(Console.ReadLine());
                    cartProducts[j] = (product, count);
                    price += product.Price * count;
                }
                else
                {
                    Console.WriteLine("Product not found");
                    j--;
                }
                if (j < 10)
                {
                    Console.Write("Continue? (y/n): ");
                    continue_ = Console.ReadLine().ToLower();
                    j++;
                }
            } while (continue_ == "y");
            Console.WriteLine("Products have been added to your cart");
            Cart = new Cart(cartProducts, price, j);
        }
    }
}
