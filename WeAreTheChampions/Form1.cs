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
    public partial class Form1 : Form
    {
        WeAreTheChampionsDbContext db = new WeAreTheChampionsDbContext();
        public Form1()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TeamList();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            var frmColors = new Colors(db);
            frmColors.ShowDialog();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            var frmPlayers = new Players(db);
            frmPlayers.ShowDialog();
        }


        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            var frmTeams = new Teams(db);
            frmTeams.ShowDialog();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            var frmNewMatch = new New_Match(db, new NewUpdateMatchModel { States = States.Add});
            frmNewMatch.ShowDialog();
            TeamList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvMatches.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bir Maç Seçiniz");
                return;
            }

            var id = ((Match)dgvMatches.SelectedRows[0].DataBoundItem).Id;
            var frmUpdateMatch = new New_Match(db, new NewUpdateMatchModel { States = States.Update, MatchId = id });
            frmUpdateMatch.ShowDialog();
            TeamList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count != 1)
                return;

            var id = ((Match)dgvMatches.SelectedRows[0].DataBoundItem).Id;
            var delete = db.Matches.Where(x => x.Id == id).FirstOrDefault();
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Seçilen veri silinsin mi", "Emin misiniz?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                db.Matches.Remove(delete);
                db.SaveChanges();
            }

            TeamList();
        }

        private void TeamList()
        {
            dgvMatches.DataSource = db.Matches.ToList();
        }

        private void chkDisableMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisableMatch.Checked)
            {
                dgvMatches.DataSource = db.Matches.Where(x => x.Score1 == null).ToList();
                return;
            }

            TeamList();
        }

        private void dgvMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
