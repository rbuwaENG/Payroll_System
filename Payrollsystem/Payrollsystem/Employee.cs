using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Payrollsystem
{
    public partial class Employee : Form
    {

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "INSERT INTO Emp_table VALUES(@eid, @ename, @eage, @eaddress, @econtact, @esalary, @eallow, @eover)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Assuming that 'eid' is an integer, adjust SqlDbType accordingly if it's a different data type
                    cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(eid.Text));
                    cmd.Parameters.AddWithValue("@ename", ename.Text);
                    cmd.Parameters.AddWithValue("@eage", Convert.ToInt32(eage.Text));
                    cmd.Parameters.AddWithValue("@eaddress", eaddress.Text);
                    cmd.Parameters.AddWithValue("@econtact", econtact.Text);
                    cmd.Parameters.AddWithValue("@esalary", Convert.ToDecimal(esalary.Text));
                    cmd.Parameters.AddWithValue("@eallow", Convert.ToDecimal(eallow.Text));
                    cmd.Parameters.AddWithValue("@eover", Convert.ToDecimal(eover.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data inserted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void econtact_TextChanged(object sender, EventArgs e)
        {

        }

        private void eaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void eid_TextChanged(object sender, EventArgs e)
        {

        }

        private void esalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void eover_TextChanged(object sender, EventArgs e)
        {

        }

        private void eallow_TextChanged(object sender, EventArgs e)
        {

        }

        private void ename_TextChanged(object sender, EventArgs e)
        {

        }

        private void eage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "SELECT * FROM Emp_table";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Create a DataTable to store the results
                            DataTable employeeDataTable = new DataTable();

                            // Fill the DataTable with the results from the query
                            adapter.Fill(employeeDataTable);

                            // Assuming you have a DataGridView named dataGridViewEmployees
                            dataGridView1.DataSource = employeeDataTable;

                            // Optionally, you can customize the appearance of the DataGridView
                            // For example, you can hide the 'eid' column if you don't want to display it
                            //dataGridView1.Columns["eid"].Visible = false;
                        }
                    }
                    con.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM Emp_table WHERE Name LIKE @searchKeyword OR Address LIKE @searchKeyword OR Emp_id LIKE @searchKeyword OR Age LIKE @searchKeyword OR Salary LIKE @searchKeyword";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@searchKeyword", "%" + searchbox.Text + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable employeeDataTable = new DataTable();
                            adapter.Fill(employeeDataTable);

                            // Assuming you have a DataGridView named dataGridViewEmployees
                            dataGridView1.DataSource = employeeDataTable;
                            //dataGridView1.Columns["eid"].Visible = false; // Optionally hide 'eid'
                        }
                    }
                    con.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM Emp_table WHERE Emp_id = @eid";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@eid", detailbox.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable employeeDataTable = new DataTable();
                            adapter.Fill(employeeDataTable);

                            // Assuming you have a DataGridView named dataGridViewEmployees
                            dataGridView1.DataSource = employeeDataTable;
                            //dataGridView1.Columns["eid"].Visible = false; // Optionally hide 'eid'
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "UPDATE Emp_table SET Name = @ename, Age = @eage, Address = @eaddress, Mobile_no = @econtact, Salary = @esalary, Allowance = @eallow, overTime = @eover WHERE Emp_id = @eid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@eid", eid.Text);
                        cmd.Parameters.AddWithValue("@ename", ename.Text);
                        cmd.Parameters.AddWithValue("@eage", Convert.ToInt32(eage.Text));
                        cmd.Parameters.AddWithValue("@eaddress", eaddress.Text);
                        cmd.Parameters.AddWithValue("@econtact", econtact.Text);
                        cmd.Parameters.AddWithValue("@esalary", Convert.ToDecimal(esalary.Text));
                        cmd.Parameters.AddWithValue("@eallow", Convert.ToDecimal(eallow.Text));
                        cmd.Parameters.AddWithValue("@eover", Convert.ToDecimal(eover.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Data updated successfully");
                        else
                            MessageBox.Show("Employee not found");
                    }
                }
            }
          
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "DELETE FROM Emp_table WHERE Emp_id = @eid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@eid", eid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Data deleted successfully");
                        else
                            MessageBox.Show("Employee not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    decimal monthlySalary = 0;
                    decimal allowances = 0;
                    decimal overtimeRate = 0;
                    // Retrieve necessary data from the Employee_table
                    string employeeQuery = "SELECT Salary, Allowance, Overtime FROM Emp_table WHERE Emp_id = @EmployeeId";
                    using (SqlCommand employeeCmd = new SqlCommand(employeeQuery, con))
                    {
                        employeeCmd.Parameters.AddWithValue("@EmployeeId", salaryid.Text);
                      
                        using (SqlDataReader employeeReader = employeeCmd.ExecuteReader())
                        {
                            

                            if (employeeReader.Read())
                            {
                                monthlySalary = Convert.ToDecimal(employeeReader["Salary"]);
                                allowances = Convert.ToDecimal(employeeReader["Allowance"]);
                                overtimeRate = Convert.ToDecimal(employeeReader["Overtime"]);
                            }

                            // Close the reader explicitly
                            employeeReader.Close();
                        }
                    }

                    // Calculate NoPayValue, BasePay, and GrossPay
                    decimal noPayValue = (monthlySalary / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)) * Convert.ToDecimal(absent.Text);
                    decimal basePay = monthlySalary + allowances + (overtimeRate * Convert.ToDecimal(hours.Text)); // Assuming no overtime hours for now
                    decimal grossPay = basePay - (noPayValue + (basePay * Convert.ToDecimal(tax.Text))/100);

                    // Insert a new record into the Salary_table with the calculated values
                    string insertQuery = "INSERT INTO salary_tabl (id, BasePay, NoPayValue, GrossPay, Month) VALUES (@EmployeeId, @BasePay, @NoPayValue, @GrossPay, @Month)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@EmployeeId", salaryid.Text);
                        insertCmd.Parameters.AddWithValue("@BasePay", basePay);
                        insertCmd.Parameters.AddWithValue("@NoPayValue", noPayValue);
                        insertCmd.Parameters.AddWithValue("@GrossPay", grossPay);
                        insertCmd.Parameters.AddWithValue("@Month", DateTime.Now.Month); // Assuming inserting for the current month

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Salary record inserted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert salary record.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM salary_tabl";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable salaryDataTable = new DataTable();
                            adapter.Fill(salaryDataTable);

                            // Assuming you have a DataGridView named dataGridViewSalary
                            dataGridView2.DataSource = salaryDataTable;
                            dataGridView2.Columns["BasePay"].Visible = false; // Optionally hide 'EmployeeId'
                           
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        decimal monthlySalary = 0;
                        decimal allowances = 0;
                        decimal overtimeRate = 0;
                        // Retrieve necessary data from the Employee_table
                        string employeeQuery = "SELECT Salary, Allowance, Overtime FROM Emp_table WHERE Emp_id = @EmployeeId";
                        using (SqlCommand employeeCmd = new SqlCommand(employeeQuery, con))
                        {
                            employeeCmd.Parameters.AddWithValue("@EmployeeId", salaryid.Text);

                            using (SqlDataReader employeeReader = employeeCmd.ExecuteReader())
                            {
                                

                                if (employeeReader.Read())
                                {
                                    monthlySalary = Convert.ToDecimal(employeeReader["Salary"]);
                                    allowances = Convert.ToDecimal(employeeReader["Allowance"]);
                                    overtimeRate = Convert.ToDecimal(employeeReader["Overtime"]);
                                }

                                // Close the reader explicitly
                                employeeReader.Close();
                            }
                        }
                    int allowedLeavesPerYear = AppSettings.LeavesPerYear;
                    decimal absents = Convert.ToDecimal(absent.Text);
                    int leavesRequested = Convert.ToInt32(leave.Text);
                    if ( leavesRequested > allowedLeavesPerYear)
                    {
                        MessageBox.Show("Error: Leaves exceeded the allowed limit for the year.");
                        return;  // Stop further processing
                    }

                    // Calculate NoPayValue, BasePay, and GrossPay
                        decimal noPayValue = ((monthlySalary * absents) / 30M) ;
                        decimal basePay = monthlySalary + allowances + (overtimeRate * Convert.ToDecimal(hours.Text)); // Assuming no overtime hours for now
                        decimal grossPay = basePay - (noPayValue + (basePay * Convert.ToDecimal(tax.Text))/100);

                        // Update the Salary_table with the calculated values
                        string updateQuery = "UPDATE salary_tabl SET BasePay = @BasePay, NoPayValue = @NoPayValue, GrossPay = @GrossPay WHERE id = @EmployeeId AND Month = @Month";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@EmployeeId", salaryid.Text);
                            updateCmd.Parameters.AddWithValue("@BasePay", basePay);
                            updateCmd.Parameters.AddWithValue("@NoPayValue", noPayValue);
                            updateCmd.Parameters.AddWithValue("@GrossPay", grossPay);
                            updateCmd.Parameters.AddWithValue("@Month", DateTime.Now.Month); // Assuming updating for the current month

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Salary updated successfully");
                            }
                            else
                            {
                                MessageBox.Show("Salary not updated. Employee not found in the Salary_table for the current month.");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string fileName = $"MonthlySalaryReport_Employee_{rid.Text}_Month_{12}.txt";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM salary_tabl WHERE id = @EmployeeId AND Month = @Month";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", rid.Text);
                        cmd.Parameters.AddWithValue("@Month", 12);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               // decimal noPayValue = Convert.ToDecimal(reader["NoPayValue"]);
                                decimal basePayValue = Convert.ToDecimal(reader["BasePay"]);
                                decimal grossPayValue = Convert.ToDecimal(reader["GrossPay"]);

                                using (StreamWriter writer = new StreamWriter(fileName))
                                {
                                    writer.WriteLine($"Monthly Salary Report for Employee {rid.Text}, Month {12}");
                                    //writer.WriteLine($"No-pay value: {noPayValue}");
                                    writer.WriteLine($"Base-pay value: {basePayValue}");
                                    writer.WriteLine($"Gross-pay value: {grossPayValue}");
                                    // Add more details as needed
                                }

                                MessageBox.Show($"Monthly Salary Report generated successfully. File saved at: {fileName}");
                            }
                            else
                            {
                                MessageBox.Show("No salary data found for the specified employee and month.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Monthly Salary Report: {ex.Message}");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string fileName = $"OverallSalarySummary_Employee_{rid.Text}.txt";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM Salary_table WHERE EmployeeId = @EmployeeId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", rid.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                decimal totalNoPay = 0;
                                decimal totalBasePay = 0;
                                decimal totalGrossPay = 0;

                                while (reader.Read())
                                {
                                    totalNoPay += Convert.ToDecimal(reader["NoPayValue"]);
                                    totalBasePay += Convert.ToDecimal(reader["BasePay"]);
                                    totalGrossPay += Convert.ToDecimal(reader["GrossPay"]);
                                }

                                using (StreamWriter writer = new StreamWriter(fileName))
                                {
                                    writer.WriteLine($"Overall Salary Summary Report for Employee {rid.Text}");
                                    writer.WriteLine($"Total No-pay value: {totalNoPay}");
                                    writer.WriteLine($"Total Base-pay value: {totalBasePay}");
                                    writer.WriteLine($"Total Gross-pay value: {totalGrossPay}");
                                    // Add more details as needed
                                }

                                MessageBox.Show($"Overall Salary Summary Report generated successfully. File saved at: {fileName}");
                            }
                            else
                            {
                                MessageBox.Show("No salary data found for the specified employee.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Overall Salary Summary Report: {ex.Message}");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string fileName = $"OverallSalaryDetails_MonthRange_{sbox.Text}_to_{ebox.Text}.txt";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Employeedb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM Salary_table WHERE Month BETWEEN @StartMonth AND @EndMonth";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StartMonth", sbox.Text);
                        cmd.Parameters.AddWithValue("@EndMonth", ebox.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                using (StreamWriter writer = new StreamWriter(fileName))
                                {
                                    writer.WriteLine($"Overall Salary Details Report for Month Range {ebox.Text} to {ebox.Text}");
                                    while (reader.Read())
                                    {
                                        int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                                        int month = Convert.ToInt32(reader["Month"]);
                                        decimal noPayValue = Convert.ToDecimal(reader["NoPayValue"]);
                                        decimal basePayValue = Convert.ToDecimal(reader["BasePay"]);
                                        decimal grossPayValue = Convert.ToDecimal(reader["GrossPay"]);

                                        writer.WriteLine($"Employee {employeeId}, Month {month}");
                                        writer.WriteLine($"No-pay value: {noPayValue}");
                                        writer.WriteLine($"Base-pay value: {basePayValue}");
                                        writer.WriteLine($"Gross-pay value: {grossPayValue}");
                                        writer.WriteLine(); // Add a line break for better readability
                                    }

                                    MessageBox.Show($"Overall Salary Details Report for Month Range generated successfully. File saved at: {fileName}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No salary data found for the specified month range.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Overall Salary Details Report for Month Range: {ex.Message}");
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        public static class AppSettings
        {
            public static int DateRange { get; set; }
            public static DateTime SalaryCycleBeginDate { get; set; }
            public static DateTime SalaryCycleEndDate { get; set; }
            public static int LeavesPerYear { get; set; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the settings
                AppSettings.DateRange = Convert.ToInt32(datarange.Text);
                AppSettings.SalaryCycleBeginDate = start.Value;
                AppSettings.SalaryCycleEndDate = end.Value;
                AppSettings.LeavesPerYear = Convert.ToInt32(leavedate.Text);

                MessageBox.Show("Settings updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating settings: " + ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            eid.Text = string.Empty;
            ename.Text = string.Empty;
            econtact.Text = string.Empty;
            esalary.Text = string.Empty;
            eallow.Text = string.Empty;
            eage.Text = string.Empty;
            eover.Text = string.Empty;
            sbox.Text = string.Empty;
            detailbox.Text = string.Empty;
            eaddress.Text = string.Empty;
        }
    }



      
}
