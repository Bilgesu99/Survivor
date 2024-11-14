using System.Collections.Generic;

namespace Survivor.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }  // Kategori adı
        public ICollection<Competitor> Competitors { get; set; }  // Bu kategoriye ait yarışmacılar
    }
}
