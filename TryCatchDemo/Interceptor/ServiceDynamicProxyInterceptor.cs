using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace TryCatchDemo
{
    public class ServiceDynamicProxyInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            //将try - catch移动到这里，统一管理
            try
            {
                //调用原方法
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                //设置方法的返回值
                invocation.ReturnValue = false;
            }
        }
    }
}
