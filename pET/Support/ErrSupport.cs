using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pET.Support
{
    enum Err
    {
        SUCCESSFULL, FAILURE,
        EXIST, DOESTEXIST, NULL
    }
    internal class ErrSupport
    {
        public static string log(Err eve)
        {
            switch (eve)
            {
                case Err.SUCCESSFULL:
                    return "Thành Công!";
                case Err.FAILURE:
                    return "Thất Bại!";
                case Err.EXIST:
                    return "Mã Tồn Tại!";
                case Err.DOESTEXIST:
                    return "Không Tồn Tại!";
                case Err.NULL:
                    return "Danh Sách Trống!";
                default: return "";

            }
        }
    }
}
