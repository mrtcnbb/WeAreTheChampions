using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class New_Match : Form
    {
        WeAreTheChampionsDbContext db;
        NewUpdateMatchModel statesModel;
        List<Team> allTeams;
        Match matchUpdate;

        public New_Match(WeAreTheChampionsDbContext db, NewUpdateMatchModel statesModel)
        {
            this.db = db;
            this.statesModel = statesModel;
            InitializeComponent();
            LoadAllData();
        }

        private void LoadAllData()
        {
            StateControl();
        }

        private void StateControl()
        {
            GetTeams();
            if(statesModel.States == States.Add)
            {
                btnAddMatch.Text = "Match Add";
                nudAwayTeamScore.Visible = false;
                nudHomeTeamScore.Visible = false;
                lblMatchScore.Visible = false;
                ListHomeTeams();
                ListAwayTeams();
            }
            else if (statesModel.States == States.Update)
            {
                cboHomeTeams.DataSource = allTeams;
                cboAwayTeams.DataSource = allTeams;
                btnAddMatch.Text = "Update";
                nudAwayTeamScore.Visible = true;
                nudHomeTeamScore.Visible = true;
                lblMatchScore.Visible = true;
                cboAwayTeams.Enabled = false;
                cboHomeTeams.Enabled = false;
                dtpDate.Enabled = false;
                GetMatch();
                cboHomeTeams.SelectedValue = matchUpdate.HomeTeamId;
                cboAwayTeams.SelectedValue = matchUpdate.AwayTeamId;
                dtpDate.Value = (DateTime)matchUpdate.MatchTime;
            }
        }

        private void GetMatch()
        {
            if(statesModel.States != States.Update || (statesModel.MatchId < 1 || statesModel.MatchId == null))
            {
                MessageBox.Show("Bir hata oluştur tekrar deneyiniz!");
                Close();
                return;
            }

            matchUpdate = db.Matches.Where(x => x.Id == statesModel.MatchId).FirstOrDefault();
        }

        private void ListAwayTeams()
        {
            cboAwayTeams.DataSource = allTeams.Where(x => x.Id != (int)cboHomeTeams.SelectedValue).ToList();
        }

        private void ListHomeTeams()
        {
            cboHomeTeams.DataSource = allTeams;
        }

        private void GetTeams()
        {
            allTeams = db.Teams.ToList();
        }

        private void cboHomeTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAwayTeams();
        }

        private void AddMatch()
        {
            var match = new Match()
            {
                HomeTeamId = (int)cboHomeTeams.SelectedValue,
                AwayTeamId = (int)cboAwayTeams.SelectedValue,
                MatchTime = dtpDate.Value
            };
            db.Matches.Add(match);
            db.SaveChanges();
            MessageBox.Show("Maç Eklendi","Yeni Maç Ekle",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (statesModel.States ==States.Add)
            {
                AddMatch();
            }
            else if (statesModel.States == States.Update)
            {
                UpdateMatch();
            }
            Close();
        }

        private void UpdateMatch()
        {
            matchUpdate.Score1 = (int)nudHomeTeamScore.Value;
            matchUpdate.Score2 = (int)nudAwayTeamScore.Value;
            matchUpdate.Result = matchUpdate.Score1 > matchUpdate.Score2 ? Result.team1win : (matchUpdate.Score1 < matchUpdate.Score2 ? Result.team2win : Result.draw);
            db.SaveChanges();
        }
    }
}
