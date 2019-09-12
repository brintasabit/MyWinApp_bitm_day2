using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp_bitm_Extr
{
    public partial class PersonalInformationForm : Form
    {
        Calculator cal = new Calculator();


        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextbox.Text;
            string lastName = LastNameTextbox.Text;
            string fatherName = FatherNameTextbox.Text;
            string motherName = MotherNameTextbox.Text;
            string address = AddressNameTextbox.Text;
            MessageBox.Show("Data saved\n" +firstName+lastName+fatherName+motherName+address);




        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextbox.Text;
            string lastName = LastNameTextbox.Text;
            string fatherName = FatherNameTextbox.Text;
            string motherName = MotherNameTextbox.Text;
            string address = AddressNameTextbox.Text;
            MessageBox.Show("All Information\n" + "Name: " + firstName + lastName + "\nParents\n"+"Father " + fatherName+"\nMother " + motherName +"\nAddress "+ address);

        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextbox.Text;
            string lastName = LastNameTextbox.Text;
            MessageBox.Show("Your Name\n" + firstName + lastName);
        }

        private void ParentsButton_Click(object sender, EventArgs e)
        {
            string fatherName = FatherNameTextbox.Text;
            string motherName = MotherNameTextbox.Text;
            MessageBox.Show("Father Name "+ fatherName + "\nMother Name "+ motherName);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            string address = AddressNameTextbox.Text;
            MessageBox.Show("Address is "+address);

        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            if (cal.IsDisposed)
            {
                cal = new Calculator();
            }
            
            cal.Show();
            cal.BringToFront();
            
        }
    }
}
