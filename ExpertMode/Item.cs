namespace ExpertMode
{
    public class Item
    {
        public string Id{get; private set;}
        public string Name{get; private set;}
        public int Price{get; private set;}

        public Item(string id,string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}