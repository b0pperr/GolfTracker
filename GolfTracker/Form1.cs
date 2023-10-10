using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfTracker
{
    public partial class Form1 : Form
    {
        //DB db = new DB();
        private int userId;
        private string userFullName;
        SqlConnection conn = new SqlConnection(DB.CnnVal("GolfTracker"));

        public Form1()
        {
            InitializeComponent();
        }

        private void submitScoreButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Calculate score subission handicap differential
            decimal hcDifferential = ((decimal.Parse(scoreInput.Text) - decimal.Parse(courseRatingInput.Text)) * 113) / decimal.Parse(courseSlopeInput.Text);

            // Add score submission to dbo.scores
            string scoresQuery = "INSERT INTO [scores] (score, courseRating, courseSlope, datetime, userId) VALUES (@score, @courseRating, @courseSlope, @datetime, @userId);";
            // Add handicap differential to dbo.handicapDifferentials
              scoresQuery += " INSERT INTO [handicapDifferentials] (scoreId, handicapDifferential, datetime, userId) VALUES (SCOPE_IDENTITY(), @handicapDifferential, @datetime, @userId)";

            SqlCommand scoresCommand = new SqlCommand(scoresQuery, conn);
            scoresCommand.Parameters.AddWithValue("@score", scoreInput.Text);
            scoresCommand.Parameters.AddWithValue("@courseRating", courseRatingInput.Text);
            scoresCommand.Parameters.AddWithValue("@courseSlope", courseSlopeInput.Text);
            scoresCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
            scoresCommand.Parameters.AddWithValue("@handicapDifferential", Decimal.Round(hcDifferential, 1));
            scoresCommand.Parameters.AddWithValue("@userId", userId);
            scoresCommand.ExecuteNonQuery();

            DB.populateScoresDataView(userId, conn, pastScoresDataGrid);

            conn.Close();

            currentHandicapText.Text = DB.handicap(userId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chooseGolferSubmitButton_Click(object sender, EventArgs e)
        {
            userId = DB.userId(chooseGolferInput.Text);
            userFullName = DB.userFullName(userId);
            golferNameText.Text = userFullName;
            this.golferNameText.Visible = true;

            currentHandicapText.Text = DB.handicap(userId);

            DB.populateScoresDataView(userId, conn, pastScoresDataGrid);
            DB.populateFIR(userId, conn, FIRtext);
            DB.populateGIR(userId, conn, GIRtext);
            DB.populateScrambling(userId, conn, scramblingText);
            DB.populatePPR(userId, conn, PPRtext);
            DB.populateRoundsSubmitted(userId, conn, roundsSubmittedText);  

            this.chooseGolferPanel.Visible = false;
        }

        private void submitNewGolferButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Add golfer to dbo.golfers
            string addNewGolferQuery = "INSERT INTO [golfers] (username, fullname) VALUES (@username, @fullname);";

            SqlCommand addNewGolferCommand = new SqlCommand(addNewGolferQuery, conn);
            addNewGolferCommand.Parameters.AddWithValue("@username", newGolfer_UsernameInput.Text);
            addNewGolferCommand.Parameters.AddWithValue("@fullname", newGolfer_UserFullNameInput.Text);
            addNewGolferCommand.ExecuteNonQuery();

            conn.Close();

            newGolfer_UsernameInput.Text = "";
            newGolfer_UserFullNameInput.Text = "";
        }

        private void submitFIRButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Add FIR submission to dbo.FIR
            string addNewFIRQuery = "INSERT INTO [FIR] (FIR, datetime, userId) VALUES (@FIR, @datetime, @userId);";

            SqlCommand addNewFIRCommand = new SqlCommand(addNewFIRQuery, conn);
            addNewFIRCommand.Parameters.AddWithValue("@FIR", firInput.Text);
            addNewFIRCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
            addNewFIRCommand.Parameters.AddWithValue("@userId", userId);
            addNewFIRCommand.ExecuteNonQuery();
            conn.Close();

            DB.populateFIR(userId, conn, FIRtext);

            firInput.Text = "";      
        }

        private void submitGIRButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Add GIR submission to dbo.GIR
            string addNewGIRQuery = "INSERT INTO [GIR] (GIR, datetime, userId) VALUES (@GIR, @datetime, @userId);";

            SqlCommand addNewGIRCommand = new SqlCommand(addNewGIRQuery, conn);
            addNewGIRCommand.Parameters.AddWithValue("@GIR", girInput.Text);
            addNewGIRCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
            addNewGIRCommand.Parameters.AddWithValue("@userId", userId);
            addNewGIRCommand.ExecuteNonQuery();
            conn.Close();

            DB.populateGIR(userId, conn, GIRtext);

            girInput.Text = "";
        }

        private void submitScrambleButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Add scrambling percent submission to dbo.scramblePercentage
            string addNewScrambleQuery = "INSERT INTO [scramblePercentage] (scramblepercentage, datetime, userId) VALUES (@scramblepercentage, @datetime, @userId);";

            SqlCommand addNewScrambleCommand = new SqlCommand(addNewScrambleQuery, conn);
            addNewScrambleCommand.Parameters.AddWithValue("@scramblepercentage", scramblingInput.Text);
            addNewScrambleCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
            addNewScrambleCommand.Parameters.AddWithValue("@userId", userId);
            addNewScrambleCommand.ExecuteNonQuery();
            conn.Close();

            DB.populateScrambling(userId, conn, scramblingText);

            scramblingInput.Text = "";
        }

        private void submitPPRButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Add ppr submission to dbo.PPR
            string addNewPPRQuery = "INSERT INTO [PPR] (PPR, datetime, userId) VALUES (@PPR, @datetime, @userId);";

            SqlCommand addNewPPRCommand = new SqlCommand(addNewPPRQuery, conn);
            addNewPPRCommand.Parameters.AddWithValue("@PPR", pprInput.Text);
            addNewPPRCommand.Parameters.AddWithValue("@datetime", DateTime.Now);
            addNewPPRCommand.Parameters.AddWithValue("@userId", userId);
            addNewPPRCommand.ExecuteNonQuery();
            conn.Close();

            DB.populatePPR(userId, conn, PPRtext);

            pprInput.Text = "";
        }

        private void addNewUserPanel_DoubleClick(object sender, EventArgs e)
        {
            this.addNewGolferPanel.Visible = false;
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addNewGolferPanel.Visible = true;
        }

        private void choosePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chooseGolferPanel.Visible = true;
        }

        private void chooseGolferPanel_DoubleClick(object sender, EventArgs e)
        {
            this.chooseGolferPanel.Visible = false;
        }
    }
}
