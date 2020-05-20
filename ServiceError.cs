using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter01
{
    class ServiceError:IErrorModel
    {
        public int ErrorNumber { get; set; }
        public string ErrorDescription { get; set; }

        public string SendMail()
        {
            return "Hata Kodu: " + ErrorNumber + " Hata Mesajı: " + ErrorDescription;
        }
    }
}
