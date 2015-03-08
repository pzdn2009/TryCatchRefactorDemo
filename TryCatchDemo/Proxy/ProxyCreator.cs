using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace TryCatchDemo
{
    public class ProxyCreator
    {
        public static T CreateServiceProxy<T>() where T : class
        {
            ProxyGenerator generator = new ProxyGenerator();
            ServiceDynamicProxyInterceptor interceptor = new ServiceDynamicProxyInterceptor();
            T entity = generator.CreateClassProxy<T>(interceptor);
            return entity;
        }
    }
}
