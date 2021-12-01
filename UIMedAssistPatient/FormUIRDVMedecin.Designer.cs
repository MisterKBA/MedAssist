
namespace UIMedAssistPatient
{
    partial class FormUIRDVMedecin
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMedecin = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMaison = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSpecialite = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelHeureRDV = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewJourDePresence = new System.Windows.Forms.DataGridView();
            this.btSaveRDV = new System.Windows.Forms.Button();
            this.btSaveAPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJourDePresence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medecin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maison";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de siponibilité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(993, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heure de rendez-vous";
            // 
            // flowLayoutPanelMedecin
            // 
            this.flowLayoutPanelMedecin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMedecin.Location = new System.Drawing.Point(66, 159);
            this.flowLayoutPanelMedecin.Name = "flowLayoutPanelMedecin";
            this.flowLayoutPanelMedecin.Size = new System.Drawing.Size(112, 205);
            this.flowLayoutPanelMedecin.TabIndex = 5;
            // 
            // flowLayoutPanelMaison
            // 
            this.flowLayoutPanelMaison.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMaison.Location = new System.Drawing.Point(270, 159);
            this.flowLayoutPanelMaison.Name = "flowLayoutPanelMaison";
            this.flowLayoutPanelMaison.Size = new System.Drawing.Size(112, 205);
            this.flowLayoutPanelMaison.TabIndex = 6;
            // 
            // flowLayoutPanelSpecialite
            // 
            this.flowLayoutPanelSpecialite.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSpecialite.Location = new System.Drawing.Point(488, 159);
            this.flowLayoutPanelSpecialite.Name = "flowLayoutPanelSpecialite";
            this.flowLayoutPanelSpecialite.Size = new System.Drawing.Size(112, 205);
            this.flowLayoutPanelSpecialite.TabIndex = 6;
            // 
            // flowLayoutPanelHeureRDV
            // 
            this.flowLayoutPanelHeureRDV.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelHeureRDV.Location = new System.Drawing.Point(997, 159);
            this.flowLayoutPanelHeureRDV.Name = "flowLayoutPanelHeureRDV";
            this.flowLayoutPanelHeureRDV.Size = new System.Drawing.Size(112, 205);
            this.flowLayoutPanelHeureRDV.TabIndex = 6;
            // 
            // dataGridViewJourDePresence
            // 
            this.dataGridViewJourDePresence.AllowUserToAddRows = false;
            this.dataGridViewJourDePresence.AllowUserToDeleteRows = false;
            this.dataGridViewJourDePresence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJourDePresence.Location = new System.Drawing.Point(699, 159);
            this.dataGridViewJourDePresence.Name = "dataGridViewJourDePresence";
            this.dataGridViewJourDePresence.ReadOnly = true;
            this.dataGridViewJourDePresence.RowHeadersWidth = 62;
            this.dataGridViewJourDePresence.RowTemplate.Height = 28;
            this.dataGridViewJourDePresence.Size = new System.Drawing.Size(243, 205);
            this.dataGridViewJourDePresence.TabIndex = 7;
            this.dataGridViewJourDePresence.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewJourDePresence_CellMouseClick);
            // 
            // btSaveRDV
            // 
            this.btSaveRDV.Location = new System.Drawing.Point(1141, 432);
            this.btSaveRDV.Name = "btSaveRDV";
            this.btSaveRDV.Size = new System.Drawing.Size(128, 55);
            this.btSaveRDV.TabIndex = 8;
            this.btSaveRDV.Text = "Sauver rendez-vous";
            this.btSaveRDV.UseVisualStyleBackColor = true;
            this.btSaveRDV.Click += new System.EventHandler(this.btSaveRDV_Click);
            // 
            // btSaveAPI
            // 
            this.btSaveAPI.Location = new System.Drawing.Point(953, 432);
            this.btSaveAPI.Name = "btSaveAPI";
            this.btSaveAPI.Size = new System.Drawing.Size(128, 55);
            this.btSaveAPI.TabIndex = 9;
            this.btSaveAPI.Text = "Sauver rendez-vous via l\'api";
            this.btSaveAPI.UseVisualStyleBackColor = true;
            this.btSaveAPI.Click += new System.EventHandler(this.btSaveAPI_Click);
            // 
            // FormUIRDVMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 556);
            this.Controls.Add(this.btSaveAPI);
            this.Controls.Add(this.btSaveRDV);
            this.Controls.Add(this.dataGridViewJourDePresence);
            this.Controls.Add(this.flowLayoutPanelHeureRDV);
            this.Controls.Add(this.flowLayoutPanelSpecialite);
            this.Controls.Add(this.flowLayoutPanelMaison);
            this.Controls.Add(this.flowLayoutPanelMedecin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUIRDVMedecin";
            this.Text = "FormRDVMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJourDePresence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMedecin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMaison;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpecialite;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeureRDV;
        private System.Windows.Forms.DataGridView dataGridViewJourDePresence;
        private System.Windows.Forms.Button btSaveRDV;
        private System.Windows.Forms.Button btSaveAPI;
    }
}