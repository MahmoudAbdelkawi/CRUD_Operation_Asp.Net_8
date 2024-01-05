namespace CRUD_Operation.Features.Category.Command.Models
{
    public class CategoryDto : IRequest<Response>
    {
        public string Name { get; set; }
    }
}
