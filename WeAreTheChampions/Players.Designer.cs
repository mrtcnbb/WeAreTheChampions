
namespace WeAreTheChampions
{
    partial class Players
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboPlayerTeams = new System.Windows.Forms.ComboBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeamsFilter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboPlayerTeams);
            this.groupBox1.Controls.Add(this.txtPlayerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Player";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Player";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboPlayerTeams
            // 
            this.cboPlayerTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerTeams.FormattingEnabled = true;
            this.cboPlayerTeams.Location = new System.Drawing.Point(147, 92);
            this.cboPlayerTeams.Name = "cboPlayerTeams";
            this.cboPlayerTeams.Size = new System.Drawing.Size(213, 24);
            this.cboPlayerTeams.TabIndex = 3;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(147, 52);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(213, 22);
            this.txtPlayerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cboTeams);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // cboTeams
            // 
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(120, 50);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(214, 24);
            this.cboTeams.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Team:";
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToAddRows = false;
            this.dgvPlayer.AllowUserToDeleteRows = false;
            this.dgvPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName});
            this.dgvPlayer.Location = new System.Drawing.Point(424, 22);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersWidth = 51;
            this.dgvPlayer.RowTemplate.Height = 24;
            this.dgvPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayer.Size = new System.Drawing.Size(450, 230);
            this.dgvPlayer.TabIndex = 2;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // dgvTeamsFilter
            // 
            this.dgvTeamsFilter.AllowUserToAddRows = false;
            this.dgvTeamsFilter.AllowUserToDeleteRows = false;
            this.dgvTeamsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeamsFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamsFilter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamsFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamsFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvTeamsFilter.Location = new System.Drawing.Point(424, 272);
            this.dgvTeamsFilter.Name = "dgvTeamsFilter";
            this.dgvTeamsFilter.ReadOnly = true;
            this.dgvTeamsFilter.RowHeadersWidth = 51;
            this.dgvTeamsFilter.RowTemplate.Height = 24;
            this.dgvTeamsFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamsFilter.Size = new System.Drawing.Size(450, 217);
            this.dgvTeamsFilter.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Team Player Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 501);
            this.Controls.Add(this.dgvTeamsFilter);
            this.Controls.Add(this.dgvPlayer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Players";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamsFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboPlayerTeams;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridView dgvTeamsFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}