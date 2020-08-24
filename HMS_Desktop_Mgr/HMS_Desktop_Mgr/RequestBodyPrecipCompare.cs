using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Desktop_Mgr
{
    class RequestBodyPrecipCompare : RequestBody
    {
        public string dataset { get; set; } = null;
        public string[] sourceList { get; set; } = null;
        public bool weighted = true;
        public double extremeDaily = 0;
        public double extremeTotal = 0;
    }
}
