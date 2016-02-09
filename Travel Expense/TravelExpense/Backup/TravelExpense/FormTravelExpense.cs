using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Mengesha.Allowance2010;

namespace TravelExpense
{
    public partial class TravelExpense : Form
    {
        public TravelExpense()
        {
            InitializeComponent();
        }


        public DateTime startTime;
        public DateTime returnTime;
        int numberOfPersons = 0;
        double kmAllowancePerKm;
        double kmAllowancePerPerson;
        double halfDay;
        double fullDay;
        String strkmAllowance;
        String strkmAllowancePerPerson;
        String strHalfDayAllowance;
        String strFullDayAllowance;
        /// <summary>
        /// Calculates Domestic Trip and its allowance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateDomestic_Click(object sender, EventArgs e)
        {
            DateTime startD = startMonthCalendar.SelectionStart; //Start date
            DateTime returnD = returnMonthCalendar.SelectionEnd; //Return date
            String strStartT = startTimeMaskedTextBox.Text; //start time in string
            String strReturnT = returnTimeMaskedTextBox.Text; //return time in string
            strkmAllowance = txtKMAllowance.Text; // KM Allowance Per KM
            strkmAllowancePerPerson = txtPersonsAccompanying.Text; // KM Allowance per Person
            strHalfDayAllowance = txtHalfDayAllowance.Text;
            strFullDayAllowance = txtFullDayAllowance.Text;
            decimal totalKm = distanceNumericUpDown.Value;
            int kmDriven = (int)totalKm; 
            bool inputValidate = VerifyDomestic(startD,returnD,strStartT,strReturnT); //Calling a method to do validation of input
            if (inputValidate)
            {
                TimeSpan difference;
                double calculatedAllowance;
                double dailyAllowance;
                
                // create an object of the class ....
                Allowance a = new Allowance();
                difference = a.CalculateDays(startD, returnD, strStartT, strReturnT);
                calculatedAllowance = a.KmAllowance(kmDriven, kmAllowancePerKm, numberOfPersons, kmAllowancePerPerson);
                dailyAllowance = a.CalculateDailyAllowance(fullDay, halfDay);
                double total = calculatedAllowance + dailyAllowance;

                int days = difference.Days;
                txtDaysData.Text = "" + days;
                int hours = difference.Hours;
                txtHoursData.Text = "" + hours;
                int minutes = difference.Minutes;
                txtMinutesData.Text = "" + minutes;
                txtKMallowanceData.Text = "" + calculatedAllowance;
                txtDailyAllowanceData.Text = "" + dailyAllowance;
                txtTotalData.Text = "" + total;
            }
              
         }
        /// <summary>
        /// Verifies input values for Abroad tab
        /// </summary>
        /// <param name="startD"></param>
        /// <param name="returnD"></param>
        /// <param name="strStartT"></param>
        /// <param name="strReturnT"></param>
        /// <returns></returns>
        bool VerifyAborad(DateTime startD, DateTime returnD, String strStartT, String strReturnT)
        {
            if (strStartT == "" || strReturnT == "") //Checking weather the start time and return time didn't hold empty string
            {
                MessageBox.Show("Time Can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startTimeMaskedTextBox.Clear();
                returnTimeMaskedTextBox.Clear();
                startTimeMaskedTextBox.Focus();
                return false;
            }
            else
            {
                try //trying to parse from string to date time
                {
                    startTime = DateTime.Parse(strStartT); //start time in datetime format
                    returnTime = DateTime.Parse(strReturnT);//return time in datetime format
                    double abroadAllowance = double.Parse(txtAbroadAllowance.Text);
                        

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid time input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    startTimeMaskedTextBox.Clear();
                    returnTimeMaskedTextBox.Clear();
                    startTimeMaskedTextBox.Focus();
                    return false;
                }
                
            }
            if (startD > returnD) //Return date can't be less than start date
            {
                MessageBox.Show("Return Date can't be less than Start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (startD == returnD && startTime >= returnTime) //if return date and start date are same then return time must be bigger than start time.
            {
                MessageBox.Show("Return time must be greater than start time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifies input values for Domestic tab
        /// </summary>
        /// <param name="startD"></param>
        /// <param name="returnD"></param>
        /// <param name="strStartT"></param>
        /// <param name="strReturnT"></param>
        /// <returns></returns>
        bool VerifyDomestic(DateTime startD, DateTime returnD, String strStartT, String strReturnT)
        {
            bool isCarSelected = carCheckBox.Checked;
            decimal kmDriven = distanceNumericUpDown.Value;
            if (strStartT == "" || strReturnT == "") //Checking weather the start time and return time didn't hold empty string
            {
                MessageBox.Show("Time Can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startTimeMaskedTextBox.Clear();
                returnTimeMaskedTextBox.Clear();
                startTimeMaskedTextBox.Focus();
                return false;
            }
            else
            {
                try //trying to parse from string to date time
                {
                    startTime = DateTime.Parse(strStartT); //start time in datetime format
                    returnTime = DateTime.Parse(strReturnT);//return time in datetime format
                    kmAllowancePerKm = double.Parse(strkmAllowance);
                    kmAllowancePerPerson = double.Parse(strkmAllowancePerPerson);
                    halfDay = double.Parse(strHalfDayAllowance);
                    fullDay = double.Parse(strFullDayAllowance);

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid time input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    startTimeMaskedTextBox.Clear();
                    returnTimeMaskedTextBox.Clear();
                    startTimeMaskedTextBox.Focus();
                    return false;

                }
            }
            if (isCarSelected && kmDriven == 0) //if the trip was done with car then kms must be written
            {
                MessageBox.Show("Since the trip was taken with car KM's must be written", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (startD > returnD) //Return date can't be less than start date
            {
                MessageBox.Show("Return Date can't be less than Start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (startD == returnD && startTime >= returnTime) //if return date and start date are same then return time must be bigger than start time.
            {
                MessageBox.Show("Return time must be greater than start time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }
        /// <summary>
        /// Helps to check weather the trip is done with car or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (carCheckBox.Checked == false) // If check box is selected then km should have to be written
            {
                distanceNumericUpDown.Enabled = false;
                radioButton0.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            
            else //otherwise it have to be disabled
            {
                distanceNumericUpDown.Enabled = true;
                radioButton0.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
                
                  

        }
        /// <summary>
        /// Radio buttons set total number of travelers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            numberOfPersons = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numberOfPersons = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numberOfPersons = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numberOfPersons = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            numberOfPersons = 4;
        }

    
        /// <summary>
        /// Calculate Abroad trips allowance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateAbroad_Click(object sender, EventArgs e)
        {
            double abroadAllowance = double.Parse(txtAbroadAllowance.Text);
            DateTime startD = startMonthCalendar.SelectionStart; //Start date
            DateTime returnD = returnMonthCalendar.SelectionEnd; //Return date
            String strStartT = startTimeMaskedTextBox.Text; //start time in string
            String strReturnT = returnTimeMaskedTextBox.Text; //return time in string   
            bool verifyInput = VerifyAborad(startD, returnD, strStartT, strReturnT); //Calling a method to do validation of input
            if (verifyInput)
            {
                TimeSpan difference;
                double calculatedAllowance;
                
                // create an object of the class ....
                Allowance a = new Allowance();
                difference = a.CalculateDays(startD, returnD, strStartT, strReturnT);
                if (difference.Days == 0)
                { 
                    //call domestic
                    calculatedAllowance = a.CalculateDailyAllowance(double.Parse(txtFullDayAllowance.Text),
                        double.Parse(txtHalfDayAllowance.Text));
                }
                else // Call Abroad
                {
                    calculatedAllowance = a.CalculateAllowanceAbroad(abroadAllowance);
                }
                
                int days = difference.Days;
                txtDaysData.Text = "" + days;
                int hours = difference.Hours;
                txtHoursData.Text = "" + hours;
                int minutes = difference.Minutes;
                txtMinutesData.Text = "" + minutes;
                txtKMallowanceData.Text = "0" ;
                txtDailyAllowanceData.Text = "" + calculatedAllowance;
                txtTotalData.Text = "" + calculatedAllowance;
            }
        }
        /// <summary>
        /// Read from File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                Allowance a = new Allowance();
                //string fileName = op.FileName;
                listBox1.DataSource = null;
                listBox1.ValueMember = "DailyAllowance";
                listBox1.DisplayMember = "Name";
                listBox1.DataSource = a.ReadCountiesAndDailyAllowances(op.FileName);
                txtFullDayAllowance.Text = a.FinFull;
                txtHalfDayAllowance.Text = a.FinHalf;
                txtKMAllowance.Text = a.FinKm;
                txtPersonsAccompanying.Text = a.FinPerson;
                
            }
        }
        /// <summary>
        /// Assigning Allowance values from corrosponding countries list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAbroadAllowance.Text="";
            txtAbroadAllowance.ReadOnly = true;
            txtAbroadAllowance.Text = listBox1.SelectedValue.ToString();
        }

    
        /// <summary>
        /// The following lines are for changing font color and mouse cursor while the mouse is over the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_MouseHover(object sender, EventArgs e)
        {
            btnRead.ForeColor = Color.Red;
            btnRead.Cursor = Cursors.Hand;
        }

        private void btnRead_MouseLeave(object sender, EventArgs e)
        {
            btnRead.ForeColor = Color.Black;
            btnRead.Cursor = Cursors.Default;
        }

        private void btnCalculateDomestic_MouseLeave(object sender, EventArgs e)
        {
            btnCalculateDomestic.ForeColor = Color.Black;
            btnCalculateDomestic.Cursor = Cursors.Default;
        }

        private void btnCalculateDomestic_MouseHover(object sender, EventArgs e)
        {
            btnCalculateDomestic.ForeColor = Color.Red;
            btnCalculateDomestic.Cursor = Cursors.Hand;
        }

        private void btnCalculateAbroad_MouseLeave(object sender, EventArgs e)
        {
            btnCalculateAbroad.ForeColor = Color.Black;
            btnCalculateAbroad.Cursor = Cursors.Default;
        }

        private void btnCalculateAbroad_MouseHover(object sender, EventArgs e)
        {
            btnCalculateAbroad.ForeColor = Color.Red;
            btnCalculateAbroad.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// System SHUT DOWN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shutdownPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s"); // By Default the Shutdown will take place after 30 Seconds 

            //if its needed to change change the Delay try this one
            Process.Start("shutdown.exe", "-s -t xx"); //Replace xx with Seconds example 10,20 etc
        }
        /// <summary>
        /// RESTART System
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r"); // By Default the Restart will take place after 30 Seconds 

            //if its needed to change change the Delay try this one
            Process.Start("shutdown.exe", "-r -t 10"); //Replace xx with Seconds example 10,20 etc
        }
        /// <summary>
        /// LOG OFF Current windows user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOffPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-l"); //This Code Will Directly Log Off the System Without warnings
        }



    

    


    }
}
