using System;
using System.IO;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem.Logs
{
    public class UserActivity
    {
        protected static string logFileName = "LoginActivity.txt";
        private static bool activityLogFileExists = true;
        private static string existingActivityLogFile = "";

        public static void UserLoginActivity(User user)
        {
            try
            {
                FileStream fileStream = new FileStream(logFileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                existingActivityLogFile = streamReader.ReadToEnd().Trim();
                fileStream.Close();
            }
            catch (IOException)
            {
                activityLogFileExists = false;
            }
            finally
            {
                FileStream fileStream = new FileStream(logFileName, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                DateTime currentDateTime = DateTime.Now.ToUniversalTime();
                string activityLog = $"USER: [{ user.USERNAME }] Logged In On: [{ currentDateTime } UTC.]";

                if (activityLogFileExists)
                {
                    streamWriter.WriteLine(existingActivityLogFile);
                    streamWriter.WriteLine(activityLog);
                    streamWriter.Close();
                }
                else
                {
                    streamWriter.WriteLine(activityLog);
                    streamWriter.Close();
                }
            }
        }
    }
}
