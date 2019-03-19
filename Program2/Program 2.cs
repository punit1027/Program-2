// Grading ID: A3960
// Program 2
// CIS 199-01
// March 9, 2017
// Description: This programs asks the user to enter their last name and select year in college
//  in order to find out their class registration date.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class program2 : Form
    {
        public program2()
        {
            InitializeComponent();
        }

        private void registrationDateButton_Click(object sender, EventArgs e)
        {
         
            string lastName = lastNameTextBox.Text; // holds last name.
            char letter; // holds first letter of last name.
            string dateString; // holds registration day.

            letter = lastName[0]; // holds first letter of last name.
            letter = char.ToUpper(letter); // stores the letter as an upper case letter.

            // store possible days as strings
            const string firstDay = "Wednesday, March 29";
            const string secondDay = "Thursday, March 30";
            const string thirdDay = "Friday, March 31";
            const string fourthDay = "Monday, April 3";
            const string fifthDay = "Tuesday, April 4";
            const string sixthDay = "Wednesday, April 5";

            // Stores times.
            const string FIRSTTIME = "8:30 A.M.";
            const string SECONDTIME = "10:00 A.M.";
            const string THIRDTIME = "11:30 A.M.";
            const string FOURTHTIME = "2:00 P.M.";
            const string FIFTHTIME = "4:00 P.M.";

            // Stores upper letter limits for comparing.
            const char LETTERD = 'D';
            const char LETTERI = 'I';
            const char LETTERO = 'O';
            const char LETTERS = 'S';

            // If statement for upperclass students.
            if (seniorRadioButton.Checked || juniorRadioButton.Checked)
            {if (seniorRadioButton.Checked)
                {
                    // Stores if seniorRadioButton is checked.
                    dateString = firstDay; }
                else
                {
                    // Stores day if juniorRadioButton is checked.
                    dateString = secondDay;}

                // Show registration date if last name between A-D.
                if (letter <= LETTERD)
                {MessageBox.Show(dateString + " at " + THIRDTIME);}


                // Show registration date if last name between E-I.
                else if (letter <= LETTERI)
                {MessageBox.Show(dateString + " at " + FOURTHTIME); }

                // Show registration date if last name between F-O.
                else if (letter <= LETTERO)
                {MessageBox.Show(dateString + " at " + FIFTHTIME);}

                // Shows registration date if last name between P-S.
                else if (letter <= LETTERS)
                { MessageBox.Show(dateString + " at " + FIRSTTIME);}

                // Show registration date if last name between T-Z.
                else
                {MessageBox.Show(dateString + " at " + SECONDTIME);}}

            //Store the upper limits for first letter of last name.
            const char LOWERLETTERB = 'B';
            const char LOWERLETTERD = 'D';
            const char LOWERLETTERF = 'F';
            const char LOWERLETTERI = 'I';
            const char LOWERLETTERL = 'L';
            const char LOWERLETTERO = 'O';
            const char LOWERLETTERQ = 'Q';
            const char LOWERLETTERS = 'S';
            const char LOWERLETTERV = 'V';            


            // if statement for underclass students.
            if (sophomoreRadioButton.Checked || freshmanRadioButton.Checked)
            {if (sophomoreRadioButton.Checked && (letter > LOWERLETTERB) && (letter <= LOWERLETTERO))
                {// Stores date
                 dateString = fourthDay;}
                else if (sophomoreRadioButton.Checked)
                {// store dates for second year students.
                    dateString = thirdDay;}
                else if (freshmanRadioButton.Checked && (letter > LOWERLETTERB) && (letter <= LOWERLETTERO))
                {// Stores freshmen date.
                    dateString = sixthDay;}
                else
                {// store date for freshmen.
                    dateString = fifthDay;}

                if (letter <= LOWERLETTERB)
                {// Shows registration date for last names within A-B
                    MessageBox.Show(dateString + " at " + FIFTHTIME);}
                else if (letter <= LOWERLETTERD)
                {// show registration date for last names within C-D
                    MessageBox.Show(dateString + " at " + FIRSTTIME);}                
                else if (letter <= LOWERLETTERF)
                {// show registration date for last names within E-F
                    MessageBox.Show(dateString + " at " + SECONDTIME);}
                else if (letter <= LOWERLETTERI)
                {// show registration date for last names within G-I
                    MessageBox.Show(dateString + " at " + THIRDTIME);}
                else if (letter <= LOWERLETTERL)
                {// show registration date for last names within J-L
                    MessageBox.Show(dateString + " at " + FOURTHTIME);}
                else if (letter <= LOWERLETTERO)
                {// show registration date for last names within M-O
                    MessageBox.Show(dateString + " at " + FIFTHTIME);}
                else if (letter <= LOWERLETTERQ)
                {// show registration date for last names within P-Q
                    MessageBox.Show(dateString + " at " + FIRSTTIME);}
                else if (letter <= LOWERLETTERS)
                {// show registration date for last names within R-S
                    MessageBox.Show(dateString + " at " + SECONDTIME);}
                else if (letter <= LOWERLETTERV)
                {// show registration date for last names within T-V
                    MessageBox.Show(dateString + " at " + THIRDTIME);}
                else
                {// show registration date for last names within W-Z
                    MessageBox.Show(dateString + " at " + FOURTHTIME);}}}

        private void Form1_Load(object sender, EventArgs e)
        {}}}
