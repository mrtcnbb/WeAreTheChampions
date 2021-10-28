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
        public New_Match(WeAreTheChampionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
        }
    }
}
