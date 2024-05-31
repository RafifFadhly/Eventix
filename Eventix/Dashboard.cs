using Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encrypt;

namespace Eventix
{
    public partial class Dashboard : Form
    {
        public Parent farent;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                if (farent.login.role == "penyelenggara")
                {
                    admin.Visible = false;
                    panitia.Visible = false;
                    user.Visible = false;
                }
                else
                {
                    jml_event_dh.Visible = false;
                    jml_pemasukan_dh.Visible = false;
                    jml_pembeli_dh.Visible = false;
                }
                RefreshDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}");
            }
        }

        private void RefreshDashboardData()
        {
            try
            {
                Admin_sum.Text = GetRowCount("pengguna", " WHERE Level = '"+CaesarCipher.Encrypt("admin")+"'").ToString();
                Pengguna.Text = GetRowCount("pengguna", " WHERE Level = '"+ CaesarCipher.Encrypt("user") + "'").ToString();
                penyelenggara.Text = GetRowCount("pengguna", " WHERE Level = '"+ CaesarCipher.Encrypt("penyelenggara") + "'").ToString();
                Jml_Event.Text = GetRowCount("event", $" WHERE ID_Penyelenggara = '{farent.login.id}'").ToString();
                pemasukan.Text = GetColumnSum("rekap_tiket", "total").ToString();
                jml_pembeli_dh.Text = GetRowCount("rekap_tiket", $" WHERE Penyelenggara_id = '{farent.login.id}'").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing dashboard data: {ex.Message}");
            }
        }

        public decimal GetColumnSum(string tableName, string columnName)
        {
            decimal totalSum = 0;
            string query = $"SELECT SUM({columnName}) AS total_sum FROM {tableName}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                totalSum = reader.GetDecimal(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting column sum: {ex.Message}");
            }

            return totalSum;
        }

        public int GetRowCount(string tableName, string queryAdditional)
        {
            int totalCount = 0;

            // Basic validation for tableName to prevent SQL Injection
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentException("Table name cannot be null or empty.");
            }

            // Optional: Additional validation for tableName to allow only alphanumeric and underscores
            if (!Regex.IsMatch(tableName, @"^[a-zA-Z0-9_]+$"))
            {
                throw new ArgumentException("Table name can only contain alphanumeric characters and underscores.");
            }

            string query = $"SELECT COUNT(*) AS total_rows FROM {tableName} {queryAdditional}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(database_String.connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                totalCount = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting row count: {ex.Message}");
            }

            return totalCount;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}");
            }
        }
    }
}
