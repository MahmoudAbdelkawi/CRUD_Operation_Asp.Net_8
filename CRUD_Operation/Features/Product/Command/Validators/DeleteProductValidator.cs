namespace CRUD_Operation.Features.Product.Command.Validators
{
    public class DeleteProductValidator : AbstractValidator<DeleteProductDto>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Product Id is required");
        }
    }
}
