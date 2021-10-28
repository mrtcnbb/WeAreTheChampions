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
    public partial class Colors : Form
    {
        WeAreTheChampionsDbContext db;
        public Colors(WeAreTheChampionsDbContext db)
        {
            this.db = db;
            InitializeComponent();
            FormReset();
            ColorsList();
        }

        private void ColorsList()
        {
            dgvColors.DataSource = db.Colors.ToList();
        }

        private void FormReset()
        {
            txtColorName.Clear();
            gpbBackgroundColor.BackColor = System.Drawing.Color.White;
            hsbBlue.Value = hsbBlue.Minimum;
            hsbRed.Value = hsbRed.Minimum;
            hsbGreen.Value = hsbGreen.Minimum;
            lblRed.Text = "000";
            lblGreen.Text = "000";
            lblBlue.Text = "000";
        }


        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsbRed.Value.ToString();
            gpbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsbGreen.Value.ToString();
            gpbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);

        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsbBlue.Value.ToString();
            gpbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string colorName = txtColorName.Text.Trim();
            if (colorName == "")
            {
                MessageBox.Show("Renk Adı Giriniz!");
                return;
            }

            db.Colors.Add(new Models.Color()
            {
                ColorName = colorName,
                Red = (byte)hsbRed.Value,
                Green = (byte)hsbGreen.Value,
                Blue = (byte)hsbBlue.Value
            });

            db.SaveChanges();
            ColorsList();
            FormReset();
        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            var selectLine = (Models.Color)dgvColors.SelectedRows[0].DataBoundItem;
            db.Colors.Remove(selectLine);
            db.SaveChanges();
            ColorsList();
            FormReset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
                return;

            var selectLine = ((Models.Color)dgvColors.SelectedRows[0].DataBoundItem).Id;
            var update = db.Colors.Find(selectLine);
            update.Red = (byte)hsbRed.Value;
            update.Green = (byte)hsbGreen.Value;
            update.Blue = (byte)hsbBlue.Value;

            foreach (var item in db.Colors)
            {
                if (item.Id == selectLine)
                {
                    lblColorsBackground.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }

            db.SaveChanges();
            ColorsList();

        }

        private void dgvColors_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvColors.SelectedRows.Count != 1)
            {
                return;
            }

            var selectLine = (Models.Color)dgvColors.SelectedRows[0].DataBoundItem;

            foreach (var item in db.Colors)
            {
                if (item == selectLine)
                {
                    hsbRed.Value = item.Red;
                    lblRed.Text = item.Red.ToString();
                    hsbGreen.Value = item.Green;
                    lblGreen.Text = item.Green.ToString();
                    hsbBlue.Value = item.Blue;
                    lblBlue.Text = item.Blue.ToString();
                    lblColorsBackground.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }
        }
    }
}
