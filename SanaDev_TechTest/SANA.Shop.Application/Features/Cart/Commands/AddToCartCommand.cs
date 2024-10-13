using MediatR;
using SANA.Shop.Application.Common.Dtos.Responses;
using SANA.Shop.Application.Features.Cart.Dtos.Requests;

namespace SANA.Shop.Application.Features.Cart.Commands
{
    public sealed record AddToCartCommand(AddToCartRequest AddToCartRequest) : IRequest<BaseResponse>;
}
