using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Defines an SqlConnection class to connect to the SQL Server database with a connection string.
        SqlConnection sqlConnection = new SqlConnection("Data Source = DESKTOP-7R9PFD3; Initial Catalog = BookReadingActivity; Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {
            List();

            // Adds options to the ReaderGender combo box.
            ReaderGenderCmbBx.Items.Add("Male");
            ReaderGenderCmbBx.Items.Add("Female");
            ReaderGenderCmbBx.Items.Add("Other");

            // Adds book genres to the BookGenre combo box.
            string[] bookGenre = {"Fiction", "Mystery", "Science Fiction", "Fantasy", "Romance","Science",
                                  "Thriller", "Biography","Self-Help", "History", "Horror", "Adventure", "Poetry",
                                  "Travel", "Novel", "Business", "Religion", "Philosophy", "Letter"};

            BookGenreCmbBx.Items.AddRange(bookGenre);
        }

        private void List()
        {
            /*  The List method retrieves all records from the "ReadingList" table, displays them in a DataGridView,
                and updates a label with the total record count. */

            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ReadingList ORDER BY Time", sqlConnection);
            DataTable Table = new DataTable();
            dataAdapter.Fill(Table);
            dataGridView1.DataSource = Table;
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ReadingList", sqlConnection);
            int rowCount = (int)command.ExecuteScalar();
            sqlConnection.Close();
            ReaderCountLbl.Text = rowCount.ToString();
        }


        /* GenerateUniqueReaderCode ensures that the generated reader code is unique by repeatedly calling GenerateReaderCode and checking 
         it against a HashSet of used codes. GenerateReaderCode itself creates a random code by adding "R" and a number to ensure uniqueness. */

        private HashSet<string> usedReaderCodes = new HashSet<string>(); //A HashSet to store used reader codes.
        private string GenerateUniqueReaderCode()
        {
            string readerCode;
            do
            {
                readerCode = GenerateReaderCode();

            } while (usedReaderCodes.Contains(readerCode));

            usedReaderCodes.Add(readerCode);

            return readerCode;
        }
        private string GenerateReaderCode()
        {
            Random random = new Random();
            int code = random.Next(1000, 9999);

            return ("R" + code.ToString());  //Create the reader code by adding "R" at the beginning of the code.
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            /* This method generates a unique reader code, retrieves user input, inserts a new record into the database table with the provided data, 
               and updates the displayed data on the form. */

            string readerCode = GenerateUniqueReaderCode();
            MessageBox.Show("Okuyucu Kodu: " + readerCode);

            string t1 = ReaderNameTxtBx.Text;
            string t2 = ReaderAgeTxtBx.Text;
            string t3 = ReaderGenderCmbBx.SelectedItem.ToString();
            string t4 = BookNameTxtBx.Text;
            string t5 = BookAuthorTxtBx.Text;
            string t6 = BookGenreCmbBx.SelectedItem.ToString();
            string t7 = DateTime.Now.ToString("HH:mm:ss");

            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("INSERT INTO ReadingList (ReaderCode, ReaderName, ReaderAge, ReaderGender, BookName, BookAuthor, BookGenre, Time)" +
                "VALUES (@ReaderCode, @ReaderName, @ReaderAge, @ReaderGender, @BookName, @BookAuthor, @BookGenre, @Time)", sqlConnection))
            {
                command.Parameters.AddWithValue("@ReaderCode", readerCode);
                command.Parameters.AddWithValue("@ReaderName", t1);
                command.Parameters.AddWithValue("@ReaderAge", t2);
                command.Parameters.AddWithValue("@ReaderGender", t3);
                command.Parameters.AddWithValue("@BookName", t4);
                command.Parameters.AddWithValue("@BookAuthor", t5);
                command.Parameters.AddWithValue("@BookGenre", t6);
                command.Parameters.AddWithValue("@Time", t7);

                command.ExecuteNonQuery();
            }
            sqlConnection.Close();
            List();

            ReaderNameTxtBx.Clear();
            ReaderAgeTxtBx.Clear();
            ReaderGenderCmbBx.SelectedItem = null;
            BookNameTxtBx.Clear();
            BookAuthorTxtBx.Clear();
            BookGenreCmbBx.SelectedItem = null;
        }


        private void EnterCodeTxtBx_Click(object sender, EventArgs e)
        {
            // This line of code clears the text inside the EnterCodeTxtBx text box when the user clicks on it.
            EnterCodeTxtBx.Clear();
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            /* This method allows users to input a reader code, and when they click the "Delete" button, 
             it deletes the corresponding record from the database table "ReadingList" based on the provided reader code. */

            string delCode = EnterCodeTxtBx.Text;

            sqlConnection.Open();
            using (SqlCommand command = new SqlCommand("DELETE FROM ReadingList WHERE ReaderCode = @ReaderCode", sqlConnection))
            {
                command.Parameters.AddWithValue("@ReaderCode", delCode);
                command.ExecuteNonQuery();
            }
            sqlConnection.Close();
            List();
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            /* This method allows users to edit the details of an existing record in the "ReadingList" table based on user input and updates the database accordingly. */

            string t1 = ReaderNameTxtBx.Text;
            string t2 = ReaderAgeTxtBx.Text;
            string t3 = ReaderGenderCmbBx.SelectedItem.ToString();
            string t4 = BookNameTxtBx.Text;
            string t5 = BookAuthorTxtBx.Text;
            string t6 = BookGenreCmbBx.SelectedItem.ToString();

            string selectedReaderCode = dataGridView1.CurrentRow.Cells["ReaderCode"].Value.ToString();

            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("UPDATE ReadingList SET ReaderName = @ReaderName, ReaderAge = @ReaderAge, ReaderGender = @ReaderGender, " +
                          "BookName = @BookName, BookAuthor = @BookAuthor, BookGenre = @BookGenre WHERE ReaderCode = @ReaderCode", sqlConnection))
            {
                command.Parameters.AddWithValue("@ReaderCode", selectedReaderCode);
                command.Parameters.AddWithValue("@ReaderName", t1);
                command.Parameters.AddWithValue("@ReaderAge", t2);
                command.Parameters.AddWithValue("@ReaderGender", t3);
                command.Parameters.AddWithValue("@BookName", t4);
                command.Parameters.AddWithValue("@BookAuthor", t5);
                command.Parameters.AddWithValue("@BookGenre", t6);

                command.ExecuteNonQuery();
            }
            sqlConnection.Close();
            List();
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // This method clear all records from the "ReadingList" table in the database

            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("DELETE FROM ReadingList", sqlConnection))

            {
              command.ExecuteNonQuery();
            }
            sqlConnection.Close();
            List();
        }


        private void GetReaderBtn_Click(object sender, EventArgs e)
        {
            /* This method allows users to enter a reader code, click a button, and retrieve the information of the corresponding reader from
               the "ReadingList" table in the database. The retrieved data is displayed in the DataGridView on the form for further viewing or editing. */

            string enteredCode = EnterCodeTxtBx.Text;

            sqlConnection.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM ReadingList WHERE ReaderCode = @EnteredCode", sqlConnection))
            {
                cmd.Parameters.AddWithValue("@EnteredCode", enteredCode);

                dataGridView1.DataSource = null;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* This method allows users to click on a row in the DataGridView, and it populates various input fields with the data
               from the selected row, allowing for easy editing of the selected record. */

            string selectedValue = dataGridView1.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
            EnterCodeTxtBx.Text = selectedValue;

            ReaderNameTxtBx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ReaderAgeTxtBx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ReaderGenderCmbBx.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value;
            BookNameTxtBx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            BookAuthorTxtBx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            BookGenreCmbBx.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // This method allows to view the most up-to-date data.

            List();
        }


        private void RaffleBtn_Click_1(object sender, EventArgs e)
        {
            // Retrieve all records from the database
            Dictionary<string, string> readerCodeToName = new Dictionary<string, string>();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT ReaderCode, ReaderName FROM ReadingList", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string readerCode = reader["ReaderCode"].ToString();
                string readerName = reader["ReaderName"].ToString();
                readerCodeToName.Add(readerCode, readerName);
            }
            sqlConnection.Close();

            // If there are no readers to participate
            if (readerCodeToName.Count == 0)
            {
                MessageBox.Show("There are no readers to participate in the raffle.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Select a random winner
            Random random = new Random();
            int randomIndex = random.Next(0, readerCodeToName.Count);
            string winnerCode = readerCodeToName.Keys.ElementAt(randomIndex);
            string winnerName = readerCodeToName[winnerCode];

            // Display the winner
            RaffleResultLbl.Text = "Winner:  " + winnerCode + "/  " + winnerName;
        }
    }
}