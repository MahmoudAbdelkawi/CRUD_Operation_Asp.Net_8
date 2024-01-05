namespace CRUD_Operation.Features.Category.Query.Models
{
    public class GetCategoryById : IRequest<Response>
    {
        public int Id { get; set; }
    }
}
