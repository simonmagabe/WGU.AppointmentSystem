using System;

namespace WGU.AppointmentSystem.Model
{
    public class Customer
    {
        public virtual int CUSTOMERID { get; set; }
        public virtual string CUSTOMERNAME { get; set; }
        public virtual int ADDRESSID { get; set; }
        public virtual byte ACTIVE { get; set; }
        public virtual DateTime CREATEDDATE { get; set; }
        public virtual string CREATEDBY { get; set; }
        public virtual DateTime LASTUPDATED { get; set; }
        public virtual string LASTUPDATEDBY { get; set; }
        private static int count = 0;

        public Customer(int customerId, string customerName, int addressId, int active, DateTime createDate, string createdBy, DateTime lastUpdated, string lastUpdateBy)
        {
            CUSTOMERID = customerId;
            count = customerId;
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
            count++;
            CUSTOMERID = count;
            CUSTOMERNAME = customerName;
            ADDRESSID = addressId;
            ACTIVE = (byte)active;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }

        public Customer()
        {

        }
    }
}
