
namespace UIMedAssistMedecin
{
    partial class FormUIPlanningMedecin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNomMedecin = new System.Windows.Forms.Label();
            this.labelIdMedecin = new System.Windows.Forms.Label();
            this.dataGridViewPlanning = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPlanningRDV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterJourDePrésenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerUnJourDePrésenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnJourDuPlanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spécialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewRDVAPI = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewPresenceAPI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanningRDV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRDVAPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresenceAPI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Médecin : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Médecin:";
            // 
            // labelNomMedecin
            // 
            this.labelNomMedecin.AutoSize = true;
            this.labelNomMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomMedecin.Location = new System.Drawing.Point(329, 92);
            this.labelNomMedecin.Name = "labelNomMedecin";
            this.labelNomMedecin.Size = new System.Drawing.Size(79, 29);
            this.labelNomMedecin.TabIndex = 2;
            this.labelNomMedecin.Text = "label3";
            // 
            // labelIdMedecin
            // 
            this.labelIdMedecin.AutoSize = true;
            this.labelIdMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdMedecin.Location = new System.Drawing.Point(288, 161);
            this.labelIdMedecin.Name = "labelIdMedecin";
            this.labelIdMedecin.Size = new System.Drawing.Size(79, 29);
            this.labelIdMedecin.TabIndex = 3;
            this.labelIdMedecin.Text = "label4";
            // 
            // dataGridViewPlanning
            // 
            this.dataGridViewPlanning.AllowUserToAddRows = false;
            this.dataGridViewPlanning.AllowUserToDeleteRows = false;
            this.dataGridViewPlanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanning.Location = new System.Drawing.Point(146, 284);
            this.dataGridViewPlanning.Name = "dataGridViewPlanning";
            this.dataGridViewPlanning.ReadOnly = true;
            this.dataGridViewPlanning.RowHeadersWidth = 62;
            this.dataGridViewPlanning.RowTemplate.Height = 28;
            this.dataGridViewPlanning.Size = new System.Drawing.Size(1209, 221);
            this.dataGridViewPlanning.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jour de présence";
            // 
            // dataGridViewPlanningRDV
            // 
            this.dataGridViewPlanningRDV.AllowUserToAddRows = false;
            this.dataGridViewPlanningRDV.AllowUserToDeleteRows = false;
            this.dataGridViewPlanningRDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanningRDV.Location = new System.Drawing.Point(146, 595);
            this.dataGridViewPlanningRDV.Name = "dataGridViewPlanningRDV";
            this.dataGridViewPlanningRDV.ReadOnly = true;
            this.dataGridViewPlanningRDV.RowHeadersWidth = 62;
            this.dataGridViewPlanningRDV.RowTemplate.Height = 28;
            this.dataGridViewPlanningRDV.Size = new System.Drawing.Size(1209, 150);
            this.dataGridViewPlanningRDV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Planning rendez-vous";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.spécialitéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterJourDePrésenceToolStripMenuItem,
            this.editerUnJourDePrésenceToolStripMenuItem,
            this.supprimerUnJourDuPlanningToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // ajouterJourDePrésenceToolStripMenuItem
            // 
            this.ajouterJourDePrésenceToolStripMenuItem.Name = "ajouterJourDePrésenceToolStripMenuItem";
            this.ajouterJourDePrésenceToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.ajouterJourDePrésenceToolStripMenuItem.Text = "Ajouter jour de présence";
            this.ajouterJourDePrésenceToolStripMenuItem.Click += new System.EventHandler(this.ajouterJourDePrésenceToolStripMenuItem_Click);
            // 
            // editerUnJourDePrésenceToolStripMenuItem
            // 
            this.editerUnJourDePrésenceToolStripMenuItem.Name = "editerUnJourDePrésenceToolStripMenuItem";
            this.editerUnJourDePrésenceToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.editerUnJourDePrésenceToolStripMenuItem.Text = "Editer un jour de présence";
            this.editerUnJourDePrésenceToolStripMenuItem.Click += new System.EventHandler(this.editerUnJourDePrésenceToolStripMenuItem_Click);
            // 
            // supprimerUnJourDuPlanningToolStripMenuItem
            // 
            this.supprimerUnJourDuPlanningToolStripMenuItem.Name = "supprimerUnJourDuPlanningToolStripMenuItem";
            this.supprimerUnJourDuPlanningToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.supprimerUnJourDuPlanningToolStripMenuItem.Text = "Supprimer un jour du planning";
            this.supprimerUnJourDuPlanningToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnJourDuPlanningToolStripMenuItem_Click);
            // 
            // spécialitéToolStripMenuItem
            // 
            this.spécialitéToolStripMenuItem.Name = "spécialitéToolStripMenuItem";
            this.spécialitéToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.spécialitéToolStripMenuItem.Text = "Spécialité";
            this.spécialitéToolStripMenuItem.Click += new System.EventHandler(this.spécialitéToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 977);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Planning rendez-vous API";
            // 
            // dataGridViewRDVAPI
            // 
            this.dataGridViewRDVAPI.AllowUserToAddRows = false;
            this.dataGridViewRDVAPI.AllowUserToDeleteRows = false;
            this.dataGridViewRDVAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRDVAPI.Location = new System.Drawing.Point(146, 1033);
            this.dataGridViewRDVAPI.Name = "dataGridViewRDVAPI";
            this.dataGridViewRDVAPI.ReadOnly = true;
            this.dataGridViewRDVAPI.RowHeadersWidth = 62;
            this.dataGridViewRDVAPI.RowTemplate.Height = 28;
            this.dataGridViewRDVAPI.Size = new System.Drawing.Size(1209, 124);
            this.dataGridViewRDVAPI.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 778);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jour de présence API";
            // 
            // dataGridViewPresenceAPI
            // 
            this.dataGridViewPresenceAPI.AllowUserToAddRows = false;
            this.dataGridViewPresenceAPI.AllowUserToDeleteRows = false;
            this.dataGridViewPresenceAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresenceAPI.Location = new System.Drawing.Point(146, 823);
            this.dataGridViewPresenceAPI.Name = "dataGridViewPresenceAPI";
            this.dataGridViewPresenceAPI.ReadOnly = true;
            this.dataGridViewPresenceAPI.RowHeadersWidth = 62;
            this.dataGridViewPresenceAPI.RowTemplate.Height = 28;
            this.dataGridViewPresenceAPI.Size = new System.Drawing.Size(1209, 131);
            this.dataGridViewPresenceAPI.TabIndex = 9;
            // 
            // FormUIPlanningMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewRDVAPI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewPresenceAPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewPlanningRDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPlanning);
            this.Controls.Add(this.labelIdMedecin);
            this.Controls.Add(this.labelNomMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUIPlanningMedecin";
            this.Text = "FormUIPlanningMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanningRDV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRDVAPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresenceAPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNomMedecin;
        private System.Windows.Forms.Label labelIdMedecin;
        private System.Windows.Forms.DataGridView dataGridViewPlanning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPlanningRDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterJourDePrésenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerUnJourDePrésenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnJourDuPlanningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spécialitéToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewRDVAPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewPresenceAPI;
    }
}