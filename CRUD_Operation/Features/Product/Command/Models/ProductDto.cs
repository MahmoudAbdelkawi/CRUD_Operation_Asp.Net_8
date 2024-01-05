namespace CRUD_Operation.Features.Category.Command.Models
{
    public class ProductDto : IRequest<Response>
    {

        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
