using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpense
{
    class Allowance
    {
        private DateTime startDateAndTime;
        private DateTime returnDateAndTime;
        
        public DateTime StartDateAndTime
        {
            get { return startDateAndTime; }
            set { startDateAndTime = value; }
        }

        public DateTime  ReturnDateAndTime 
        {
            get { return returnDateAndTime; }
            set { returnDateAndTime = value; }
        }
        TimeSpan difference;

        public TimeSpan CalculateDays (DateTime startDate , DateTime returnDate, string startTime, string returnTime)
        { 
            DateTime sTime = DateTime.Parse(startTime); //start time in datetime format
            DateTime rTime = DateTime.Parse(returnTime);//return time in datetime format

            startDateAndTime = new DateTime(startDate.Year, startDate.Month, startDate.Day, sTime.Hour, sTime.Minute,sTime.Second);
            ReturnDateAndTime = new DateTime(returnDate.Year,returnDate.Month, returnDate.Day, rTime.Hour, rTime.Minute,rTime.Second);
            difference= ReturnDateAndTime-startDateAndTime;
            return difference;
        }               
                 
        
    }
}