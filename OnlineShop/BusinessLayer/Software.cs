using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class Software:Product
    {
        public string LicenseKey { get; set; }
        public Software():base()
        {

        }
    }
}
