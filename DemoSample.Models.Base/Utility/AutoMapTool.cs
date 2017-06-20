using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Models.Base.Utility
{
    /// <summary> /// </summary>
    public abstract class AutoMapTool
    {
        protected IMapper mapper;

        protected AutoMapTool()
        {
            mapper = MapperConfiguration().CreateMapper();
        }

        protected abstract MapperConfiguration MapperConfiguration();

        /// <summary> Map from a source object to a new destination object </summary>
        /// <typeparam name="From"></typeparam>
        /// <typeparam name="To"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public To ConvertModel<From, To>(From source)
        {
            return this.mapper.Map<From, To>(source);
        }

        /// <summary> Map from a source object to a existing destination object </summary>
        /// <typeparam name="From"></typeparam>
        /// <typeparam name="To"></typeparam>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public To ConvertAndUpdateModel<From, To>(From source, To destination)
        {
            return this.mapper.Map<From, To>(source, destination);
        }
    }
}