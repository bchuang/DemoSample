using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator;

namespace DemoSample.Framework.TestDataGenerator
{
    public class GeneratorHelper
    {
        //TODO 優化 TestData 直接存取File
        public T MakeClassData<T>(T data)
        {
            Catalog catalog = new Catalog();
            return catalog.CreateInstance<T>();
        }
    }
}