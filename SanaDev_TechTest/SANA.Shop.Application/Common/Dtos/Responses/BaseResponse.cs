namespace SANA.Shop.Application.Common.Dtos.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string ResultCode { get; set; }
        public string Message { get; set; }
    }
}
