using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HMS_Desktop_Mgr
{
    class RequestBody
    {
        private string requestURL = Globals.baseURL;
        public bool relative { get; set; } = false;
        public string precipSource { get; set; } = null;
        public string algorithm { get; set; } = null;
        public string source { get; set; } = null;
        public DateTimeSpan dateTimeSpan { get; set; } = new DateTimeSpan();
        public Geometry geometry { get; set; } = new Geometry();
        public string dataValueFormat { get; set; } = null;
        public string temporalResolution { get; set; } = null;
        public bool timeLocalized { get; set; } = false;
        public string[] layers { get; set; } = null;
        public string units { get; set; } = "metric";
        public string outputFormat { get; set; } = "json";
        public string baseURL { get; set; } = null;
        public string inputTimeSeries { get; set; } = null;
        public double albedo { get; set; } = 0.0;
    }


    class DateTimeSpan
    {
        public string startDate { get; set; } = null;
        public string endDate { get; set; } = null;
        public string dateTimeFormat { get; set; } = null;
    }

    class Geometry
    {
        public string description { get; set; } = null;
        public int comID { get; set; } = 0;
        public string hucID { get; set; } = null;
        public string stationID { get; set; } = null;
        public Point point { get; set; } = new Point();
        public string geometryMetadata { get; set; } = null;
        public string timezone { get; set; } = null;
    }

    class Point
    {
        public double latitude { get; set; } = 0.0;
        public double longitude { get; set; } = 0.0;
    }
    
}


