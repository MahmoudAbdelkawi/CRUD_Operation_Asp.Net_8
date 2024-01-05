namespace CRUD_Operation.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductDto, ProductsEntity>()
                .ReverseMap();

            CreateMap<UpdateProductDto, ProductsEntity>()
                .ReverseMap();

        }
    }
}
