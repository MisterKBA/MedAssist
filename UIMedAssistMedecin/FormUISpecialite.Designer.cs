
namespace UIMedAssistMedecin
{
    partial class FormUISpecialite
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelNomMedecin = new System.Windows.Forms.Label();
            this.labelIdMedecin = new System.Windows.Forms.Label();
            this.dataGridViewSpecialite = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterSpécialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerDuréeSpécialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerSpécialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAPI = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialite)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAPI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spécialité exercées par le médecin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom médecin : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID médecin : ";
            // 
            // labelNomMedecin
            // 
            this.labelNomMedecin.AutoSize = true;
            this.labelNomMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomMedecin.Location = new System.Drawing.Point(291, 165);
            this.labelNomMedecin.Name = "labelNomMedecin";
            this.labelNomMedecin.Size = new System.Drawing.Size(79, 29);
            this.labelNomMedecin.TabIndex = 3;
            this.labelNomMedecin.Text = "label4";
            // 
            // labelIdMedecin
            // 
            this.labelIdMedecin.AutoSize = true;
            this.labelIdMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdMedecin.Location = new System.Drawing.Point(291, 221);
            this.labelIdMedecin.Name = "labelIdMedecin";
            this.labelIdMedecin.Size = new System.Drawing.Size(79, 29);
            this.labelIdMedecin.TabIndex = 4;
            this.labelIdMedecin.Text = "label5";
            // 
            // dataGridViewSpecialite
            // 
            this.dataGridViewSpecialite.AllowUserToAddRows = false;
            this.dataGridViewSpecialite.AllowUserToDeleteRows = false;
            this.dataGridViewSpecialite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecialite.Location = new System.Drawing.Point(95, 402);
            this.dataGridViewSpecialite.Name = "dataGridViewSpecialite";
            this.dataGridViewSpecialite.ReadOnly = true;
            this.dataGridViewSpecialite.RowHeadersWidth = 62;
            this.dataGridViewSpecialite.RowTemplate.Height = 28;
            this.dataGridViewSpecialite.Size = new System.Drawing.Size(1101, 133);
            this.dataGridViewSpecialite.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Spécialité";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterSpécialitéToolStripMenuItem,
            this.editerDuréeSpécialitéToolStripMenuItem,
            this.supprimerSpécialitéToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // ajouterSpécialitéToolStripMenuItem
            // 
            this.ajouterSpécialitéToolStripMenuItem.Name = "ajouterSpécialitéToolStripMenuItem";
            this.ajouterSpécialitéToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.ajouterSpécialitéToolStripMenuItem.Text = "Ajouter spécialité";
            this.ajouterSpécialitéToolStripMenuItem.Click += new System.EventHandler(this.ajouterSpécialitéToolStripMenuItem_Click);
            // 
            // editerDuréeSpécialitéToolStripMenuItem
            // 
            this.editerDuréeSpécialitéToolStripMenuItem.Name = "editerDuréeSpécialitéToolStripMenuItem";
            this.editerDuréeSpécialitéToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.editerDuréeSpécialitéToolStripMenuItem.Text = "Editer durée spécialité";
            this.editerDuréeSpécialitéToolStripMenuItem.Click += new System.EventHandler(this.editerDuréeSpécialitéToolStripMenuItem_Click);
            // 
            // supprimerSpécialitéToolStripMenuItem
            // 
            this.supprimerSpécialitéToolStripMenuItem.Name = "supprimerSpécialitéToolStripMenuItem";
            this.supprimerSpécialitéToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.supprimerSpécialitéToolStripMenuItem.Text = "Supprimer spécialité";
            this.supprimerSpécialitéToolStripMenuItem.Click += new System.EventHandler(this.supprimerSpécialitéToolStripMenuItem_Click);
            // 
            // dataGridViewAPI
            // 
            this.dataGridViewAPI.AllowUserToAddRows = false;
            this.dataGridViewAPI.AllowUserToDeleteRows = false;
            this.dataGridViewAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAPI.Location = new System.Drawing.Point(95, 640);
            this.dataGridViewAPI.Name = "dataGridViewAPI";
            this.dataGridViewAPI.ReadOnly = true;
            this.dataGridViewAPI.RowHeadersWidth = 62;
            this.dataGridViewAPI.RowTemplate.Height = 28;
            this.dataGridViewAPI.Size = new System.Drawing.Size(1101, 133);
            this.dataGridViewAPI.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Spécialité API";
            // 
            // FormUISpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 823);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewAPI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewSpecialite);
            this.Controls.Add(this.labelIdMedecin);
            this.Controls.Add(this.labelNomMedecin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUISpecialite";
            this.Text = "FormUISpecialite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialite)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNomMedecin;
        private System.Windows.Forms.Label labelIdMedecin;
        private System.Windows.Forms.DataGridView dataGridViewSpecialite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterSpécialitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerDuréeSpécialitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerSpécialitéToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAPI;
        private System.Windows.Forms.Label label4;
    }
}