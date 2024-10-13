using FluentValidation;

namespace SANA.Shop.Application.Features.Cart.Commands
{
    public class AddToCartCommandValidator : AbstractValidator<AddToCartCommand>
    {
        public AddToCartCommandValidator()
        {
            RuleFor(c => c.AddToCartRequest.ProductId).GreaterThan(0).WithMessage("Product ID is required");
            RuleFor(c => c.AddToCartRequest.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0");
        }
    }
}
