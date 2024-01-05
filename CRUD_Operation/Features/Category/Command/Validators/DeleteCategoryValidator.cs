namespace CRUD_Operation.Features.Category.Command.Validators
{
    public class DeleteCategoryValidator : AbstractValidator<DeleteCategoryDto>
    {
        public DeleteCategoryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Category Id is required");
        }
    }
}
