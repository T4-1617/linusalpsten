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
            hideEditPanelContent(); //visar inte editPanelen som default
            registrationChoices.SelectedIndexChanged += updateRegPanel; //kallar på updateRegPanel när ett alternativ väljs i comboboxen
            personListBox.SelectedIndexChanged += updateEditPanel;

            personListBox.DisplayMember = "fullName";
        }

        private void updateEditPanel(object sender, EventArgs e) //uppdaterar vad som ska visas i editPanelen
        {
            hideEditPanelContent();
            editPanel.Visible = true;
            switch (personListBox.Items[personListBox.SelectedIndex].GetType().Name)
            {
                case "Customer":
                    editShowCustomer();
                    break;
                case "Employee":
                    editShowEmployee();
                    break;
                case "SupplyContact":
                    editShowSupplyContact();
                    break;
                default:
                    break;
            }
        }

        private void updateRegPanel(object sender, EventArgs e) //uppdaterar vad som ska visas i regPanelen
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

        private bool validEditInput() //kollar om de relevanta textboxes är tomma eller inte innehåller ett nr om det ska göra det
        {
            if (editFirstNameTBox.Text.Length == 0 || editLastNameTBox.Text.Length == 0 || editPhoneNrTBox.Text.Length == 0)
            {
                return false;
            }
            System.Text.RegularExpressions.Regex onlyNumbers = new System.Text.RegularExpressions.Regex(@"\d+");
            switch (personListBox.Items[personListBox.SelectedIndex].GetType().Name)
            {
                case "Customer":
                    if (!onlyNumbers.IsMatch(editDynamicTBox.Text))
                    {
                        return false;
                    }
                    break;
                case "Employee":
                    if (!onlyNumbers.IsMatch(editDynamicTBox.Text) || editTitleTBox.Text.Length == 0 || !onlyNumbers.IsMatch(editDynamicTBox.Text))
                    {
                        return false;
                    }
                    break;
                case "SupplyContact":
                    if (editDynamicTBox.Text.Length == 0)
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }
            return true;
        }

        private void hideEditPanelContent()
        {
            editDynamicTBox.Visible = false;
            editSalaryTBox.Visible = false;
            editTitleTBox.Visible = false;

            editDynamicLabel.Visible = false;
            editSalaryLabel.Visible = false;
            editTitleLabel.Visible = false;

            editPanel.Visible = false;
        }

        private void clearEditTextboxes() //tömmer alla textboxes
        {
            editFirstNameTBox.Text = string.Empty;
            editLastNameTBox.Text = string.Empty;
            editPhoneNrTBox.Text = string.Empty;
            editDynamicTBox.Text = string.Empty;
            editSalaryTBox.Text = string.Empty;
            editTitleTBox.Text = string.Empty;
        }

        private int person_i;
        private Customer customer;
        private void editShowCustomer()
        {
            editDynamicLabel.Text = customerIdString;
            editDynamicLabel.Visible = true;
            editDynamicTBox.Visible = true;
            person_i = personListBox.SelectedIndex;
            customer = (Customer)personListBox.Items[person_i];
            editFirstNameTBox.Text = customer.firstName;
            editLastNameTBox.Text = customer.lastName;
            editPhoneNrTBox.Text = customer.phoneNr;
            editDynamicTBox.Text = customer.customerID.ToString();
        }

        private Employee employee;
        private void editShowEmployee()
        {
            editDynamicLabel.Text = employeeIdString;
            editDynamicLabel.Visible = true;
            editDynamicTBox.Visible = true;
            editTitleLabel.Visible = true;
            editTitleTBox.Visible = true;
            editSalaryLabel.Visible = true;
            editSalaryTBox.Visible = true;
            person_i = personListBox.SelectedIndex;
            employee = (Employee)personListBox.Items[person_i];
            editFirstNameTBox.Text = employee.firstName;
            editLastNameTBox.Text = employee.lastName;
            editPhoneNrTBox.Text = employee.phoneNr;
            editDynamicTBox.Text = employee.employeeNr.ToString();
            editSalaryTBox.Text = employee.salary.ToString();
            editTitleTBox.Text = employee.title;
        }

        private SupplyContact supplyContact;
        private void editShowSupplyContact()
        {
            editDynamicLabel.Text = companyString;
            editDynamicLabel.Visible = true;
            editDynamicTBox.Visible = true;
            person_i = personListBox.SelectedIndex;
            supplyContact = (SupplyContact)personListBox.Items[person_i];
            editFirstNameTBox.Text = supplyContact.firstName;
            editLastNameTBox.Text = supplyContact.lastName;
            editPhoneNrTBox.Text = supplyContact.phoneNr;
            editDynamicTBox.Text = supplyContact.company;
        }

        private void editCancelButton_Click(object sender, EventArgs e)
        {
            clearEditTextboxes();
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (validEditInput())
            {
                switch (personListBox.Items[personListBox.SelectedIndex].GetType().Name)
                {
                    case "Customer":
                        editCustomer();
                        break;
                    case "Employee":
                        editEmployee();
                        break;
                    case "SupplyContact":
                        editSupplyContact();
                        break;
                    default:
                        break;
                }
                clearEditTextboxes();
            }
            else
            {
                MessageBox.Show("Invalid Input:\nPlease fill all textboxes.");
            }
        }


        private void editCustomer()
        {
            Customer customer = new Customer();
            customer.firstName = editFirstNameTBox.Text;
            customer.lastName = editLastNameTBox.Text;
            customer.customerID = int.Parse(editDynamicTBox.Text);
            customer.phoneNr = editPhoneNrTBox.Text;

            personListBox.Items[personListBox.SelectedIndex] = customer;
            clearEditTextboxes();
        }

        private void editEmployee()
        {
            Employee employee = new Employee();
            employee.firstName = editFirstNameTBox.Text;
            employee.lastName = editLastNameTBox.Text;
            employee.employeeNr = int.Parse(editDynamicTBox.Text);
            employee.phoneNr = editPhoneNrTBox.Text;
            employee.title = editTitleTBox.Text;
            employee.salary = int.Parse(editSalaryTBox.Text);

            personListBox.Items[personListBox.SelectedIndex] = employee;
        }

        private void editSupplyContact()
        {
            SupplyContact supplyContact = new SupplyContact();
            supplyContact.firstName = editFirstNameTBox.Text;
            supplyContact.lastName = editLastNameTBox.Text;
            supplyContact.company = editDynamicTBox.Text;
            supplyContact.phoneNr = editPhoneNrTBox.Text;

            personListBox.Items[personListBox.SelectedIndex] = supplyContact;
        }
    }
}