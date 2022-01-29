using System;

namespace WGU.AppointmentSystem.Model
{
    public class Appointment
    {
        public int APPOINTMENTID { get; set; }
        public int CUSTOMERID { get; set; }
        public int USERID { get; set; }
        public string TYPE { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime LASTUPDATED { get; set; }
        public string LASTUPDATEDBY { get; set; }
        private static int count = 0;

        public Appointment(int appointmentId, int customerId, int userId, string type, DateTime start, DateTime end, DateTime createddate, string createdby, DateTime lastUpdated, string lastUpdatedBy)
        {
            APPOINTMENTID = appointmentId;
            if (appointmentId > count)
            {
                count = appointmentId;
            }
            CUSTOMERID = customerId;
            USERID = userId;
            TYPE = type;
            STARTDATE = start;
            ENDDATE = end;
            CREATEDDATE = createddate;
            CREATEDBY = createdby;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }

        public Appointment(int customerId, int userId, string type, DateTime start, DateTime end, DateTime createddate, string createdby, DateTime lastUpdated, string lastUpdatedBy)
        {
            count++;
            APPOINTMENTID = count;
            CUSTOMERID = customerId;
            USERID = userId;
            TYPE = type;
            STARTDATE = start;
            ENDDATE = end;
            CREATEDDATE = createddate;
            CREATEDBY = createdby;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }
    }
}
