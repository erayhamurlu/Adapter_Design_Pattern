using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter01
{
    public interface IErrorModel
    {
        int ErrorNumber { get; set; }
        string ErrorDescription { get; set; }
        string SendMail();
    }
}
