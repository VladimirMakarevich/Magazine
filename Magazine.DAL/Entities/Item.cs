using System.ComponentModel.DataAnnotations;

namespace Magazine.DAL.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
