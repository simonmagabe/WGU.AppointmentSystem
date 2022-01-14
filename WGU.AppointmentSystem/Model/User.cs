using System;

namespace WGU.AppointmentSystem.Model
{
    public class User
    {
        public int USERID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public byte ACTIVE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public DateTime LASTUPDATED { get; set; }
        public string LASTUPDATEDBY { get; set; }

        public User(int userId, string username, string password, int active, DateTime createdDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy)
        {
            USERID = userId;
            USERNAME = username;
            PASSWORD = password;
            ACTIVE = (byte)active;
            CREATEDDATE = createdDate;
            CREATEDBY = createdBy;
            LASTUPDATED = lastUpdated;
            LASTUPDATEDBY = lastUpdatedBy;
        }
    }
}
