using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter01
{
    class Fax
    {
        public int FaxErrorNumber { get; set; }
        public string FaxErrorDescription { get; set; }

        public string Send()
        {
            return "Hata Kodu: " + FaxErrorNumber + " Hata Açıklaması: " + FaxErrorDescription;
        }
    }
}
