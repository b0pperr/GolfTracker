using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GolfTracker
{
    public class DB
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static double sqlDouble(SqlCommand sqlCommand)
        {
            SqlConnection conn = new SqlConnection(CnnVal("GolfTracker"));
            double result = 0;
            conn.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    result += dr.GetDouble(0);
                }
            }
            dr.Close();
            conn.Close();
            return result;
        }

        public static int sqlInt(SqlCommand sqlCommand)
        {
            SqlConnection conn = new SqlConnection(CnnVal("GolfTracker"));
            int result = 0;
            conn.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    result = dr.GetInt32(0);
                }
            }
            dr.Close();
            conn.Close();
            return result;
        }

        public static int userId(string usernameTextSelector)
        {
            SqlConnection conn = new SqlConnection(CnnVal("GolfTracker"));
            SqlCommand getUserId = new SqlCommand("SELECT userId FROM golfers WHERE username = '" + usernameTextSelector + "'" + ";", conn);

            int sqlResult(SqlCommand sqlCommand)
            {
                int result = 0;
                conn.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result = dr.GetInt32(0);
                    }
                }
                dr.Close();
                conn.Close();
                return result;
            }

            return sqlResult(getUserId);
        }

        public static string userFullName(int userId)
        {
            SqlConnection conn = new SqlConnection(CnnVal("GolfTracker"));
            SqlCommand getUserFullName = new SqlCommand("SELECT fullname FROM golfers WHERE userId = " + userId + ";", conn);

            string sqlResult(SqlCommand sqlCommand)
            {
                string result = "";
                conn.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result = dr.GetString(0);
                    }
                }
                dr.Close();
                conn.Close();
                return result;
            }

            return sqlResult(getUserFullName);
        }  

        public static string handicap(int userId)
        {
            SqlConnection conn = new SqlConnection(CnnVal("GolfTracker"));
            int scoreEntries = 0;
            double handicap = 0;
            string hc = "";

            SqlCommand numberOfEntriesCommand = new SqlCommand("SELECT COUNT(*) FROM handicapDifferentials WHERE userId = " + userId + ";", conn);

            int sqlResult(SqlCommand sqlCommand)
            {
                int result = 0;
                conn.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result = dr.GetInt32(0);
                    }
                }
                dr.Close();
                conn.Close();
                return result;
            }

            double sqlResultDouble(SqlCommand sqlCommand)
            {
                double result = 0;
                conn.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result += dr.GetDouble(0);
                    }
                }
                dr.Close();
                conn.Close();
                return result;
            }

            scoreEntries = sqlResult(numberOfEntriesCommand);

            if (scoreEntries <= 6)
            {
                // use lowest 1 differential then *.96
                SqlCommand get_Top_1_Differential_Command = new SqlCommand("SELECT TOP (1) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = sqlResultDouble(get_Top_1_Differential_Command) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 7 || scoreEntries == 8)
            {
                // average of lowest 2 differentials *.96
                SqlCommand get_Top_2_Differential_Command = new SqlCommand("SELECT TOP (2) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_2_Differential_Command) / 2) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 9 || scoreEntries == 10)
            {
                // average of lowest 3 differentials *.96
                SqlCommand get_Top_3_Differential_Command = new SqlCommand("SELECT TOP (3) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_3_Differential_Command) / 3) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 11 || scoreEntries == 12)
            {
                // average of lowest 4 differentials *.96
                SqlCommand get_Top_4_Differential_Command = new SqlCommand("SELECT TOP (4) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_4_Differential_Command) / 4) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 13 || scoreEntries == 14)
            {
                // average of lowest 5 differentials *.96
                SqlCommand get_Top_5_Differential_Command = new SqlCommand("SELECT TOP (5) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_5_Differential_Command) / 5) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 15 || scoreEntries == 16)
            {
                // average of lowest 6 differentials *.96
                SqlCommand get_Top_6_Differential_Command = new SqlCommand("SELECT TOP (6) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_6_Differential_Command) / 6) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 17)
            {
                // average of lowest 7 differentials *.96
                SqlCommand get_Top_7_Differential_Command = new SqlCommand("SELECT TOP (7) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_7_Differential_Command) / 7) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 18)
            {
                // average of lowest 8 differentials *.96
                SqlCommand get_Top_8_Differential_Command = new SqlCommand("SELECT TOP (8) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_8_Differential_Command) / 8) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries == 19)
            {
                // average of lowest 9 differentials *.96
                SqlCommand get_Top_9_Differential_Command = new SqlCommand("SELECT TOP (9) handicapDifferential FROM handicapDifferentials WHERE userId = " + userId + "ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_9_Differential_Command) / 9) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }
            else if (scoreEntries >= 20)
            {
                // average of lowest 10 differentials *.96
                // TODO: make sure you only use the most recent 20 scores
                SqlCommand get_Top_10_Differential_Command = new SqlCommand("SELECT TOP (10) handicapDifferential FROM  handicapDifferentials WHERE userId = " + userId + "datetime IN (SELECT TOP (20) [datetime] FROM [handicapDifferentials] ORDER BY [datetime] DESC) ORDER BY handicapDifferential ASC", conn);
                handicap = (sqlResultDouble(get_Top_10_Differential_Command) / 10) * .96;
                hc = Math.Round(handicap, 1).ToString();
            }

            return hc;
        }

        public static void populateScoresDataView(int user_id, SqlConnection dbConnection, System.Windows.Forms.DataGridView data_grid)
        {
            string getGolferScoresQuery = "SELECT score, courseRating, courseSlope, datetime FROM scores WHERE userId = " + user_id + "ORDER BY datetime DESC;";
            var dataAdapter = new SqlDataAdapter(getGolferScoresQuery, dbConnection);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            data_grid.DataSource = ds.Tables[0];
        }

        public static void populateFIR(int user_id, SqlConnection dbConnection, System.Windows.Forms.Label firTextSelector)
        {
            dbConnection.Open();
            SqlCommand getFIRAmountEntries = new SqlCommand("SELECT COUNT(*) FROM FIR WHERE userId = " + user_id + ";", dbConnection);
            int amountOfFIREntries = sqlInt(getFIRAmountEntries);

            SqlCommand getFIRTotal = new SqlCommand("SELECT FIR FROM FIR WHERE userId = " + user_id + ";", dbConnection);

            if (amountOfFIREntries > 0)
            {
                firTextSelector.Text = Decimal.Round(Convert.ToDecimal((sqlDouble(getFIRTotal) / Convert.ToDouble(amountOfFIREntries))), 1).ToString();
            } else
            {
                firTextSelector.Text = "0";
            }
            
            dbConnection.Close();
        }

        public static void populateGIR(int user_id, SqlConnection dbConnection, System.Windows.Forms.Label girTextSelector)
        {
            dbConnection.Open();
            SqlCommand getGIRAmountEntries = new SqlCommand("SELECT COUNT(*) FROM GIR WHERE userId = " + user_id + ";", dbConnection);
            int amountOfGIREntries = sqlInt(getGIRAmountEntries);

            SqlCommand getGIRTotal = new SqlCommand("SELECT GIR FROM GIR WHERE userId = " + user_id + ";", dbConnection);

            if (amountOfGIREntries > 0)
            {
                girTextSelector.Text = Decimal.Round(Convert.ToDecimal((sqlDouble(getGIRTotal) / Convert.ToDouble(amountOfGIREntries))), 1).ToString();
            }
            else
            {
                girTextSelector.Text = "0";
            }

            dbConnection.Close();
        }

        public static void populateScrambling(int user_id, SqlConnection dbConnection, System.Windows.Forms.Label scramblingTextSelector)
        {
            dbConnection.Open();
            SqlCommand getScramblingEntries = new SqlCommand("SELECT COUNT(*) FROM scramblePercentage WHERE userId = " + user_id + ";", dbConnection);
            int amountOfScramblingEntries = sqlInt(getScramblingEntries);

            SqlCommand getScramblingTotal = new SqlCommand("SELECT scramblepercentage FROM scramblePercentage WHERE userId = " + user_id + ";", dbConnection);

            if (amountOfScramblingEntries > 0)
            {
                scramblingTextSelector.Text = Decimal.Round(Convert.ToDecimal((sqlDouble(getScramblingTotal) / Convert.ToDouble(amountOfScramblingEntries))), 1).ToString();
            }
            else
            {
                scramblingTextSelector.Text = "0";
            }

            dbConnection.Close();
        }

        public static void populatePPR(int user_id, SqlConnection dbConnection, System.Windows.Forms.Label pprTextSelector)
        {
            dbConnection.Open();
            SqlCommand getPPREntries = new SqlCommand("SELECT COUNT(*) FROM PPR WHERE userId = " + user_id + ";", dbConnection);
            int amountOfPPREntries = sqlInt(getPPREntries);

            SqlCommand getPPRTotal = new SqlCommand("SELECT PPR FROM PPR WHERE userId = " + user_id + ";", dbConnection);

            if (amountOfPPREntries > 0)
            {
                pprTextSelector.Text = Decimal.Round(Convert.ToDecimal((sqlDouble(getPPRTotal) / Convert.ToDouble(amountOfPPREntries))), 1).ToString();
            }
            else
            {
                pprTextSelector.Text = "0";
            }

            dbConnection.Close();
        }

        public static void populateRoundsSubmitted(int user_id, SqlConnection dbConnection, System.Windows.Forms.Label roundsSubmittedSelector)
        {
            dbConnection.Open();
            SqlCommand getRoundsSubmitted = new SqlCommand("SELECT COUNT(*) FROM scores WHERE userId = " + user_id + ";", dbConnection);
            int amountOfRounds = sqlInt(getRoundsSubmitted);

            if (amountOfRounds > 0)
            {
                roundsSubmittedSelector.Text = amountOfRounds.ToString();
            }
            else
            {
                roundsSubmittedSelector.Text = "0";
            }

            dbConnection.Close();
        }
    }
}
