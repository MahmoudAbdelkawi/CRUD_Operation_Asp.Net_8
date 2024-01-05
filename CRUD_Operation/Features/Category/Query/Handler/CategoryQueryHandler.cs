namespace CRUD_Operation.Features.Category.Query.Handler
{
    public class CategoryQueryHandler :
        IRequestHandler<GetCategoryById, Response>,
        IRequestHandler<GetAllCategoryDto, Response>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetAllCategoryDto request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetAll();
            return new Response
            {
                StatusCode = HttpStatusCode.OK,
                Data = categories,
                Message = "Categories retrieved successfully",
                Status = true
            };
        }

        public async Task<Response> Handle(GetCategoryById request, CancellationToken cancellationToken)
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

            return new Response
            {
                StatusCode = HttpStatusCode.OK,
                Data = category,
                Message = "Category retrieved successfully",
                Status = true
            };
        }
    }
}
