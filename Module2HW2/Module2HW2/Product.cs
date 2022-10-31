namespace Module2HW2
{
    public class Product
    {
        private static int idCount;
        public Product(string name, int price)
        {
            ID = ++idCount;
            Name = name;
            Price = price;
        }
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
    }
}
