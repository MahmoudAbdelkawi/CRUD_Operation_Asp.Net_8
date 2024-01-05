namespace CRUD_Operation.Models
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<ProductsEntity> Products { get; set; }
    }
}
