using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camping
{
    public partial class Form1 : Form
    {
        private CampingSpot _newCampingSpot1;
        private DateTime dateStart, dateEnd;
        private double pricePerMeter ,rent, dog, car, _priceTotal = 0;
        private int lengthDifference, days = 0;
        private string _operator = "+";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DateTime.Today.Date > new DateTime(DateTime.Today.Year, 08, 25))
            {
                _newCampingSpot1 = new CampingSpot("standard", 30, 25, 2, 3, 5, 4, 6, 10,
                    new DateTime(DateTime.Today.Year+1, 07, 11), new DateTime(DateTime.Today.Year+1, 08, 25));
            }
            else
            {
                _newCampingSpot1 = new CampingSpot("standard", 30, 25, 2, 3, 5, 4, 6, 10,
                    new DateTime(DateTime.Today.Year, 07, 11), new DateTime(DateTime.Today.Year, 08, 25));
            }

            labelSubscription1.Text = _newCampingSpot1.Name;
            
            labelPrice1.Text =
                $"hoog {_newCampingSpot1.RentMain} laag {_newCampingSpot1.RentLow} lengte {_newCampingSpot1.RentLengthMin} lengte {_newCampingSpot1.RentLengthPlus} pp {_newCampingSpot1.PerPerson} hond {_newCampingSpot1.Dog} " +
                $"auto {_newCampingSpot1.Car} start {_newCampingSpot1.MainStart.ToString("dd/MM/yyyy")} eind {_newCampingSpot1.MainEnd.ToString("dd/MM/yyyy")}";
            
            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year + 20;
                control.Minimum = DateTime.Today.Year;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Minimum = DateTime.Today.Month;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Minimum = DateTime.Today.Day;
                control.Value = DateTime.Today.Day;
            }

            labelTicketsTotal.Text = $@"(huur +/- verschil * 3/2 + personen * 5 + hond + auto) * dagen";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            rent = 0;
            dog = 0;
            car = 0;
            _priceTotal = 0;
            days = 0;
            pricePerMeter = 0;
            lengthDifference = 0;
            // Checks if the correct dates are selected (in order)
            if (ValidateDate())
            {
                days = (int)(dateEnd - dateStart).TotalDays;
                // Checks if reservation is in main or low season
                if (dateStart >= _newCampingSpot1.MainStart && dateEnd <= _newCampingSpot1.MainEnd)
                {
                    rent =  _newCampingSpot1.RentMain;
                }
                else
                {
                    rent = _newCampingSpot1.RentLow;
                }

                // Checks if length is greater then or less then the standard length
                if (numericUpDownLegth.Value < _newCampingSpot1.Length)
                {
                    lengthDifference = _newCampingSpot1.Length - (int) numericUpDownLegth.Value;
                    _priceTotal += rent -lengthDifference * _newCampingSpot1.RentLengthMin;
                    _operator = "-";
                    pricePerMeter = _newCampingSpot1.RentLengthMin;
                }
                else if (numericUpDownLegth.Value > _newCampingSpot1.Length)
                {
                    lengthDifference = (int) numericUpDownLegth.Value - _newCampingSpot1.Length;
                    _priceTotal += rent + lengthDifference * _newCampingSpot1.RentLengthPlus;
                    _operator = "+";
                    pricePerMeter = _newCampingSpot1.RentLengthPlus;
                }
                else if (numericUpDownLegth.Value == _newCampingSpot1.Length)
                {
                    _priceTotal += rent;
                }

                // Calculates the total price for the total amount of persons
                _priceTotal += (double)numericUpDownPersons.Value * _newCampingSpot1.PerPerson;

                // Checks if checkboxes are checked
                if (checkBoxDog.Checked)
                {
                    dog =  _newCampingSpot1.Dog;
                    _priceTotal += dog;
                }

                if (checkBoxCar.Checked)
                {
                    car = _newCampingSpot1.Car;
                    _priceTotal += car;
                }

                _priceTotal = _priceTotal * days;

                labelTicketsTotal.Text = $@"({rent} {_operator} {lengthDifference} * {pricePerMeter} + {numericUpDownPersons.Value} * {_newCampingSpot1.PerPerson} + {dog} + {car}) * {days}";
                labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2)},-";
            }
        }

        private bool ValidateDate()
        {
            int checkDay1 = DateTime.DaysInMonth((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value);
            int checkDay2 = DateTime.DaysInMonth((int)numericUpDownYear2.Value, (int)numericUpDownMonth2.Value);
            
            if ((int)numericUpDownDay1.Value <= checkDay1 && (int)numericUpDownDay2.Value <= checkDay2)
            {
                dateStart = new DateTime((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value, (int)numericUpDownDay1.Value);
                dateEnd = new DateTime((int)numericUpDownYear2.Value, (int)numericUpDownMonth2.Value, (int)numericUpDownDay2.Value);
                if (dateStart < dateEnd)
                {
                    
                    return true;
                }
                else
                {
                    MessageBox.Show($@"Please fill the dates in the correct order \nstart date < end date");
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show($@"Please select the correct day of the month");
                return false;
            }
        }
    }
}
