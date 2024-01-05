namespace CRUD_Operation.Features.Category.Command.Models
{
    public class DeleteCategoryDto : IRequest<Response>
    {
        public int Id { get; set; }
    }
}
