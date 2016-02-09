using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mengesha.Allowance2010
{
    /// <summary>
    /// Allowance Class
    /// </summary>
    public class Allowance
    {
        /// <summary>
        /// Finland's Fullday Allowacne
        /// </summary>
        public String FinFull;
        /// <summary>
        /// Finland's Halfday Allowance
        /// </summary>
        public String FinHalf;
        /// <summary>
        /// Finland's KM Allowance
        /// </summary>
        public String FinKm;
        /// <summary>
        /// Number of Person
        /// </summary>
        public String FinPerson;

        private DateTime startDateAndTime;
        private DateTime returnDateAndTime;
        /// <summary>
        /// Struct File to list contries and their corrosponding rates
        /// </summary>
        public struct County 
        {
            /// <summary>
            /// Set and Get Daily Allowance
            /// </summary>
            public int DailyAllowance { get; set; }
            /// <summary>
            /// Set and Get Country Name
            /// </summary>
            public string Name { get; set; }
        }

        List<County> countyList = new List<County>(3); // List of Country class 

        /// <summary>
        /// Work Trip Start time with method set and get time
        /// </summary>
        public DateTime StartDateAndTime
        {
            get { return startDateAndTime; }
            set { startDateAndTime = value; }
        }
        /// <summary>
        /// Work Trip Return time with method set and get time
        /// </summary>
        public DateTime  ReturnDateAndTime 
        {
            get { return returnDateAndTime; }
            set { returnDateAndTime = value; }
        }
        TimeSpan difference;

        /// <summary>
        /// Calculates days and hours difference between start and return day
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="returnDate"></param>
        /// <param name="startTime"></param>
        /// <param name="returnTime"></param>
        /// <returns></returns>
        public TimeSpan CalculateDays (DateTime startDate , DateTime returnDate, string startTime, string returnTime)
        { 
            DateTime sTime = DateTime.Parse(startTime); //start time in datetime format
            DateTime rTime = DateTime.Parse(returnTime);//return time in datetime format

            startDateAndTime = new DateTime(startDate.Year, startDate.Month, startDate.Day, sTime.Hour, sTime.Minute,sTime.Second);
            ReturnDateAndTime = new DateTime(returnDate.Year,returnDate.Month, returnDate.Day, rTime.Hour, rTime.Minute,rTime.Second);
            difference= ReturnDateAndTime-startDateAndTime;
            return difference;
        }
        /// <summary>
        /// Calculates KM Allowance
        /// </summary>
        /// <param name="kmDriven"></param>
        /// <param name="kmAllowancePerKm"></param>
        /// <param name="numberOfPersons"></param>
        /// <param name="kmAllowancePerPerson"></param>
        /// <returns></returns>
        public double KmAllowance(int kmDriven, double kmAllowancePerKm, int numberOfPersons, double kmAllowancePerPerson) 
        {
            double calculatedAllowance = 0;
            if (kmDriven <= 5000)
            {
                calculatedAllowance = kmDriven * (kmAllowancePerKm + kmAllowancePerPerson * numberOfPersons);
            }
            else if (kmDriven > 5000)
            {
                calculatedAllowance = (5000 * (kmAllowancePerKm + kmAllowancePerPerson * numberOfPersons)) + ((kmDriven - 
                5000) * (kmAllowancePerKm + kmAllowancePerPerson * numberOfPersons - 0.04));
            }
            return calculatedAllowance;

        }
        /// <summary>
        /// Calcuate Daily Allowance for Domestic Trip
        /// </summary>
        /// <param name="fullDay"></param>
        /// <param name="halfDay"></param>
        /// <returns></returns>
        public double CalculateDailyAllowance(double fullDay, double halfDay) 
        {
            int days = difference.Days;
            double dailyAllowance = 0;
            int totalMinutes = (difference.Hours * 60) + difference.Minutes;
            if (totalMinutes > 120 && totalMinutes <= 720) // if the total trip takes in betwee 8 and 12hrs
                    dailyAllowance = (days * fullDay) + halfDay;
            else if (totalMinutes > 720) // if the trip takes more than 12 hrs
                   dailyAllowance = (days * fullDay) + fullDay;
             else
                    dailyAllowance = days * fullDay;

            return dailyAllowance;
        }
        /// <summary>
        /// Calculates Abroad Allowance
        /// </summary>
        /// <param name="abroadAllowance"></param>
        /// <returns></returns>
        public double CalculateAllowanceAbroad(double abroadAllowance)
        { 
            double calculatedAboradAllowance = 0;
            int days = difference.Days;
            int totalMinutes = (difference.Hours * 60) + difference.Minutes;
            if (days == 0) //if the trip is done in 1 single day
            {
                if (totalMinutes > 480 && totalMinutes <= 720) // if the total trip takes in betwee 8 and 12hrs
                    calculatedAboradAllowance = (abroadAllowance/2); //halfday rate
                else if (totalMinutes > 720) // if the trip takes more than 12 hrs
                    calculatedAboradAllowance = abroadAllowance; // fullday rate
            }
            else 
            {
                if (totalMinutes > 120 && totalMinutes <= 720) // if the total trip takes in betwee 8 and 12hrs
                    calculatedAboradAllowance = (days * abroadAllowance) + (0.35 * abroadAllowance); // 35% of daily foreign allowance
                else if (totalMinutes > 720) // if the trip takes more than 12 hrs
                    calculatedAboradAllowance = (days * abroadAllowance) + (0.65 * abroadAllowance); //65% of daily foreign allowance
                else
                    calculatedAboradAllowance = days * abroadAllowance;
            }
            return calculatedAboradAllowance;
        }
        /// <summary>
        /// Read Countries and their corrosponding Daily Allowance
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<County> ReadCountiesAndDailyAllowances(string fileName)
        {
            string inputReader;
            string []splitArray = new string[2];
            County countires = new County();
            StreamReader io = new StreamReader(fileName);
            //Filtering manually the 1st 4 elements from the text file which are

            //Finland's Full day Allowance
            inputReader = io.ReadLine();
            splitArray = inputReader.Split(';');
            FinFull = splitArray[1];

            //Finland's half day allowance
            inputReader = io.ReadLine();
            splitArray = inputReader.Split(';');
            FinHalf = splitArray[1];

            //Finland's KM Allowance
            inputReader = io.ReadLine();
            splitArray = inputReader.Split(';');
            FinKm = splitArray[1];

            //Number of Persons Accompanying during the trip
            inputReader = io.ReadLine();
            splitArray = inputReader.Split(';');
            FinPerson = splitArray[1];


 
            inputReader = io.ReadLine();      
            while (inputReader != null)
            {
                splitArray = inputReader.Split(';');
                countires.Name = splitArray[0];
                countires.DailyAllowance = int.Parse(splitArray[1]);
                countyList.Add(countires);
                inputReader = io.ReadLine();
            }
            io.Close();
            return countyList; //Returns countries list with their corrosponding allowance value
            
        }
                 
        
    }
}