namespace Module2HW2
{
    public class Starter
    {
        private readonly Store _store;
        public Starter()
        {
            _store = new Store();
        }
        public void Run()
        {
            int choice = 0;
            _store.Init();
            do
            {
                Console.WriteLine("1. View products\n2. Buy products\n3. Make order\n4. Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        _store.StoreManager.Show(_store.Products);
                        Return();
                        break;
                    case 2:
                        Console.Clear();
                        _store.StoreManager.Buy(_store.Products);
                        Return();
                        break;
                    case 3:
                        Console.Clear();
                        _store.StoreManager.Cart.CartManager.MakeOrder(_store.StoreManager.Cart);
                        Return();
                        break;
                }
            } while (choice != 4);
        }
        private void Return()
        {
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
