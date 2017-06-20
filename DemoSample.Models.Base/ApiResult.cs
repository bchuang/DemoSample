using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Models.Base
{
    public class ApiResult : ResultInfo
    {
    }

    public class ApiResult<T> : ResultInfo
    {
        public T Data { get; set; }
    }
}