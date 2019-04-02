namespace SeanFoodStore.Project.Models
{
    class Entree: ItemBase
    {
        public Entree(string name, string description, float price, int calories) : base(name, description, price, calories)
        {
        }
    }
}