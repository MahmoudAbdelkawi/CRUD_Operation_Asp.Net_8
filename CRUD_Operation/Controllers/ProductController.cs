namespace CRUD_Operation.Controllers
{
    public class ProductController : BaseController
    {

        // Create Product
        [HttpPost(Router.ProductRouter.Main)]
        public async Task<IActionResult> Create(ProductDto productDto)
        {
            var result = await mediator.Send(productDto);
            return Result(result);
        }

        // Update Product
        [HttpPut(Router.ProductRouter.MainId)]
        public async Task<IActionResult> Update(UpdateProductDto updateProductDto)
        {
            var result = await mediator.Send(updateProductDto);
            return Result(result);
        }


        // Delete Product
        [HttpDelete(Router.ProductRouter.MainId)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await mediator.Send(new DeleteProductDto { Id = id });
            return Result(result);
        }

        // Get All Product
        [HttpGet(Router.ProductRouter.Main)]
        public async Task<IActionResult> All()
        {
            var result = await mediator.Send(new GetAllProductsDto());
            return Result(result);
        }

        // Get Product By Id
        [HttpGet(Router.ProductRouter.MainId)] // query  ?id=1
        public async Task<IActionResult> GetById(int id)
        {
            var result = await mediator.Send(new GetProductByIdDto { Id = id });
            return Result(result);
        }
    }
}
