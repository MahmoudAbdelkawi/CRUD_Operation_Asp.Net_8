namespace CRUD_Operation.Models
{
    public class ProductsEntity : BaseEntity
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}
