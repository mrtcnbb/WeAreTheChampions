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
    public partial class Players : Form
    {
        WeAreTheChampionsDbContext db;
        public Players(WeAreTheChampionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            FormReset();
            PlayerList();
            PropertySettings();
        }

        private void PropertySettings()
        {
            dgvPlayer.AutoGenerateColumns = false;
            dgvTeamsFilter.AutoGenerateColumns = false;
        }

        private void PlayerList()
        {
            dgvPlayer.DataSource = db.Players.ToList();
        }

        private void FormReset()
        {
            txtPlayerName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboPlayerTeams.SelectedIndex < 0)
                return;

            string playerName = txtPlayerName.Text.Trim();
            var teamId = ((Models.Team)cboPlayerTeams.SelectedItem).Id;

            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
                return;
            }

            db.Players.Add(new Player()
            {
                PlayerName = playerName,
                TeamId = teamId
            });

            db.SaveChanges();
            PlayerList();
            FormReset();
            ListFilterPlayer();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlayer.SelectedRows.Count != 1)
                return;

            var selectedPlayer = (Models.Player)dgvPlayer.SelectedRows[0].DataBoundItem;
            db.Players.Remove(selectedPlayer);
            db.SaveChanges();
            PlayerList();
            FormReset();
            ListFilterPlayer();
        }

        private void Players_Load(object sender, EventArgs e)
        {
            List<Team> teams = db.Teams.ToList();
            cboPlayerTeams.DataSource = teams;
            ListFilterPlayer();
        }

        private void ListFilterPlayer()
        {
            cboTeams.DataSource = db.Teams.ToList();
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTeams.SelectedIndex < 0)
                return;

            var teamId = (int)cboTeams.SelectedValue;
            var player = db.Players.Where(x => x.TeamId== teamId).ToList();
            dgvTeamsFilter.DataSource = player;
            
        }
    }
}
