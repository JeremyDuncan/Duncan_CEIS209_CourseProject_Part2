using System;
using System.IO;
using System.Windows.Forms;

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
                string healthIns = frmInput.HealthInsTextBox.Text;
                double lifeIns = Double.Parse(frmInput.LifeInsTextBox.Text);  
                int vacation = Int32.Parse(frmInput.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                Employee emp;
                if(frmInput.HourlyRadioButton.Checked)
                {
                    // get child items
                    float hourlyRate = float.Parse(frmInput.Pay1TextBox.Text);
                    float hoursWorked = Convert.ToSingle(frmInput.Pay2TextBox.Text);

                    // polymorphism
                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                } else if (frmInput.SalaryRadioButton.Checked)
                {
                    //get child items
                    double salary = Double.Parse(frmInput.Pay1TextBox.Text);

                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary) ;
                }
                else
                {
                    MessageBox.Show("ERROR. Invalid Employee Type.");
                    return;
                }


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
                             worker.HireDate.ToShortDateString() + "," +
                             worker.BenefitsPackage.HealthIns + "," +
                             worker.BenefitsPackage.LifeIns + "," +
                             worker.BenefitsPackage.Vacation);

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
                    string healthIns = parts[4];
                    double lifeIns = Double.Parse(parts[5]);
                    int vacation = Int32.Parse(parts[6]);

                    // Create employee object and add it to listbox
                    Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                    Employee emp = new Employee(fName, lName, ssn, hireDate, benefits);
                    EmployeesListBox.Items.Add(emp);
                }
            }
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load employees from file
            ReadEmpsFromFile();
        }

        private void EmployeesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // edit selscted employee in the listbox

            InputForm frmUpdate = new InputForm();

            using(frmUpdate)
            {
                frmUpdate.Text = "Employee Update Form";
                frmUpdate.SubmitButton.Text = "Update";

                int itemNumber = EmployeesListBox.SelectedIndex;
              
                if (itemNumber >= 0)
                {
                    Employee emp = (Employee)EmployeesListBox.Items[itemNumber];

                    frmUpdate.FirstNameTextBox.Text = emp.FirstName;
                    frmUpdate.LastNameTextBox.Text = emp.LastName;
                    frmUpdate.SSNTextBox.Text = emp.SSN;
                    frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
                    frmUpdate.HealthInsTextBox.Text = emp.BenefitsPackage.HealthIns;
                    frmUpdate.LifeInsTextBox.Text = emp.BenefitsPackage.LifeIns.ToString("C2");
                    frmUpdate.VacationTextBox.Text = emp.BenefitsPackage.Vacation.ToString();

                    DialogResult result = frmUpdate.ShowDialog();
                    
                    if (result == DialogResult.Cancel)
                    {
                        return; //End the Method siince user cancelled the update
                    }

                    EmployeesListBox.Items.RemoveAt(itemNumber);

                    string fName = frmUpdate.FirstNameTextBox.Text;
                    string lName = frmUpdate.LastNameTextBox.Text;
                    string ssn = frmUpdate.SSNTextBox.Text;
                    string date = frmUpdate.HireDateTextBox.Text;
                    DateTime hireDate = DateTime.Parse(date);
                    string healthIns = frmUpdate.HealthInsTextBox.Text;

                    // pull a substring that does not contain the initial '$' sign
                    string lifeInsString = frmUpdate.LifeInsTextBox.Text;
                    lifeInsString = lifeInsString.Substring(1);

                    double lifeIns = Double.Parse(lifeInsString);
                    int vacation = Int32.Parse(frmUpdate.VacationTextBox.Text);

                    Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                    emp = new Employee(fName, lName, ssn, hireDate, benefits);

                    //add the updated Employee object to the employees listbox
                    EmployeesListBox.Items.Add(emp);

                    // write all of the updated Employee objects to the file
                    WriteEmpsToFile();
                }

            }
        }
    }
}
