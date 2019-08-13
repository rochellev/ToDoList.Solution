using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        // allow entity to lazy load
        public virtual ApplicationUser User { get; set; }
    }
}