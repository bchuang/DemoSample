using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Models.Base
{
    public class ServiceResult : ResultInfo
    {
        /// <summary> 成功 </summary>
        /// <returns></returns>
        public static ServiceResult Ok()
        {
            return new ServiceResult()
            {
                IsOk = true
            };
        }

        /// <summary> 失敗 </summary>
        /// <param name="message"></param>
        /// <param name="messageDetail"></param>
        /// <returns></returns>
        public static ServiceResult Error(string message, IEnumerable<MessageDetail> messageDetail = null)
        {
            return new ServiceResult()
            {
                IsOk = false,
                Message = message,
                MessageDetailList = messageDetail
            };
        }
    }

    public class ServiceResult<T> : ResultInfo
    {
        public T Data { get; set; }

        /// <summary> 成功 </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static ServiceResult<T> Ok(T data)
        {
            return new ServiceResult<T>()
            {
                IsOk = true,
                Data = data
            };
        }

        /// <summary> 失敗 </summary>
        /// <param name="message"></param>
        /// <param name="messageDetailList"></param>
        /// <returns></returns>
        public static ServiceResult<T> Error(string message, IEnumerable<MessageDetail> messageDetailList = null)
        {
            return new ServiceResult<T>()
            {
                IsOk = false,
                Message = message,
                MessageDetailList = messageDetailList
            };
        }
    }
}