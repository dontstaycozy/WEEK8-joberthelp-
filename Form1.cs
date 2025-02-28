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
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\fredwil\\Desktop\\College\\2nd year 2nd semester AAAAAAAAAAAAAAAA\\CPE262 (OOP2)\\CPE262 Progam Files and Codes\\WEEK8_databaseprac_msaccess-master\\SchoolDatabase.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\fredwil\\Desktop\\College\\2nd year 2nd semester AAAAAAAAAAAAAAAA\\CPE262 (OOP2)\\CPE262 Progam Files and Codes\\WEEK8_databaseprac_msaccess-master\\SchoolDatabase.accdb");
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
            string query = "Insert into Student (LastName, FirstName) values (@LName, @FName)";
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\fredwil\\Desktop\\College\\2nd year 2nd semester AAAAAAAAAAAAAAAA\\CPE262 (OOP2)\\CPE262 Progam Files and Codes\\WEEK8_databaseprac_msaccess-master\\SchoolDatabase.accdb");

            myConn.Open();




            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dgvStudentInfo.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = @Lname Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ln", tbxLname.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
                tbxID.Text = row.Cells[0].Value.ToString();
        }
    }
}
