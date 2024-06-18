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


namespace Hotel_Project_Portfolio
{
    public partial class BookRes : Form
    {
        public BookRes()
        {
            InitializeComponent();
        }

        private void lstRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void PopulateRoomList()
        {
            try
            {
                //SQL Server Connection String
                string serverName = @"LAPTOP-OQ3O82NV\SQLEXPRESS";
                string databaseName = "Hotel_Proj";
                string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

                int gstNum = (int)numericUpDown1.Value;

                // SQL query to select data from the database
                string query = "SELECT room_number FROM Rooms WHERE capacity >= @GstNum";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GstNum", gstNum);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lstRoomNum.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader["room_number"].ToString();

                                lstRoomNum.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred: ");
            }
        }

        private void BookRes_Load(object sender, EventArgs e)
        {
            PopulateRoomList();
        }

        //numericUpDown1 = number of guests
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PopulateRoomList();
        }

        //button1 = Create Booking
        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = @"LAPTOP-OQ3O82NV\SQLEXPRESS";
            string databaseName = "Hotel_Proj";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            // SQL query to insert a new reservation
            string insertQuery = "INSERT INTO Reservations (reservation_number, guest_first_name, guest_last_name, start_date, end_date, room_number, number_of_guests) VALUES (@ReservationNumber, @FirstName, @LastName, @StartDate, @EndDate, @RoomNumber, @NumberOfGuests)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //Iterate Reservation Number
                    string maxResQuery = "SELECT MAX(reservation_number) FROM Reservations";
                    using (SqlCommand maxResCommand = new SqlCommand(maxResQuery, connection))
                    {
                        object result = maxResCommand.ExecuteScalar();
                        int resNum = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            // Add parameters
                            insertCommand.Parameters.AddWithValue("@ReservationNumber", resNum);
                            insertCommand.Parameters.AddWithValue("@FirstName", gstFName.Text);
                            insertCommand.Parameters.AddWithValue("@LastName", gstLName.Text);
                            insertCommand.Parameters.AddWithValue("@StartDate", SDate.Value);
                            insertCommand.Parameters.AddWithValue("@EndDate", EDate.Value);
                            insertCommand.Parameters.AddWithValue("@RoomNumber", lstRoomNum.Text);
                            insertCommand.Parameters.AddWithValue("@NumberOfGuests", numericUpDown1.Value);

                            // Execute the command
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Reservation added successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add reservation.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
    
}
