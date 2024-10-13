using MediatR;
using SANA.Shop.Application.Common.Dtos.Responses;
using SANA.Shop.Domain.Repositories;

namespace SANA.Shop.Application.Features.Cart.Commands
{
    public class AddToCartCommandHandler : IRequestHandler<AddToCartCommand, BaseResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICartRepository _cartRepository;

        public AddToCartCommandHandler(IProductRepository productRepository, ICartRepository cartRepository)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
        }

        public async Task<BaseResponse> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.AddToCartRequest.ProductId);

            if (product == null || product.Stock < request.AddToCartRequest.Quantity)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Insufficient stock"
                };
            }

            await _cartRepository.AddToCartAsync(request.AddToCartRequest.CartId, product, request.AddToCartRequest.Quantity);

            return new BaseResponse
            {
                Success = true,
                Message = "Product added to cart successfully"
            };
        }
    }
}
