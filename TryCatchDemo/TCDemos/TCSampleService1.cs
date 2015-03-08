using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;

namespace TryCatchDemo
{
    public class TCSampleService1 : IContract
    {
        public bool Update1(DataSet ds)
        {
            return TrycatchBlock(() =>
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
            });
        }

        public bool Update2(DataSet ds)
        {
            return TrycatchBlock(() =>
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
            });
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

        //try-catch控制块
        /// <summary>
        /// 将try-Catch提取成为一个函数，则可以共用
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        private bool TrycatchBlock(Func<bool> body)
        {
            try
            {
                return body();
            }
            catch (Exception ex)
            {
                //Logger.Log(ex);
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
