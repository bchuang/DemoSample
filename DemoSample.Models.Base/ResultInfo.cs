using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Models.Base
{
    public class ResultInfo
    {
        /// <summary> 狀態 </summary>
        public bool IsOk { get; set; }

        /// <summary> Log 識別碼 </summary>
        public Guid MessageId { get; set; }

        /// <summary> 錯誤碼(系統內部) </summary>
        public string ErrorCode { get; set; }

        /// <summary> 回傳代碼(系統外部) </summary>
        public string ResponseCode { get; set; }

        /// <summary> 顯示訊息 </summary>
        public string Message { get; set; }

        /// <summary> 擴充保留 </summary>
        public IEnumerable<MessageDetail> MessageDetailList { get; set; }
    }
}