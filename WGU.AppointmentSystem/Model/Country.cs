using System;

namespace WGU.AppointmentSystem.Model
{
    public class Country
    {
        public int COUNTRYID { get; set; }
        public string COUNTRYNAME { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime LASTUPDATED { get; set; }
        public string LASTUPDATEDBY { get; set; }

        public Country(int countryId, string countryName, DateTime createdDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy)
        {
            COUNTRYID = countryId;
            COUNTRYNAME = countryName;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }
    }
}
