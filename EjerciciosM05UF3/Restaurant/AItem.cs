namespace Restaurant
{
    public abstract class AItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool OnSpecial { get; set; }
        public int Quantity { get; set; }
        protected AItem(string? name, string? description, double price, bool onSpecial, int quantity)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.OnSpecial = onSpecial;
            this.Quantity = quantity;
        }

        public abstract void UpdateInventory(int quantyReceived);
    }
}
