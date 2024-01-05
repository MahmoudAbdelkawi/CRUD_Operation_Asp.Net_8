namespace CRUD_Operation.Features.Category.Command.Handler
{
    public class CategoryCommandHandler :
        IRequestHandler<CategoryDto, Response>,
        IRequestHandler<UpdateCategoryDto, Response>,
        IRequestHandler<DeleteCategoryDto, Response>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Response> Handle(CategoryDto request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<CategoryEntity>(request);

            await _categoryRepository.Create(category);

            return new Response
            {
                StatusCode = HttpStatusCode.OK,
                Data = category,
                Message = "Category created successfully",
                Status = true
            };
        }

        public async Task<Response> Handle(UpdateCategoryDto request, CancellationToken cancellationToken)
        {

            var category = await _categoryRepository.GetById(request.Id);

            if (category == null)
            {
                return new Response
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = $"Category with id {request.Id} not found",
                    Status = false,
                };
            }

            var newCategory = _mapper.Map(request, category);

            await _categoryRepository.Update(newCategory);

            return new Response
            {
                StatusCode = HttpStatusCode.OK,
                Data = newCategory,
                Message = "Category updated successfully",
                Status = true
            };
        }

        public async Task<Response> Handle(DeleteCategoryDto request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetById(request.Id);
            if (category == null)
            {
                return new Response
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = $"Category with id {request.Id} not found",
                    Status = false,
                };
            }

            _categoryRepository.Delete(category);


            return new Response
            {
                StatusCode = HttpStatusCode.NoContent,
                Message = "Category deleted successfully",
                Status = true
            };
        }
    }
}
