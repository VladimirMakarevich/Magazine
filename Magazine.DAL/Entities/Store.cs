using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magazine.DAL.Entities
{
    public class Store
    {
        public Store()
        {
            Items = new List<Item>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string StartWorkTime { get; set; }
        public string EndWorkTime { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
