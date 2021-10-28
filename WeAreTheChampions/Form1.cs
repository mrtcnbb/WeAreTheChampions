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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            var frmTeams = new Teams(db);
            frmTeams.ShowDialog();
        }
    }
}
