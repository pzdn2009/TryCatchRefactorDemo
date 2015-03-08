using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TryCatchDemo
{
    public interface IContract
    {
        bool Update1(DataSet ds);
        bool Update2(DataSet ds);
        bool Update3(DataSet ds);
        bool Update4(DataSet ds);
        bool Update5(DataSet ds);
    }
}
