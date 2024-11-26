using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ClubRegistration
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\ClubDB.mdf;Integrated Security=True";

            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMemberes = "SELECT StudentID, FirstName, MiddleName, Lastname, Age, Gender, Program FROM ClubMembers";

            sqlAdapter = new SqlDataAdapter(ViewClubMemberes, sqlConnect);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }

        public void GetStudentIDList(ArrayList StudentIDList)
        {
            sqlConnect.Open();

            sqlCommand = new SqlCommand("SELECT StudentID FROM ClubMembers", sqlConnect);
            sqlReader = sqlCommand.ExecuteReader();

            while(sqlReader.Read())
            {
                StudentIDList.Add(sqlReader.GetInt64(0));
            }
            sqlReader.Close();
            sqlConnect.Close();
        }

        public void GetStudentInfo(string StudentID)
        {

            sqlConnect.Open();

            sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentID = @studentid", sqlConnect);
            sqlCommand.Parameters.AddWithValue("@studentid", long.Parse(StudentID));
            sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.Read())
            {
                _FirstName = sqlReader.GetString(0);
                _MiddleName = sqlReader.GetString(1);
                _LastName = sqlReader.GetString(2);
                _Age = sqlReader.GetInt32(3);
                _Gender = sqlReader.GetString(4);
                _Program = sqlReader.GetString(5);
            }

            sqlReader.Close();
            sqlConnect.Close();

        }

        public void UpdateInformation(string StudentID)
        {
            sqlConnect.Open();

            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @firstname, MiddleName = @middlename, " +
                "LastName = @lastname, Age = @age, Gender = @gender, Program = @program WHERE StudentID = @studentid", sqlConnect);
            sqlCommand.Parameters.AddWithValue("@studentid", long.Parse(StudentID));
            sqlCommand.Parameters.AddWithValue("@firstname", _FirstName);
            sqlCommand.Parameters.AddWithValue("@middlename", _MiddleName);
            sqlCommand.Parameters.AddWithValue("@lastname", _LastName);
            sqlCommand.Parameters.AddWithValue("@age", _Age);
            sqlCommand.Parameters.AddWithValue("@gender", _Gender);
            sqlCommand.Parameters.AddWithValue("@program", _Program);
            sqlCommand.ExecuteNonQuery();

            sqlConnect.Close();
        }

        public bool RegisterStudent(long StudentID, string FirstName, string MiddleName, string LastName,
            int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES (@StudentID, @FirstName, @MiddleName," +
                " @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }
    }
}
