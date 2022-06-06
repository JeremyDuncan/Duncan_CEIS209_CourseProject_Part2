using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Duncan_courseproject_part2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form was cancelled
                if (result == DialogResult.Cancel)
                    return;    //  end the method since the user cancelled the input

                // get user's input and create an Employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);

                Employee emp = new Employee(fName, lName, ssn, hireDate);

                // add the Employee object to the employees listbox
                EmployeesListBox.Items.Add(emp);

                string fileName = "Employees.csv";
                StreamWriter sw = new StreamWriter(fileName);
                for (int i = 0; i < EmployeesListBox.Items.Count; i++)
                {
                    Employee worker = (Employee)EmployeesListBox.Items[i];
                    sw.WriteLine(worker.FirstName + "," +
                                 worker.LastName + "," +
                                 worker.SSN + "," + 
                                 worker.HireDate.ToShortDateString());
                }
                sw.Close();
                MessageBox.Show("Employees were written to the file");
            }

        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }

        }

        private void DipsplayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying all employees...");
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }
    }
}
