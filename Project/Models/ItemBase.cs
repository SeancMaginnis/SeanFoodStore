namespace SeanFoodStore.Project.Models
{
    abstract class ItemBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price  { get; set; }
        public int Calories { get; set; }
        
        
        
        public ItemBase(string name, string description, float price, int calories)
        {
            Name = name;
            Description = description;
            Price = price;
            Calories = calories;
        }
    }
}