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
    public partial class Teams : Form
    {
        WeAreTheChampionsDbContext db; 
        public Teams(WeAreTheChampionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            TeamList();
            
        }

        private void FormReset()
        {
            txtTeamName.Clear();
            lblColor1.BackColor = System.Drawing.Color.White;
            lblColor2.BackColor = System.Drawing.Color.White;
        }

        private void TeamList()
        {
            dgvTeams.AutoGenerateColumns = false;
            dgvTeams.DataSource = db.Teams.ToList();
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            dgvColors.AutoGenerateColumns = false;
            List<Models.Color> colors = db.Colors.ToList();
            dgvColors.DataSource = colors;
        }

        private void btnTeamAdd_Click(object sender, EventArgs e)
        {
            db.Teams.Add(new Team()
            {
                TeamName = txtTeamName.Text.Trim()

            });
            db.SaveChanges();
            TeamList();
            FormReset();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count != 1)
                return;

            var selectedTeam = ((Models.Team)dgvTeams.SelectedRows[0].DataBoundItem).Id;
            var delete = db.Teams.Where(x => x.Id == selectedTeam).FirstOrDefault();
            if(dgvTeams.Rows.Count > -1)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Seçilen veri silinsin mi?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog == DialogResult.Yes)
                {
                    db.Teams.Remove(delete);
                    db.SaveChanges();
                    TeamList();
                }
            }
        }

        private void lblColor1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            lblColor1.BackColor = System.Drawing.Color.White;

            var id = ((Models.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;

            foreach (var item in db.Colors)
            {
                if (id == item.Id)
                {
                    lblColor1.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }
        }

        private void lblColor2_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            lblColor2.BackColor = System.Drawing.Color.White;

            var id = ((Models.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;

            foreach (var item in db.Colors)
            {
                if (id == item.Id)
                {
                    lblColor2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }
        }
    }
}
