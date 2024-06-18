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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            try
            {
                // Replace "YourServerName" with the name or IP address of your SQL Server instance
                string serverName = @"LAPTOP-OQ3O82NV\SQLEXPRESS";
                // Replace "YourDatabaseName" with the name of your SQL Server database
                string databaseName = "Hotel_Proj";
                

                // Construct the connection string
                string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

                // Create a SqlConnection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    lblSQLTEST.Text = "Database connection successful";

                    // Use the connection for database operations
                    // For example: querying data, updating data, etc.

                    // Don't forget to close the connection when done
                    connection.Close();
                }
            }
            catch
            {
                lblSQLTEST.Text = "Database connection failure";
            }
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRes bookRes = new BookRes();
            bookRes.Show();
        }

        private void modifyReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyRes modres = new ModifyRes();
            modres.Show();
        }
    }
}
