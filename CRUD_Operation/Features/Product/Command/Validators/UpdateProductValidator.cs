namespace CRUD_Operation.Features.Product.Command.Validators
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Product Id is required");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Product name is required");


            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithMessage("Product category is required");
        }
    }
}
