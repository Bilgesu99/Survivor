namespace Survivor.Models
{
    public class Competitor : BaseEntity
    {
        public string Name { get; set; }  // Yarışmacı adı
        public int Age { get; set; }  // Yarışmacı yaşı

        // Foreign Key - Category'yi temsil eder
        public int CategoryId { get; set; }
        public Category Category { get; set; }  // Yarışmacının ait olduğu kategori
    }
}
