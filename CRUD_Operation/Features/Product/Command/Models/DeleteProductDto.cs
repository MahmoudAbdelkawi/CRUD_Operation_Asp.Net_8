namespace CRUD_Operation.Features.Category.Command.Models
{
    public class DeleteProductDto : IRequest<Response>
    {
        public int Id { get; set; }
    }
}
