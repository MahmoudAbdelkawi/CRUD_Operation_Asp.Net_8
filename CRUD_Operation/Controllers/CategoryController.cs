namespace CRUD_Operation.Controllers
{
    public class CategoryController : BaseController
    {
        // Get All Category
        [HttpGet(Router.CategoryRouter.Main)]
        public async Task<IActionResult> All()
        {
            var result = await mediator.Send(new GetAllCategoryDto());
            return Result(result);
        }

        // Get Category By Id
        [HttpGet(Router.CategoryRouter.MainId)] // params  /:id
        public async Task<IActionResult> GetById(int id)
        {
            var result = await mediator.Send(new GetCategoryById { Id = id });
            return Result(result);
        }

        // Create Category
        [HttpPost(Router.CategoryRouter.Main)]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var result = await mediator.Send(categoryDto);
            return Result(result);
        }

        // Update Category
        [HttpPut(Router.CategoryRouter.MainId)]
        public async Task<IActionResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            var result = await mediator.Send(updateCategoryDto);
            return Result(result);
        }

        // Delete Category
        [HttpDelete(Router.CategoryRouter.MainId)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await mediator.Send(new DeleteCategoryDto { Id = id });
            return Result(result);
        }
    }
}
