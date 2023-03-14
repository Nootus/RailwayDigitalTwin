﻿#pragma warning disable CS8618
namespace Rail.DigitalTwin.Core.Models
{
    public class DeviceModel
    {
        public DeviceModel(string deviceID, int timeElapsed, double latitude, double longitude) 
        { 
            DeviceID = deviceID;
            TimeElapsed = timeElapsed;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string DeviceID { get; set; }
        public int TimeElapsed { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
#pragma warning restore CS8618
