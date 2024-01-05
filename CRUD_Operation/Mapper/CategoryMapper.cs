namespace CRUD_Operation.Mapper
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<CategoryDto, CategoryEntity>()
                .ReverseMap();

            CreateMap<UpdateCategoryDto, CategoryEntity>()
                .ReverseMap();
        }
    }
}
