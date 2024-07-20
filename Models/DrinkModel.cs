namespace FileHandler.Models
{
    public class Ingredients
    {
        public double Coffee { get; set; }
        public string Milk { get; set; }
        public double Sugar { get; set; }
        public Ingredients()
        {
            
        }
    }

    public class DrinkModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Ingredients Ingredients { get; set; }

        public DrinkModel()
        {
            // for serialization by xmlserializer
        }

        public DrinkModel(
                string name,
                double price,
                double coffee,
                string milk,
                double sugar
            )
        {
            Name = name;
            Price = price;
            Ingredients = new Ingredients
            {
                Coffee = coffee,
                Milk = milk,
                Sugar = sugar
            };
        }
    }
}
