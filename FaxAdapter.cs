using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter01
{
    class FaxAdapter : IErrorModel
    {
        Fax fax = new Fax ();
        
        public int ErrorNumber
        {
            get
            {
                return fax.FaxErrorNumber;
            }
            set
            {
                fax.FaxErrorNumber = value;
            }
        }

        public string ErrorDescription
        {
            get
            {
                return fax.FaxErrorDescription;
            }
            set
            {
                fax.FaxErrorDescription = value;
            }
        }

        public string SendMail()
        {
            return fax.Send();
        }

    }
}
