namespace CRUD_Operation.Features.Category.Command.Validators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Category Id is required");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Category name is required");
        }
    }
}
