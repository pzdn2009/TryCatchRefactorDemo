using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TryCatchDemo
{
    public class TCSampleService2 : IContract
    {
        ///这里不用try- catch，交给 ServiceDynamicProxyInterceptor去做即可。
        public bool Update1(DataSet ds)
        {
            var dt = ds.Tables[0];
            if (dt.Rows.Count == 0) return true;

            foreach (DataRow row in dt.Rows)
            {
                // 针对每一个row，都有相同的逻辑
                // 。。。
                // 。。。
                // 这里的代码估计很长，但是很相似，也可能出现未知的异常
                // 。。。
                // 。。。
            }
            return true;
        }

        public bool Update2(DataSet ds)
        {
            var dt = ds.Tables[0];
            if (dt.Rows.Count == 0) return true;

            foreach (DataRow row in dt.Rows)
            {
                // 针对每一个row，都有相同的逻辑
                // 。。。
                // 。。。
                // 这里的代码估计很长，但是很相似，也可能出现未知的异常
                // 。。。
                // 。。。
            }
            return true;
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
