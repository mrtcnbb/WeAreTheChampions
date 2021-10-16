
namespace WeAreTheChampions
{
    partial class Teams
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.btnTeamAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.Colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblColor2);
            this.groupBox1.Controls.Add(this.lblColor1);
            this.groupBox1.Controls.Add(this.dgvColors);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTeamAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Color1,
            this.Color2});
            this.dgvTeams.Location = new System.Drawing.Point(12, 311);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(802, 236);
            this.dgvTeams.TabIndex = 1;
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamDelete.Location = new System.Drawing.Point(12, 553);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(802, 23);
            this.btnTeamDelete.TabIndex = 2;
            this.btnTeamDelete.Text = "Team Delete";
            this.btnTeamDelete.UseVisualStyleBackColor = true;
            // 
            // btnTeamAdd
            // 
            this.btnTeamAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamAdd.Location = new System.Drawing.Point(6, 266);
            this.btnTeamAdd.Name = "btnTeamAdd";
            this.btnTeamAdd.Size = new System.Drawing.Size(790, 23);
            this.btnTeamAdd.TabIndex = 3;
            this.btnTeamAdd.Text = "Team Add";
            this.btnTeamAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team Name:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(0, 41);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(292, 22);
            this.txtTeamName.TabIndex = 5;
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colors});
            this.dgvColors.Location = new System.Drawing.Point(304, 21);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(322, 239);
            this.dgvColors.TabIndex = 6;
            // 
            // lblColor1
            // 
            this.lblColor1.BackColor = System.Drawing.Color.White;
            this.lblColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor1.Location = new System.Drawing.Point(632, 21);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(78, 239);
            this.lblColor1.TabIndex = 7;
            // 
            // Colors
            // 
            this.Colors.HeaderText = "Colors";
            this.Colors.MinimumWidth = 6;
            this.Colors.Name = "Colors";
            this.Colors.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Teams Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Color1
            // 
            this.Color1.HeaderText = "Color1";
            this.Color1.MinimumWidth = 6;
            this.Color1.Name = "Color1";
            this.Color1.ReadOnly = true;
            // 
            // Color2
            // 
            this.Color2.HeaderText = "Color2";
            this.Color2.MinimumWidth = 6;
            this.Color2.Name = "Color2";
            this.Color2.ReadOnly = true;
            // 
            // lblColor2
            // 
            this.lblColor2.BackColor = System.Drawing.Color.White;
            this.lblColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor2.Location = new System.Drawing.Point(716, 21);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(80, 239);
            this.lblColor2.TabIndex = 8;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 586);
            this.Controls.Add(this.btnTeamDelete);
            this.Controls.Add(this.dgvTeams);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colors;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeamAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color2;
        private System.Windows.Forms.Button btnTeamDelete;
        private System.Windows.Forms.Label lblColor2;
    }
}