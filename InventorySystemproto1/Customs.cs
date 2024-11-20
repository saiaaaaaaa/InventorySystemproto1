namespace InventorySystemproto1
{
    public class Customs
    {
        public class InventoryItem
        {
            string brand, model, category;
            decimal price;
            int stock;

            public InventoryItem(string brand, string model, string category, decimal price, int stock)
            {
                this.brand = brand;
                this.model = model;
                this.category = category;
                this.price = price;
                this.stock = stock;
            }

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string Category
            {
                get { return category; }
                set { category = value; }
            }

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

            public int Stock
            {
                get { return stock; }
                set { stock = value; }
            }
        }
    }
}
