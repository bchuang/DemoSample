using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Models.Base.Utility
{
    /// <summary></summary>
    public class AutoMapSetting : AutoMapTool
    {
        private static AutoMapSetting singleInstance;

        /// <summary> Singleton </summary>
        /// <returns></returns>
        public static AutoMapTool CreateInstance()
        {
            if (singleInstance == null)
                singleInstance = new AutoMapSetting();

            return singleInstance;
        }

        protected AutoMapSetting() : base()
        {
        }

        /// <summary> AutoMapper所需的Config </summary>
        /// <returns></returns>
        protected override MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ApiResult, ServiceResult>();
                cfg.CreateMap(typeof(ApiResult<>), typeof(ServiceResult<>));
            });
        }
    }
}