namespace Module2HW2
{
    public class CartManager
    {
        public void MakeOrder(Cart cart)
        {
            string phone, address;
            if (cart.Length > 0)
            {
                Console.Write("Enter your phone number: ");
                phone = Console.ReadLine();
                Console.Write("Enter delivery address: ");
                address = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Your order has been made. Details:\nPhone number: {phone}\nDelivery address: {address}\nProducts:");
                for (int i = 0; i < cart.Length; i++)
                {
                    Console.WriteLine(string.Format("{0, -10} {1, -2} x{2, -2}", cart.Products[i].product.Name, cart.Products[i].product.Price, cart.Products[i].count));
                }
                Console.WriteLine($"To pay: {cart.TotalPrice}");
                Array.Clear(cart.Products);
                cart.TotalPrice = 0;
                cart.Length = 0;
            }
            else
            {
                Console.WriteLine("Your cart is empty");
            }
        }
    }
}
