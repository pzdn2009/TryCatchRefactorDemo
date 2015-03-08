using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace TryCatchDemo
{
    public class TCSampleService3IOC
    {
        public static void IOC(IUnityContainer container)
        {
            var instance = ProxyCreator.CreateServiceProxy<TCSampleService3>();
            //放入一个冒牌货（已经被代理过的）
            container.RegisterInstance<TCSampleService3>(instance);
        }
    }
}
