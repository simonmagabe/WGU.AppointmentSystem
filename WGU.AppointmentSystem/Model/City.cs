using System;

namespace WGU.AppointmentSystem.Model
{
    public class City
    {
        public int CITYID { get; set; }
        public string CITYNAME { get; set; }
        public int COUNTRYID { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime LASTUPDATED { get; set; }
        public string LASTUPDATEDBY { get; set; }

        public City(int cityId, string cityName, int countryId, DateTime createdDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy)
        {
            CITYID = cityId;
            CITYNAME = cityName;
            COUNTRYID = countryId;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }
    }
}
