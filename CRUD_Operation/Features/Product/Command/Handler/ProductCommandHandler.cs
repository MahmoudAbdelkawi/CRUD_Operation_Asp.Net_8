namespace CRUD_Operation.Features.Category.Command.Handler
{
    public class ProductCommandHandler : IRequestHandler<ProductDto, Response>,
        IRequestHandler<UpdateProductDto, Response>,
        IRequestHandler<DeleteProductDto, Response>
    {
        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;
        public ProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Response> Handle(ProductDto request, CancellationToken cancellationToken)
        {
            // mapping
            var product = _mapper.Map<ProductsEntity>(request);

            // call create repository
            await _productRepository.Create(product);

            return new Response
            {
                Data = product,
                Message = "Product created successfully",
                Status = true
            };
        }

        public async Task<Response> Handle(UpdateProductDto request, CancellationToken cancellationToken)
        {
            var product = _productRepository.GetById(request.Id);

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
                var oldProduct = await _mapper.Map(request, product);
                await _productRepository.Update(oldProduct);

                return new Response
                {
                    Data = product,
                    Message = "Product updated successfully",
                    Status = true
                };

            }
        }

        public async Task<Response> Handle(DeleteProductDto request, CancellationToken cancellationToken)
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
                _productRepository.Delete(product);
                return new Response
                {
                    Data = product,
                    Message = "Product deleted successfully",
                    Status = true
                };
            }
        }
    }
}
