namespace CRUD_Operation.Features.Category.Query.Models
{
    public class GetProductByIdDto : IRequest<Response>
    {
        public int Id { get; set; }
    }
}
