using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using SANA.Shop.Application.Common.Dtos.Responses;
using SANA.Shop.Application.Features.Cart.Commands;
using SANA.Shop.Application.Features.Cart.Dtos.Requests;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SANA.Shop.API.Functions.Cart
{
    public class AddToCartFunction
    {
        private readonly ILogger<AddToCartFunction> _logger;
        private readonly IMediator _mediator;

        public AddToCartFunction(ILogger<AddToCartFunction> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [FunctionName("AddToCart")]
        [OpenApiOperation(operationId: "Run", tags: ["Cart"])]
        [OpenApiRequestBody(contentType: "application/json", bodyType: typeof(AddToCartRequest), Description = "Request to add product to cart")]
        [OpenApiResponseWithBody(HttpStatusCode.OK, "application/json", typeof(BaseResponse), Description = "Add product to cart")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "cart/add")] HttpRequest req)
        {
            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var addToCartRequest = JsonConvert.DeserializeObject<AddToCartRequest>(requestBody);
            var response = await _mediator.Send(new AddToCartCommand(addToCartRequest));
            return new OkObjectResult(response);
        }
    }
}

