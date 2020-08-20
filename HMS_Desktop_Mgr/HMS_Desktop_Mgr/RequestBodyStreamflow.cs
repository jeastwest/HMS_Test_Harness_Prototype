using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Desktop_Mgr
{
    class RequestBodyStreamflow : RequestBody
    {
        public string runoffSource { get; set; } = null;
        public string streamHydrology { get; set; } = null;
        public bool aggregation { get; set; } = false;
        public geometryMeta geometryMetadata { get; set; } = new geometryMeta();
    }

    class geometryMeta
    {
        public string precipSource { get; set; } = null;
    }
}
