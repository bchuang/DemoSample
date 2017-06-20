using DemoSample.Models.Base.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Models.Base
{
    public class ResultConvertHelper
    {
        private static readonly AutoMapTool autoMapTool = AutoMapSetting.CreateInstance();

        public static ApiResult<T> ServiceResultToApiResult<T>(ServiceResult<T> serviceResult)
        {
            //return autoMapTool.ConvertModel<ServiceResult<T>, ApiResult<T>>(serviceResult);

            ApiResult<T> apiResult = new ApiResult<T>();
            apiResult.IsOk = serviceResult.IsOk;
            apiResult.ResponseCode = serviceResult.ErrorCode;
            apiResult.Message = serviceResult.Message;
            apiResult.MessageDetailList = serviceResult.MessageDetailList;
            apiResult.Data = serviceResult.Data;
            return apiResult;
        }

        public static ApiResult ServiceResultToApiResult(ServiceResult serviceResult)
        {
            //return autoMapTool.ConvertModel<ServiceResult, ApiResult>(serviceResult);

            ApiResult apiResult = new ApiResult();
            apiResult.IsOk = serviceResult.IsOk;
            apiResult.ResponseCode = serviceResult.ErrorCode;
            apiResult.Message = serviceResult.Message;
            apiResult.MessageDetailList = serviceResult.MessageDetailList;
            return apiResult;
        }
    }
}