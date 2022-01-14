using System;

namespace WGU.AppointmentSystem.Model
{
    public class Address
    {
        public int ADDRESSID { get; set; }
        public string STREET1 { get; set; }
        public string STREET2 { get; set; }
        public int CITYID { get; set; }
        public string ZIPCODE { get; set; }
        public string PHONE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime LASTUPDATED { get; set; }
        public string LASTUPDATEDBY { get; set; }

        public Address(int addressId, string street1, string street2, int cityId, string zipCode, string phone, DateTime createdDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy)
        {
            ADDRESSID = addressId;
            STREET1 = street1;
            STREET2 = street2;
            CITYID = cityId;
            ZIPCODE = zipCode;
            PHONE = phone;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }

        public Address(string street1, string street2, int cityId, string zipCode, string phone, DateTime createdDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy)
        {
            STREET1 = street1;
            STREET2 = street2;
            CITYID = cityId;
            ZIPCODE = zipCode;
            PHONE = phone;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }
    }
}
