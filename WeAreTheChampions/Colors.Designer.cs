
namespace WeAreTheChampions
{
    partial class Colors
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
            this.gpbBackgroundColor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblColorsBackground = new System.Windows.Forms.Label();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.gpbBackgroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBackgroundColor
            // 
            this.gpbBackgroundColor.Controls.Add(this.lblBlue);
            this.gpbBackgroundColor.Controls.Add(this.lblGreen);
            this.gpbBackgroundColor.Controls.Add(this.lblRed);
            this.gpbBackgroundColor.Controls.Add(this.btnAdd);
            this.gpbBackgroundColor.Controls.Add(this.label4);
            this.gpbBackgroundColor.Controls.Add(this.label3);
            this.gpbBackgroundColor.Controls.Add(this.label2);
            this.gpbBackgroundColor.Controls.Add(this.hsbBlue);
            this.gpbBackgroundColor.Controls.Add(this.hsbGreen);
            this.gpbBackgroundColor.Controls.Add(this.hsbRed);
            this.gpbBackgroundColor.Controls.Add(this.txtColorName);
            this.gpbBackgroundColor.Controls.Add(this.label1);
            this.gpbBackgroundColor.Location = new System.Drawing.Point(12, 12);
            this.gpbBackgroundColor.Name = "gpbBackgroundColor";
            this.gpbBackgroundColor.Size = new System.Drawing.Size(336, 537);
            this.gpbBackgroundColor.TabIndex = 0;
            this.gpbBackgroundColor.TabStop = false;
            this.gpbBackgroundColor.Text = "New Colors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Name";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(21, 62);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(276, 22);
            this.txtColorName.TabIndex = 1;
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(40, 177);
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(245, 21);
            this.hsbRed.TabIndex = 2;
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(40, 227);
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(245, 21);
            this.hsbGreen.TabIndex = 3;
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(40, 277);
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(245, 21);
            this.hsbBlue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chartreuse;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "B";
            // 
            // lblColorsBackground
            // 
            this.lblColorsBackground.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblColorsBackground.Location = new System.Drawing.Point(606, 12);
            this.lblColorsBackground.Name = "lblColorsBackground";
            this.lblColorsBackground.Size = new System.Drawing.Size(230, 489);
            this.lblColorsBackground.TabIndex = 1;
            // 
            // dgvColors
            // 
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Location = new System.Drawing.Point(354, 12);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.Size = new System.Drawing.Size(246, 489);
            this.dgvColors.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(438, 507);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(663, 506);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 35);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRed.Location = new System.Drawing.Point(298, 181);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(35, 17);
            this.lblRed.TabIndex = 9;
            this.lblRed.Text = "000";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGreen.Location = new System.Drawing.Point(298, 231);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(35, 17);
            this.lblGreen.TabIndex = 10;
            this.lblGreen.Text = "000";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBlue.Location = new System.Drawing.Point(298, 281);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(35, 17);
            this.lblBlue.TabIndex = 11;
            this.lblBlue.Text = "000";
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 561);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvColors);
            this.Controls.Add(this.lblColorsBackground);
            this.Controls.Add(this.gpbBackgroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Colors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            this.gpbBackgroundColor.ResumeLayout(false);
            this.gpbBackgroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBackgroundColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColorsBackground;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
    }
}