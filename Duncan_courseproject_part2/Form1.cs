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

                // Write all employee objects to file
                WriteEmpsToFile();
            }

        }

        private void WriteEmpsToFile()
        {
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
            MessageBox.Show("Employees file has been updated.");
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
                // Write all employee objects to file
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }

        }

        private void DipsplayButton_Click(object sender, EventArgs e)
        {
            // Clear listbox
            EmployeesListBox.Items.Clear();

            // Displays Saved employee Objects
            ReadEmpsFromFile();
        }

        private void ReadEmpsFromFile()
        {
            // Read all employee objects from save file
            string fileName = "Employees.csv";
            StreamReader sr = new StreamReader(fileName);
            using (sr)
            {
                while (sr.Peek() > -1)
                {
                    // Read the line and break it up into parts based on commas
                    string line = sr.ReadLine();
                    string[] parts = line.Split(',');

                    string fName = parts[0];
                    string lName = parts[1];
                    string ssn = parts[2];
                    DateTime hireDate = DateTime.Parse(parts[3]);

                    // Create employee object and add it to listbox
                    Employee emp = new Employee(fName, lName, ssn, hireDate);
                    EmployeesListBox.Items.Add(emp);
                }
            }
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }
    }
}
