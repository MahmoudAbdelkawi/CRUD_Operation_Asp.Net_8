namespace CRUD_Operation.Features.Category.Query.Handler
{
    public class ProductQueryHandler : 
        IRequestHandler<GetAllProductsDto, Response>, 
        IRequestHandler<GetProductByIdDto, Response>
    {
        private readonly IProductRepository _productRepository;

        public ProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Response> Handle(GetAllProductsDto request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAll();

            return new Response
            {
                Data = products,
                Message = "Products retrieved successfully",
                Status = true
            };
        }

        public async Task<Response> Handle(GetProductByIdDto request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(request.Id);
            if (product == null)
            {
                return new Response
                {
                    Message = $"Product with id {request.Id} not found",
                    Status = false,
                };
            }
            else
            {
                return new Response
                {
                    Data = product,
                    Message = "Product retrieved successfully",
                    Status = true
                };
            }
        }
    }
}
