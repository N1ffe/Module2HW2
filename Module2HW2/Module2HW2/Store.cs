namespace Module2HW2
{
    public class Store
    {
        public Store()
        {
            Products = new Product[10];
            StoreManager = new StoreManager();
        }
        public Product[] Products { get; private set; }
        public StoreManager StoreManager { get; private set; }
        public void Init()
        {
            Products[0] = new Product("Aquapirin", 6);
            Products[1] = new Product("Retagine", 4);
            Products[2] = new Product("Savelazine", 10);
            Products[3] = new Product("Nizozal", 2);
            Products[4] = new Product("Toletasol", 8);
            Products[5] = new Product("Pentomune", 4);
            Products[6] = new Product("Fexostone", 5);
            Products[7] = new Product("Pansate", 1);
            Products[8] = new Product("Invidosyn", 9);
            Products[9] = new Product("Tamolinum", 7);
        }
    }
}
