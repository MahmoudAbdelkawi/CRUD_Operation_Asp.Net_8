namespace CRUD_Operation.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductsEntity>
    {
        public void Configure(EntityTypeBuilder<ProductsEntity> builder)
        {
            builder
                .HasOne<CategoryEntity>(s => s.Category)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.CategoryId);
        }
    }
}
