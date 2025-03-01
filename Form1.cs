using System.Data.OleDb;
using System.Data;
using System.Xml.Linq;

namespace WEEK8
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public Form1()
        {
            InitializeComponent();
        }//yawa
        //note: ang file location kay naas comp lab WAHHAHAHHWAHH
        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\fredwil\\source\\repos\\WEEK8-joberthelp-\\SchoolDatabase1.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\fredwil\\source\\repos\\WEEK8-joberthelp-\\SchoolDatabase1.accdb");
                da = new OleDbDataAdapter("SELECT Student.StudentID, Student.Lastname, Student.FirstName, Student.Course, Student.YearLevel, SubjectsEnrolled.CourseNum1, FinalGrade.FG1\r\nFROM (Student INNER JOIN SubjectsEnrolled ON Student.StudentID = SubjectsEnrolled.StudentID) INNER JOIN FinalGrade ON SubjectsEnrolled.StudentID = FinalGrade.StudentID;", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Student");
                dgvStudentInfo.DataSource = ds.Tables["Student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Caught: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            myConn.Close();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\fredwil\\source\\repos\\WEEK8-joberthelp-\\SchoolDatabase1.accdb");

                if (myConn == null)
                {
                    MessageBox.Show("Not connected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tbxLname.Text == "" || tbxFname.Text == "")
                {
                    MessageBox.Show("Empty inputs. Please fill all the necessary information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    myConn.Close();
                    return;
                }
                myConn.Open();
                string lastName = tbxLname.Text.Trim().ToLower();
                string firstName = tbxFname.Text.Trim().ToLower();

                string checkQuery = "SELECT COUNT(*) FROM [Grade Query] WHERE LCase(Trim(LastName)) = ? AND LCase(Trim(FirstName)) = ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                {
                    checkCmd.Parameters.AddWithValue("?", tbxLname.Text);
                    checkCmd.Parameters.AddWithValue("?", tbxFname.Text);
                    checkCmd.Parameters.AddWithValue("?", tbxCourse.Text);
                    checkCmd.Parameters.AddWithValue("?", int.Parse(tbxYlevel.Text));
                    checkCmd.Parameters.AddWithValue("?", tbxCourseNo.Text);
                    checkCmd.Parameters.AddWithValue("?", tbxFGrade1.Text);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Duplicate entry! This student already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        myConn.Close();
                        return;
                    }
                }

                string query = "Insert into [Grade Query] (LastName, FirstName, Course, YearLevel, CourseNum1, FG1) values (?, ?, ?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("?", tbxLname.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", tbxFname.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", tbxCourse.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", int.Parse(tbxYlevel.Text));
                    cmd.Parameters.AddWithValue("?", tbxCourseNo.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", tbxFGrade1.Text.ToUpper().Trim());

                    cmd.ExecuteNonQuery();
                }

                myConn.Close();
                MessageBox.Show("Records inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoadData_Click(sender, e);
            }
            catch (Exception ex)
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConn.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (myConn == null)
                {
                    MessageBox.Show("Database connection is not initialized.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvStudentInfo.CurrentRow == null)
                {
                    MessageBox.Show("No record selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

                int StudID = Convert.ToInt32(dgvStudentInfo.CurrentRow.Cells[0].Value);

                myConn.Open();

                string[] tables = { "FinalGrade", "SubjectsEnrolled", "Student" };

                foreach (string table in tables)
                {
                    using (OleDbCommand cmd = new OleDbCommand($"DELETE FROM {table} WHERE StudentID = ?", myConn))
                    {
                        cmd.Parameters.AddWithValue("?", StudID);
                        cmd.ExecuteNonQuery();
                    }
                }

                myConn.Close();
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLoadData_Click(sender, e);
            }
            catch (Exception ex)
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();

                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowsAffected = 0;
            try
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvStudentInfo.CurrentRow == null)
                {
                    MessageBox.Show("No record selected for updating!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbxLname.Text) || string.IsNullOrWhiteSpace(tbxFname.Text) ||
                    string.IsNullOrWhiteSpace(tbxCourse.Text) || string.IsNullOrWhiteSpace(tbxCourseNo.Text) ||
                    string.IsNullOrWhiteSpace(tbxFGrade1.Text) || string.IsNullOrWhiteSpace(tbxYlevel.Text))
                {
                    MessageBox.Show("Empty inputs. Please fill all the necessary information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                myConn.Open();

                int StudID = Convert.ToInt32(dgvStudentInfo.CurrentRow.Cells[0].Value);
                string lastName = tbxLname.Text.Trim().ToLower();
                string firstName = tbxFname.Text.Trim().ToLower();

                string checkQuery = "SELECT COUNT(*) FROM [Grade Query] WHERE LCase(Trim(LastName)) = ? AND LCase(Trim(FirstName)) = ? AND StudentID <> ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                {
                    checkCmd.Parameters.AddWithValue("?", lastName);
                    checkCmd.Parameters.AddWithValue("?", firstName);
                    checkCmd.Parameters.AddWithValue("?", StudID);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This makes a duplicate entry! This student already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        myConn.Close();
                        return;
                    }
                }
                myConn.Close();
                myConn.Open();

                string query = "UPDATE [Grade Query] SET LastName = ?, FirstName = ?, Course = ?, YearLevel = ?, CourseNum1 = ?, FG1 = ? WHERE StudentID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("?", tbxLname.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", tbxFname.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", tbxCourse.Text.ToUpper().Trim());

                    if (!int.TryParse(tbxYlevel.Text.Trim(), out int yearLevel))
                    {
                        MessageBox.Show("Invalid Year Level. Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        myConn.Close();
                        return;
                    }
                    cmd.Parameters.AddWithValue("?", yearLevel);

                    cmd.Parameters.AddWithValue("?", tbxCourseNo.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", tbxFGrade1.Text.Trim());
                    cmd.Parameters.AddWithValue("?", StudID);

                    rowsAffected = cmd.ExecuteNonQuery();
                }

                myConn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLoadData_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No record found with the given ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnConnectionTest_Click(sender, e);
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoadData_Click(sender, e);
        }
    }
}
