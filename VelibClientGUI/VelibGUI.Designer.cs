using VelibClientGUI.VelibService;

namespace VelibClientGUI
{
    partial class VelibGUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CitiesList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StationsList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AvailableBikesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalBikesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "JC Décaux — Vélib";
            // 
            // CitiesList
            // 
            this.CitiesList.DisplayMember = "Name";
            this.CitiesList.FormattingEnabled = true;
            this.CitiesList.ItemHeight = 16;
            this.CitiesList.Location = new System.Drawing.Point(50, 123);
            this.CitiesList.Name = "CitiesList";
            this.CitiesList.Size = new System.Drawing.Size(140, 228);
            this.CitiesList.Sorted = true;
            this.CitiesList.TabIndex = 1;
            this.CitiesList.SelectedIndexChanged += new System.EventHandler(this.CitiesList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stations";
            // 
            // StationsList
            // 
            this.StationsList.DisplayMember = "Name";
            this.StationsList.FormattingEnabled = true;
            this.StationsList.ItemHeight = 16;
            this.StationsList.Location = new System.Drawing.Point(250, 123);
            this.StationsList.Name = "StationsList";
            this.StationsList.Size = new System.Drawing.Size(140, 228);
            this.StationsList.Sorted = true;
            this.StationsList.TabIndex = 4;
            this.StationsList.SelectedIndexChanged += new System.EventHandler(this.StationsList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(418, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vélos Disponibles";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.61111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.AvailableBikesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalBikesLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AvailableBikesLabel
            // 
            this.AvailableBikesLabel.AutoSize = true;
            this.AvailableBikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.AvailableBikesLabel.Location = new System.Drawing.Point(5, 3);
            this.AvailableBikesLabel.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.AvailableBikesLabel.Name = "AvailableBikesLabel";
            this.AvailableBikesLabel.Size = new System.Drawing.Size(95, 67);
            this.AvailableBikesLabel.TabIndex = 0;
            this.AvailableBikesLabel.Text = "00";
            this.AvailableBikesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(108, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "/";
            // 
            // TotalBikesLabel
            // 
            this.TotalBikesLabel.AutoSize = true;
            this.TotalBikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TotalBikesLabel.Location = new System.Drawing.Point(146, 3);
            this.TotalBikesLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.TotalBikesLabel.Name = "TotalBikesLabel";
            this.TotalBikesLabel.Size = new System.Drawing.Size(95, 67);
            this.TotalBikesLabel.TabIndex = 2;
            this.TotalBikesLabel.Text = "00";
            // 
            // VelibGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StationsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CitiesList);
            this.Controls.Add(this.label1);
            this.Name = "VelibGUI";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox CitiesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox StationsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label AvailableBikesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalBikesLabel;
    }
}

