namespace CRUD_Operation.Features.Product.Command.Validators
{
    public class CreateProductValidator : AbstractValidator<ProductDto>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Product name is required");

            RuleFor(x => x.CategoryId)
               .NotEmpty()
               .WithMessage("CategoryId is required");
        }
    }
}
