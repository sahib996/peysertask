namespace MultiShop.Models
{
    public class BaseEntity
    { 
        public int ID { get; set; }
        public bool IdDeleted { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
