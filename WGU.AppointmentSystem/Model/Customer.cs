using System;

namespace WGU.AppointmentSystem.Model
{
    public class Customer
    {
        public int CUSTOMERID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public int ADDRESSID { get; set; }
        public byte ACTIVE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime LASTUPDATED { get; set; }
        public string LASTUPDATEDBY { get; set; }

        public Customer(int customerId, string customerName, int addressId, int active, DateTime createDate, string createdBy, DateTime lastUpdated, string lastUpdateBy)
        {
            CUSTOMERID = customerId;
            CUSTOMERNAME = customerName;
            ADDRESSID = addressId;
            ACTIVE = (byte)active;
            CREATEDDATE = createDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdateBy;
        }

        public Customer(string customerName, int addressId, int active, DateTime createdDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy)
        {
            CUSTOMERNAME = customerName;
            ADDRESSID = addressId;
            ACTIVE = (byte)active;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }
    }
}
