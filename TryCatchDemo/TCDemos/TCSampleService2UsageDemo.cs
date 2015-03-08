using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TryCatchDemo
{
    public class TCSampleService2UsageDemo
    {
        public void CallSample2_Test()
        {
            var sampleProxy = new TCSampleService2Proxy();
            var ds = new DataSet();

            sampleProxy.Update1(ds);
        }
    }
}
