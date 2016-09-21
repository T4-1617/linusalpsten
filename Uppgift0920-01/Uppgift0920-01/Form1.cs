using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift0920_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            registrationChoices.Items.Add("Customer");
            registrationChoices.Items.Add("Employee");
            registrationChoices.Items.Add("Supply Contact");
            hideRegPanelContent(); //visar inte regPanelen som default
            registrationChoices.SelectedIndexChanged += updateRegPanel; //kallar på updateRegPanel när ett alternativ väljs i comboboxen

            personListBox.DisplayMember = "fullName";
        }

        public void updateRegPanel(object sender, EventArgs e) //uppdaterar vad som ska visas i regPanelen
        {
            hideRegPanelContent();
            regPanel.Visible = true;
            switch (registrationChoices.SelectedIndex)
            {
                case -1:
                    regPanel.Visible = false;
                    break;
                case 0:
                    customerRegPanel();
                    break;
                case 1:
                    employeeRegPanel();
                    break;
                case 2:
                    supplyContactRegPanel();
                    break;
                default:
                    break;
            }
        }

        private void hideRegPanelContent() //slutar visa regPanelen och orelevanta textboxes i regPanelen
        {
            dynamicTBox.Visible = false;
            salaryTBox.Visible = false;
            titleTBox.Visible = false;

            dynamicLabel.Visible = false;
            salaryLabel.Visible = false;
            titleLabel.Visible = false;

            regPanel.Visible = false;
        }

        private void clearTextboxes() //tömmer alla textboxes
        {
            firstNameTBox.Text = string.Empty;
            lastNameTBox.Text = string.Empty;
            phoneNrTBox.Text = string.Empty;
            dynamicTBox.Text = string.Empty;
            salaryTBox.Text = string.Empty;
            titleTBox.Text = string.Empty;
        }

        private string customerIdString = "Customer ID:"; //skapar en återanvändbar sträng då den kan behövas flera gånger.
        private void customerRegPanel() //visar de relevanta textboxes för
        {
            dynamicLabel.Text = customerIdString;
            dynamicLabel.Visible = true;
            dynamicTBox.Visible = true;
        }

        private string employeeIdString = "Employee ID:"; //skapar en återanvändbar sträng då den kan behövas flera gånger.
        private void employeeRegPanel() //visar de relevanta textboxes för employee
        {
            dynamicLabel.Text = employeeIdString;
            dynamicLabel.Visible = true;
            dynamicTBox.Visible = true;
            titleLabel.Visible = true;
            titleTBox.Visible = true;
            salaryLabel.Visible = true;
            salaryTBox.Visible = true;
        }

        private string companyString = "Company:"; //skapar en återanvändbar sträng då den kan behövas flera gånger.
        private void supplyContactRegPanel() //visar de relevanta textboxes för supplyContact
        {
            dynamicLabel.Text = companyString;
            dynamicLabel.Visible = true;
            dynamicTBox.Visible = true;
        }

        private void addCustomer() //förklarar sig själv
        {
            Customer customer = new Customer();
            customer.firstName = firstNameTBox.Text;
            customer.lastName = lastNameTBox.Text;
            customer.customerID = int.Parse(dynamicTBox.Text);
            customer.phoneNr = phoneNrTBox.Text;

            personListBox.Items.Add(customer);
            clearTextboxes();
        }

        private void addEmployee() //förklarar sig själv
        {
            Employee employee = new Employee();
            employee.firstName = firstNameTBox.Text;
            employee.lastName = lastNameTBox.Text;
            employee.employeeNr = int.Parse(dynamicTBox.Text);
            employee.phoneNr = phoneNrTBox.Text;
            employee.title = titleTBox.Text;
            employee.salary = int.Parse(salaryTBox.Text);

            personListBox.Items.Add(employee);
            clearTextboxes();
        }

        private void addSupplyContact() //förklarar sig själv
        {
            SupplyContact supplyContact = new SupplyContact();
            supplyContact.firstName = firstNameTBox.Text;
            supplyContact.lastName = lastNameTBox.Text;
            supplyContact.company = dynamicTBox.Text;
            supplyContact.phoneNr = phoneNrTBox.Text;

            personListBox.Items.Add(supplyContact);
            clearTextboxes();
        }

        private void regCancelButton_Click(object sender, EventArgs e)
        {
            //tömm alla textboxes, sluta visa regPanelens innehåll och ändra combobox valet till default(ingenting)
            clearTextboxes();
            hideRegPanelContent();
            registrationChoices.SelectedIndex = -1;
        }

        private void regSaveButton_Click(object sender, EventArgs e)
        {
            //om de relevanta textboxarna är korrekt fyllda:
            //skapa en typ av Person (beroende på vad man valt i comboboxen) och spara den i listboxen
            if (validInput())
            {
                switch (registrationChoices.SelectedIndex)
                {
                    case 0:
                        addCustomer();
                        break;
                    case 1:
                        addEmployee();
                        break;
                    case 2:
                        addSupplyContact();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid Input:\nPlease fill all textboxes.");
            }
        }

        private bool validInput() //kollar om de relevanta textboxes är tomma eller inte innehåller ett nr om det ska göra det
        {
            if (firstNameTBox.Text.Length == 0 || lastNameTBox.Text.Length == 0 || phoneNrTBox.Text.Length == 0)
            {
                return false;
            }
            System.Text.RegularExpressions.Regex onlyNumbers = new System.Text.RegularExpressions.Regex(@"\d+");
            switch (registrationChoices.SelectedIndex)
            {
                case 0:
                    if (!onlyNumbers.IsMatch(dynamicTBox.Text))
                    {
                        return false;
                    }
                    break;
                case 1:
                    if (!onlyNumbers.IsMatch(dynamicTBox.Text) || titleTBox.Text.Length == 0 || !onlyNumbers.IsMatch(dynamicTBox.Text))
                    {
                        return false;
                    }
                    break;
                case 2:
                    if (dynamicTBox.Text.Length == 0)
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}