namespace GolfTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseRatingInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseSlopeInput = new System.Windows.Forms.TextBox();
            this.submitScoreButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.golfTrackerDataSet = new GolfTracker.GolfTrackerDataSet();
            this.golfTrackerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pastScoresDataGrid = new System.Windows.Forms.DataGridView();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.golfTrackerDataSet1 = new GolfTracker.GolfTrackerDataSet1();
            this.scoresTableAdapter = new GolfTracker.GolfTrackerDataSet1TableAdapters.scoresTableAdapter();
            this.handicapLabel = new System.Windows.Forms.Label();
            this.currentHandicapText = new System.Windows.Forms.Label();
            this.FIRtext = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GIRtext = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PPRtext = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundsSubmittedText = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.golferNameText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllPlayerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGolferPanel = new System.Windows.Forms.Panel();
            this.submitNewGolferButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.newGolfer_UserFullNameInput = new System.Windows.Forms.TextBox();
            this.newGolfer_UsernameInput = new System.Windows.Forms.TextBox();
            this.chooseGolferPanel = new System.Windows.Forms.Panel();
            this.chooseGolferSubmitButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.chooseGolferInput = new System.Windows.Forms.TextBox();
            this.golfTrackerDataSet11 = new GolfTracker.GolfTrackerDataSet1();
            this.submitPPRButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pprInput = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.girInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.firInput = new System.Windows.Forms.TextBox();
            this.submitGIRButton = new System.Windows.Forms.Button();
            this.submitFIRButton = new System.Windows.Forms.Button();
            this.submitScrambleButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.scramblingInput = new System.Windows.Forms.TextBox();
            this.scramblingText = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSlopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastScoresDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.addNewGolferPanel.SuspendLayout();
            this.chooseGolferPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(526, 385);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(67, 22);
            this.scoreInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(524, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(523, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Rating";
            // 
            // courseRatingInput
            // 
            this.courseRatingInput.Location = new System.Drawing.Point(525, 432);
            this.courseRatingInput.Name = "courseRatingInput";
            this.courseRatingInput.Size = new System.Drawing.Size(67, 22);
            this.courseRatingInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(523, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Slope";
            // 
            // courseSlopeInput
            // 
            this.courseSlopeInput.Location = new System.Drawing.Point(525, 479);
            this.courseSlopeInput.Name = "courseSlopeInput";
            this.courseSlopeInput.Size = new System.Drawing.Size(67, 22);
            this.courseSlopeInput.TabIndex = 4;
            // 
            // submitScoreButton
            // 
            this.submitScoreButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitScoreButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submitScoreButton.Location = new System.Drawing.Point(607, 475);
            this.submitScoreButton.Name = "submitScoreButton";
            this.submitScoreButton.Size = new System.Drawing.Size(85, 29);
            this.submitScoreButton.TabIndex = 6;
            this.submitScoreButton.Text = "Submit Score";
            this.submitScoreButton.UseVisualStyleBackColor = true;
            this.submitScoreButton.Click += new System.EventHandler(this.submitScoreButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Past Scores";
            // 
            // golfTrackerDataSet
            // 
            this.golfTrackerDataSet.DataSetName = "GolfTrackerDataSet";
            this.golfTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // golfTrackerDataSetBindingSource
            // 
            this.golfTrackerDataSetBindingSource.DataSource = this.golfTrackerDataSet;
            this.golfTrackerDataSetBindingSource.Position = 0;
            // 
            // pastScoresDataGrid
            // 
            this.pastScoresDataGrid.AllowUserToAddRows = false;
            this.pastScoresDataGrid.AllowUserToDeleteRows = false;
            this.pastScoresDataGrid.AutoGenerateColumns = false;
            this.pastScoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastScoresDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreDataGridViewTextBoxColumn,
            this.courseRatingDataGridViewTextBoxColumn,
            this.courseSlopeDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.pastScoresDataGrid.DataSource = this.scoresBindingSource;
            this.pastScoresDataGrid.Location = new System.Drawing.Point(12, 362);
            this.pastScoresDataGrid.Name = "pastScoresDataGrid";
            this.pastScoresDataGrid.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastScoresDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pastScoresDataGrid.Size = new System.Drawing.Size(495, 267);
            this.pastScoresDataGrid.TabIndex = 10;
            // 
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "scores";
            this.scoresBindingSource.DataSource = this.golfTrackerDataSet1;
            // 
            // golfTrackerDataSet1
            // 
            this.golfTrackerDataSet1.DataSetName = "GolfTrackerDataSet1";
            this.golfTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // handicapLabel
            // 
            this.handicapLabel.AutoSize = true;
            this.handicapLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handicapLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.handicapLabel.Location = new System.Drawing.Point(5, 14);
            this.handicapLabel.Name = "handicapLabel";
            this.handicapLabel.Size = new System.Drawing.Size(144, 21);
            this.handicapLabel.TabIndex = 11;
            this.handicapLabel.Text = "Current Handicap";
            // 
            // currentHandicapText
            // 
            this.currentHandicapText.AutoSize = true;
            this.currentHandicapText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHandicapText.ForeColor = System.Drawing.SystemColors.Control;
            this.currentHandicapText.Location = new System.Drawing.Point(3, 14);
            this.currentHandicapText.Name = "currentHandicapText";
            this.currentHandicapText.Size = new System.Drawing.Size(19, 21);
            this.currentHandicapText.TabIndex = 12;
            this.currentHandicapText.Text = "0";
            // 
            // FIRtext
            // 
            this.FIRtext.AutoSize = true;
            this.FIRtext.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRtext.ForeColor = System.Drawing.SystemColors.Control;
            this.FIRtext.Location = new System.Drawing.Point(3, 35);
            this.FIRtext.Name = "FIRtext";
            this.FIRtext.Size = new System.Drawing.Size(19, 21);
            this.FIRtext.TabIndex = 16;
            this.FIRtext.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(116, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "FIR";
            // 
            // GIRtext
            // 
            this.GIRtext.AutoSize = true;
            this.GIRtext.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIRtext.ForeColor = System.Drawing.SystemColors.Control;
            this.GIRtext.Location = new System.Drawing.Point(3, 56);
            this.GIRtext.Name = "GIRtext";
            this.GIRtext.Size = new System.Drawing.Size(19, 21);
            this.GIRtext.TabIndex = 18;
            this.GIRtext.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(113, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "GIR";
            // 
            // PPRtext
            // 
            this.PPRtext.AutoSize = true;
            this.PPRtext.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPRtext.ForeColor = System.Drawing.SystemColors.Control;
            this.PPRtext.Location = new System.Drawing.Point(3, 77);
            this.PPRtext.Name = "PPRtext";
            this.PPRtext.Size = new System.Drawing.Size(19, 21);
            this.PPRtext.TabIndex = 20;
            this.PPRtext.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(109, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "PPR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.roundsSubmittedText);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.golferNameText);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 211);
            this.panel1.TabIndex = 22;
            // 
            // roundsSubmittedText
            // 
            this.roundsSubmittedText.AutoSize = true;
            this.roundsSubmittedText.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsSubmittedText.ForeColor = System.Drawing.SystemColors.Control;
            this.roundsSubmittedText.Location = new System.Drawing.Point(104, 140);
            this.roundsSubmittedText.Name = "roundsSubmittedText";
            this.roundsSubmittedText.Size = new System.Drawing.Size(15, 16);
            this.roundsSubmittedText.TabIndex = 26;
            this.roundsSubmittedText.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(3, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Rounds submitted:";
            // 
            // golferNameText
            // 
            this.golferNameText.AutoSize = true;
            this.golferNameText.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golferNameText.ForeColor = System.Drawing.SystemColors.Control;
            this.golferNameText.Location = new System.Drawing.Point(13, 46);
            this.golferNameText.Name = "golferNameText";
            this.golferNameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.golferNameText.Size = new System.Drawing.Size(102, 17);
            this.golferNameText.TabIndex = 24;
            this.golferNameText.Text = "< golfer name >";
            this.golferNameText.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Golfer";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.scoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choosePlayerToolStripMenuItem,
            this.addPlayerToolStripMenuItem,
            this.removePlayerToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // choosePlayerToolStripMenuItem
            // 
            this.choosePlayerToolStripMenuItem.Name = "choosePlayerToolStripMenuItem";
            this.choosePlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.choosePlayerToolStripMenuItem.Text = "Choose Golfer";
            this.choosePlayerToolStripMenuItem.Click += new System.EventHandler(this.choosePlayerToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Golfer";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removePlayerToolStripMenuItem.Text = "Remove Golfer";
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeScoreToolStripMenuItem,
            this.removeStatsToolStripMenuItem,
            this.removeAllPlayerDataToolStripMenuItem});
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.scoresToolStripMenuItem.Text = "Scores";
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeScoreToolStripMenuItem.Text = "Remove Scores";
            // 
            // removeStatsToolStripMenuItem
            // 
            this.removeStatsToolStripMenuItem.Name = "removeStatsToolStripMenuItem";
            this.removeStatsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeStatsToolStripMenuItem.Text = "Remove Stats";
            // 
            // removeAllPlayerDataToolStripMenuItem
            // 
            this.removeAllPlayerDataToolStripMenuItem.Name = "removeAllPlayerDataToolStripMenuItem";
            this.removeAllPlayerDataToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeAllPlayerDataToolStripMenuItem.Text = "Remove All Player Data";
            // 
            // addNewGolferPanel
            // 
            this.addNewGolferPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addNewGolferPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addNewGolferPanel.Controls.Add(this.submitNewGolferButton);
            this.addNewGolferPanel.Controls.Add(this.label16);
            this.addNewGolferPanel.Controls.Add(this.label15);
            this.addNewGolferPanel.Controls.Add(this.newGolfer_UserFullNameInput);
            this.addNewGolferPanel.Controls.Add(this.newGolfer_UsernameInput);
            this.addNewGolferPanel.Location = new System.Drawing.Point(656, 43);
            this.addNewGolferPanel.Name = "addNewGolferPanel";
            this.addNewGolferPanel.Size = new System.Drawing.Size(229, 205);
            this.addNewGolferPanel.TabIndex = 24;
            this.addNewGolferPanel.Visible = false;
            this.addNewGolferPanel.DoubleClick += new System.EventHandler(this.addNewUserPanel_DoubleClick);
            // 
            // submitNewGolferButton
            // 
            this.submitNewGolferButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitNewGolferButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submitNewGolferButton.Location = new System.Drawing.Point(23, 153);
            this.submitNewGolferButton.Name = "submitNewGolferButton";
            this.submitNewGolferButton.Size = new System.Drawing.Size(110, 33);
            this.submitNewGolferButton.TabIndex = 25;
            this.submitNewGolferButton.Text = "Submit";
            this.submitNewGolferButton.UseVisualStyleBackColor = true;
            this.submitNewGolferButton.Click += new System.EventHandler(this.submitNewGolferButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(22, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Username";
            // 
            // newGolfer_UserFullNameInput
            // 
            this.newGolfer_UserFullNameInput.BackColor = System.Drawing.SystemColors.Info;
            this.newGolfer_UserFullNameInput.Location = new System.Drawing.Point(23, 43);
            this.newGolfer_UserFullNameInput.Name = "newGolfer_UserFullNameInput";
            this.newGolfer_UserFullNameInput.Size = new System.Drawing.Size(122, 22);
            this.newGolfer_UserFullNameInput.TabIndex = 25;
            // 
            // newGolfer_UsernameInput
            // 
            this.newGolfer_UsernameInput.BackColor = System.Drawing.SystemColors.Info;
            this.newGolfer_UsernameInput.Location = new System.Drawing.Point(23, 89);
            this.newGolfer_UsernameInput.Name = "newGolfer_UsernameInput";
            this.newGolfer_UsernameInput.Size = new System.Drawing.Size(123, 22);
            this.newGolfer_UsernameInput.TabIndex = 27;
            // 
            // chooseGolferPanel
            // 
            this.chooseGolferPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chooseGolferPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chooseGolferPanel.Controls.Add(this.chooseGolferSubmitButton);
            this.chooseGolferPanel.Controls.Add(this.label17);
            this.chooseGolferPanel.Controls.Add(this.chooseGolferInput);
            this.chooseGolferPanel.Location = new System.Drawing.Point(421, 43);
            this.chooseGolferPanel.Name = "chooseGolferPanel";
            this.chooseGolferPanel.Size = new System.Drawing.Size(229, 205);
            this.chooseGolferPanel.TabIndex = 29;
            this.chooseGolferPanel.Visible = false;
            this.chooseGolferPanel.DoubleClick += new System.EventHandler(this.chooseGolferPanel_DoubleClick);
            // 
            // chooseGolferSubmitButton
            // 
            this.chooseGolferSubmitButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseGolferSubmitButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.chooseGolferSubmitButton.Location = new System.Drawing.Point(23, 153);
            this.chooseGolferSubmitButton.Name = "chooseGolferSubmitButton";
            this.chooseGolferSubmitButton.Size = new System.Drawing.Size(110, 33);
            this.chooseGolferSubmitButton.TabIndex = 25;
            this.chooseGolferSubmitButton.Text = "Submit";
            this.chooseGolferSubmitButton.UseVisualStyleBackColor = true;
            this.chooseGolferSubmitButton.Click += new System.EventHandler(this.chooseGolferSubmitButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Username";
            // 
            // chooseGolferInput
            // 
            this.chooseGolferInput.BackColor = System.Drawing.SystemColors.Info;
            this.chooseGolferInput.Location = new System.Drawing.Point(22, 75);
            this.chooseGolferInput.Name = "chooseGolferInput";
            this.chooseGolferInput.Size = new System.Drawing.Size(123, 22);
            this.chooseGolferInput.TabIndex = 27;
            // 
            // golfTrackerDataSet11
            // 
            this.golfTrackerDataSet11.DataSetName = "GolfTrackerDataSet1";
            this.golfTrackerDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // submitPPRButton
            // 
            this.submitPPRButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPPRButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submitPPRButton.Location = new System.Drawing.Point(821, 472);
            this.submitPPRButton.Name = "submitPPRButton";
            this.submitPPRButton.Size = new System.Drawing.Size(86, 29);
            this.submitPPRButton.TabIndex = 36;
            this.submitPPRButton.Text = "Submit PPR";
            this.submitPPRButton.UseVisualStyleBackColor = true;
            this.submitPPRButton.Click += new System.EventHandler(this.submitPPRButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(722, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "PPR";
            // 
            // pprInput
            // 
            this.pprInput.Location = new System.Drawing.Point(724, 479);
            this.pprInput.Name = "pprInput";
            this.pprInput.Size = new System.Drawing.Size(67, 22);
            this.pprInput.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(722, 411);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 15);
            this.label18.TabIndex = 33;
            this.label18.Text = "GIR";
            // 
            // girInput
            // 
            this.girInput.Location = new System.Drawing.Point(724, 432);
            this.girInput.Name = "girInput";
            this.girInput.Size = new System.Drawing.Size(67, 22);
            this.girInput.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(723, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 15);
            this.label19.TabIndex = 31;
            this.label19.Text = "FIR";
            // 
            // firInput
            // 
            this.firInput.Location = new System.Drawing.Point(725, 385);
            this.firInput.Name = "firInput";
            this.firInput.Size = new System.Drawing.Size(67, 22);
            this.firInput.TabIndex = 30;
            // 
            // submitGIRButton
            // 
            this.submitGIRButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitGIRButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submitGIRButton.Location = new System.Drawing.Point(821, 425);
            this.submitGIRButton.Name = "submitGIRButton";
            this.submitGIRButton.Size = new System.Drawing.Size(86, 29);
            this.submitGIRButton.TabIndex = 37;
            this.submitGIRButton.Text = "Submit GIR";
            this.submitGIRButton.UseVisualStyleBackColor = true;
            this.submitGIRButton.Click += new System.EventHandler(this.submitGIRButton_Click);
            // 
            // submitFIRButton
            // 
            this.submitFIRButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFIRButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submitFIRButton.Location = new System.Drawing.Point(821, 381);
            this.submitFIRButton.Name = "submitFIRButton";
            this.submitFIRButton.Size = new System.Drawing.Size(86, 29);
            this.submitFIRButton.TabIndex = 38;
            this.submitFIRButton.Text = "Submit FIR";
            this.submitFIRButton.UseVisualStyleBackColor = true;
            this.submitFIRButton.Click += new System.EventHandler(this.submitFIRButton_Click);
            // 
            // submitScrambleButton
            // 
            this.submitScrambleButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitScrambleButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submitScrambleButton.Location = new System.Drawing.Point(821, 519);
            this.submitScrambleButton.Name = "submitScrambleButton";
            this.submitScrambleButton.Size = new System.Drawing.Size(86, 29);
            this.submitScrambleButton.TabIndex = 41;
            this.submitScrambleButton.Text = "Submit %";
            this.submitScrambleButton.UseVisualStyleBackColor = true;
            this.submitScrambleButton.Click += new System.EventHandler(this.submitScrambleButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(723, 504);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 15);
            this.label20.TabIndex = 40;
            this.label20.Text = "Scrambling %";
            // 
            // scramblingInput
            // 
            this.scramblingInput.Location = new System.Drawing.Point(725, 525);
            this.scramblingInput.Name = "scramblingInput";
            this.scramblingInput.Size = new System.Drawing.Size(67, 22);
            this.scramblingInput.TabIndex = 39;
            // 
            // scramblingText
            // 
            this.scramblingText.AutoSize = true;
            this.scramblingText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scramblingText.ForeColor = System.Drawing.SystemColors.Control;
            this.scramblingText.Location = new System.Drawing.Point(3, 98);
            this.scramblingText.Name = "scramblingText";
            this.scramblingText.Size = new System.Drawing.Size(19, 21);
            this.scramblingText.TabIndex = 43;
            this.scramblingText.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(34, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 21);
            this.label22.TabIndex = 42;
            this.label22.Text = "Scrambling %";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(156, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.handicapLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label22);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label21);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.currentHandicapText);
            this.splitContainer1.Panel2.Controls.Add(this.scramblingText);
            this.splitContainer1.Panel2.Controls.Add(this.FIRtext);
            this.splitContainer1.Panel2.Controls.Add(this.GIRtext);
            this.splitContainer1.Panel2.Controls.Add(this.PPRtext);
            this.splitContainer1.Size = new System.Drawing.Size(249, 211);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(42, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 21);
            this.label21.TabIndex = 47;
            this.label21.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(42, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 21);
            this.label10.TabIndex = 46;
            this.label10.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(42, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "%";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseRatingDataGridViewTextBoxColumn
            // 
            this.courseRatingDataGridViewTextBoxColumn.DataPropertyName = "courseRating";
            this.courseRatingDataGridViewTextBoxColumn.HeaderText = "Course Rating";
            this.courseRatingDataGridViewTextBoxColumn.Name = "courseRatingDataGridViewTextBoxColumn";
            this.courseRatingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseSlopeDataGridViewTextBoxColumn
            // 
            this.courseSlopeDataGridViewTextBoxColumn.DataPropertyName = "courseSlope";
            this.courseSlopeDataGridViewTextBoxColumn.HeaderText = "Course Slope";
            this.courseSlopeDataGridViewTextBoxColumn.Name = "courseSlopeDataGridViewTextBoxColumn";
            this.courseSlopeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Date-time";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(951, 643);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.submitScrambleButton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.scramblingInput);
            this.Controls.Add(this.submitFIRButton);
            this.Controls.Add(this.submitGIRButton);
            this.Controls.Add(this.submitPPRButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pprInput);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.girInput);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.firInput);
            this.Controls.Add(this.chooseGolferPanel);
            this.Controls.Add(this.addNewGolferPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pastScoresDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitScoreButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseSlopeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseRatingInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golf Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pastScoresDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.addNewGolferPanel.ResumeLayout(false);
            this.addNewGolferPanel.PerformLayout();
            this.chooseGolferPanel.ResumeLayout(false);
            this.chooseGolferPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.golfTrackerDataSet11)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scoreInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseRatingInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseSlopeInput;
        private System.Windows.Forms.Button submitScoreButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource golfTrackerDataSetBindingSource;
        private GolfTrackerDataSet golfTrackerDataSet;
        private System.Windows.Forms.DataGridView pastScoresDataGrid;
        private GolfTrackerDataSet1 golfTrackerDataSet1;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private GolfTrackerDataSet1TableAdapters.scoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.Label handicapLabel;
        private System.Windows.Forms.Label currentHandicapText;
        private System.Windows.Forms.Label FIRtext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label GIRtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PPRtext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label golferNameText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllPlayerDataToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label roundsSubmittedText;
        private System.Windows.Forms.Panel addNewGolferPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox newGolfer_UserFullNameInput;
        private System.Windows.Forms.TextBox newGolfer_UsernameInput;
        private System.Windows.Forms.Button submitNewGolferButton;
        private System.Windows.Forms.Panel chooseGolferPanel;
        private System.Windows.Forms.Button chooseGolferSubmitButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox chooseGolferInput;
        private GolfTrackerDataSet1 golfTrackerDataSet11;
        private System.Windows.Forms.Button submitPPRButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pprInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox girInput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox firInput;
        private System.Windows.Forms.Button submitGIRButton;
        private System.Windows.Forms.Button submitFIRButton;
        private System.Windows.Forms.Button submitScrambleButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox scramblingInput;
        private System.Windows.Forms.Label scramblingText;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSlopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
    }
}

