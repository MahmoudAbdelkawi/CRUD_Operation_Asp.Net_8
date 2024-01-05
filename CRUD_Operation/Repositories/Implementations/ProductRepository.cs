namespace CRUD_Operation.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<ProductsEntity>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
