namespace CRUD_Operation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<ProductsEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsEntity>()
                .HasOne<CategoryEntity>(s => s.Category)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.CategoryId);

            base.OnModelCreating(modelBuilder);  
        }
    }
}
