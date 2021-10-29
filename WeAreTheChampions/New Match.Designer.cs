
namespace WeAreTheChampions
{
    partial class New_Match
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
            this.cboHomeTeams = new System.Windows.Forms.ComboBox();
            this.cboAwayTeams = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHomeTeamScore = new System.Windows.Forms.NumericUpDown();
            this.nudAwayTeamScore = new System.Windows.Forms.NumericUpDown();
            this.lblMatchScore = new System.Windows.Forms.Label();
            this.btnAddMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHomeTeams
            // 
            this.cboHomeTeams.DisplayMember = "TeamName";
            this.cboHomeTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeams.FormattingEnabled = true;
            this.cboHomeTeams.Location = new System.Drawing.Point(12, 121);
            this.cboHomeTeams.Name = "cboHomeTeams";
            this.cboHomeTeams.Size = new System.Drawing.Size(181, 24);
            this.cboHomeTeams.TabIndex = 0;
            this.cboHomeTeams.ValueMember = "Id";
            this.cboHomeTeams.SelectedIndexChanged += new System.EventHandler(this.cboHomeTeams_SelectedIndexChanged);
            // 
            // cboAwayTeams
            // 
            this.cboAwayTeams.DisplayMember = "TeamName";
            this.cboAwayTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayTeams.FormattingEnabled = true;
            this.cboAwayTeams.Location = new System.Drawing.Point(592, 121);
            this.cboAwayTeams.Name = "cboAwayTeams";
            this.cboAwayTeams.Size = new System.Drawing.Size(196, 24);
            this.cboAwayTeams.TabIndex = 1;
            this.cboAwayTeams.ValueMember = "Id";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "ddMMMMyyyy | HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(301, 121);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Away Teams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match Date";
            // 
            // nudHomeTeamScore
            // 
            this.nudHomeTeamScore.Location = new System.Drawing.Point(123, 182);
            this.nudHomeTeamScore.Name = "nudHomeTeamScore";
            this.nudHomeTeamScore.Size = new System.Drawing.Size(70, 22);
            this.nudHomeTeamScore.TabIndex = 6;
            // 
            // nudAwayTeamScore
            // 
            this.nudAwayTeamScore.Location = new System.Drawing.Point(592, 182);
            this.nudAwayTeamScore.Name = "nudAwayTeamScore";
            this.nudAwayTeamScore.Size = new System.Drawing.Size(70, 22);
            this.nudAwayTeamScore.TabIndex = 7;
            // 
            // lblMatchScore
            // 
            this.lblMatchScore.AutoSize = true;
            this.lblMatchScore.Location = new System.Drawing.Point(366, 182);
            this.lblMatchScore.Name = "lblMatchScore";
            this.lblMatchScore.Size = new System.Drawing.Size(87, 17);
            this.lblMatchScore.TabIndex = 8;
            this.lblMatchScore.Text = "Match Score";
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(301, 294);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(200, 39);
            this.btnAddMatch.TabIndex = 9;
            this.btnAddMatch.Text = "Match Add";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // New_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.lblMatchScore);
            this.Controls.Add(this.nudAwayTeamScore);
            this.Controls.Add(this.nudHomeTeamScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboAwayTeams);
            this.Controls.Add(this.cboHomeTeams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Match";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New_Match";
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHomeTeams;
        private System.Windows.Forms.ComboBox cboAwayTeams;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHomeTeamScore;
        private System.Windows.Forms.NumericUpDown nudAwayTeamScore;
        private System.Windows.Forms.Label lblMatchScore;
        private System.Windows.Forms.Button btnAddMatch;
    }
}