using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Desktop_Mgr
{
    class Globals
    {
        public enum moduleList { Precipitation,Air_Temperature,Relative_Humidity,Dew_Point,Solar_Radiation,Wind,Surface_Runoff,Subsurface_Flow,Soil_Moisture,Evapotranspiration };
        public enum runoffAndFlowAlgorithms { nldas,gldas,curvenumber }
        public enum evapotranspirationAlgorithms { nldas,gldas,hamon,penmandaily,hargreaves }
        public enum everyAOI { LatitudeLongitude,COMID,NCEI_Station };
        public enum pointAndCOMIDAOI { LatitudeLongitude,COMID }
        public enum streamflowAOI { COMID,HucID }
        public enum precipSources { nldas,gldas,daymet,wgen,prism,ncei,trmm }
        public enum temperatureSources { nldas,gldas,daymet,prism,ncei }
        public enum relHumiditySources { prism }
        public enum solarRadiationSources { nldas,gldas,daymet }
        public enum windSources { nldas,gldas,ncei }
        public enum soilMoistureSources { nldas,gldas }
        public enum evapotranspirationSources { nldas,daymet }
       
        public enum OutputFormat {E,E0,E1,E2,E3,e,e0,e1,e2,e3,F,F0,F1,F2,F3,G,G0,G1,G2,G3,N,N0,N1,N2,N3,R}
        public enum TimeZone { Local, GMT};
        public enum TemporalResolution {hourly,threeHourly,daily,weekly,monthly}
        public enum TemporalResolutionMoDaily { daily,monthly }
        public enum TemporalResultionDaily { daily }
        public enum LayerDepth { From0To10,From10To40,From40To100,From100To200,From0To100,From0To200}
        public enum StreamHydrologyAlgorithms { constant,changing,kinematic }

        //Development Server
        public static string baseURL = @"https://ceamdev.ceeopdev.net/hms/rest/api/";
        //Staging Server 
        //public static string baseURL = @"https://ceamstg.ceeopdev.net/hms/rest/api/";

        public static string precipitaionURL = @"meteorology/precipitation/";
        public static string temperatureURL = @"hydrology/temperature/";
        public static string relHumidityURL = @"meteorology/humidity/";
        public static string dewPointURL = @"meteorology/dewpoint/";
        public static string solarRadiationURL = @"meteorology/radiation/";
        public static string windURL = @"meteorology/wind/";
        public static string surfaceRunoffURL = @"hydrology/surfacerunoff/";
        public static string subsurfaceFlowURL = @"hydrology/subsurfaceflow/";
        public static string soilMoistureURL = @"hydrology/soilmoisture/";
        public static string evapotranspirationURL = @"hydrology/evapotranspiration/";
        public static string precipExtractURL = @"workflow/precip_data_extraction/";
        public static string streamflowURL = @"workflow/watershed/";
    }
}
