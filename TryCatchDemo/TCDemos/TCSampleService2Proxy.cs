using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TryCatchDemo
{
    /// <summary>
    /// 因为对Sample2进行了拦截，所有使用的时候使用此类即可。此类的功能就是一个经纪人——代理，帮Sample2打工的。
    /// </summary>
    public class TCSampleService2Proxy : IContract
    {
        private TCSampleService2 sample2;
        public TCSampleService2Proxy()
        {
            //表示将sample1进行代理（Proxy），然后就可以通过ServiceDynamicProxyInterceptor的Intercept方法进行拦截，为AOP编程思想的体现。
            sample2 = ProxyCreator.CreateServiceProxy<TCSampleService2>();
        }
        public bool Update1(DataSet ds)
        {
            return sample2.Update1(ds);
        }

        public bool Update2(DataSet ds)
        {
            return sample2.Update2(ds);
        }

        public bool Update3(DataSet ds)
        {
            throw new NotImplementedException();
        }

        public bool Update4(DataSet ds)
        {
            throw new NotImplementedException();
        }

        public bool Update5(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}
