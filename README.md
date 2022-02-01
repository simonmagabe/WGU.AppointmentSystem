# WGU.AppointmentSystem
This is a SOFTWARE II - Advanced C# - 969 Project

REQUIREMENTS

A.   Create a log-in form that can determine the user’s location and translate log-in and error control messages (e.g., “The username and password did not match.”) into the user’s language and in one additional language.
	
	=> ViewModel (folder) -> FormLogin.cs
 
B.  Provide the ability to add, update, and delete customer records in the database, including name, address, and phone number. 

 	=> ViewModel (folder) -> FormCustomer.cs

C.   Provide the ability to add, update, and delete appointments, capturing the type of appointment and a link to the specific customer record in the database.

 	=> ViewModel (folder) -> FormAppointmentDashboard.cs
	=> ViewModel (folder) -> FormAddEditAppointment.cs

D.   Provide the ability to view the calendar by month and by week. 

 	=> ViewModel (folder) -> FormAppointmentDashboard.cs
	=> ViewModel (folder) -> FormAddEditAppointment.cs

E.   Provide the ability to automatically adjust appointment times based on user time zones and daylight-saving time.

 	=> ViewModel (folder) -> FormAddEditAppointment.cs

F.   Write exception controls to prevent each of the following. You may use the same mechanism of exception control more than once, but you must incorporate at least two different mechanisms of exception control.

•   scheduling an appointment outside business hours 	=> ViewModel (folder) -> FormAddEditAppointment.cs

•   scheduling overlapping appointments			=> ViewModel (folder) -> FormAddEditAppointment.cs

•   entering nonexistent or invalid customer data	=> ViewModel (folder) -> FormCustomerRecords.cs -> Phone Number accepts ONLY digits, minus(-), Decimal point(.) and a Plus(+).

•   entering an incorrect username and password		=> ViewModel (folder) -> FormLogin.cs 

G.  Write two or more lambda expressions to make your program more efficient, justifying the use of each lambda expression with an in-line comment.

 	=> ViewModel (folder) -> FormCustomerRecords.cs

H.  Write code to provide reminders and alerts 15 minutes in advance of an appointment, based on the user’s log-in.

 	=> ViewModel (folder) -> FormHomePage.cs

I.   Provide the ability to generate each of the following reports using the collection classes:

•   number of appointment types by month

•   the schedule for each consultant

•   one additional report of your choice
	
	=> ViewModel (folder) -> FormReportsDashboard.cs

J.   Provide the ability to track user activity by recording timestamps for user log-ins in a .txt file. Each new record should be appended to the log file if the file already exists.

 	=> Logs (folder) -> LoginActivity.cs

K.   Demonstrate professional communication in the content and presentation of your submission.
