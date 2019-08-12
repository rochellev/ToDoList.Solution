// class to hold info about the relationship between Category and Item
// Entity use this to create Join TAble
namespace ToDoList.Models
{
  public class CategoryItem
    {       
        public int CategoryItemId { get; set; }
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public Item Item { get; set; }
        public Category Category { get; set; }
    }
}