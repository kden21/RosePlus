using RosePlus.Contracts.Enums;

namespace RosePlus.Contracts.ApiResult;

public class ApiResult<T>
{
    public T Data { get; set; }
    public bool IsSuccess { get; set; }

    public static ApiResult<T> SucessResult()
    {
        return new ApiResult<T>
        {
            IsSuccess = true
        };
    }
    
    public static ApiResult<T> SuccessResult(T data)
    {
        ApiResult<T> apiResult = new ApiResult<T>();
        
        apiResult.IsSuccess = true;
        apiResult.Data = data;

        return apiResult;
    }
}