
namespace UIMedAssistPatient
{
    partial class FormUIPatientRecherche
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
            this.textBoxIdPatient = new System.Windows.Forms.TextBox();
            this.btRechercher = new System.Windows.Forms.Button();
            this.dataGridViewPlanningPatient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btPrendreRDV = new System.Windows.Forms.Button();
            this.btEditerRdv = new System.Windows.Forms.Button();
            this.btSupprimerRDV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelIdPatient = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDatedeNaissance = new System.Windows.Forms.Label();
            this.btGoToApi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanningPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez l\'ID du patient";
            // 
            // textBoxIdPatient
            // 
            this.textBoxIdPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdPatient.Location = new System.Drawing.Point(68, 68);
            this.textBoxIdPatient.Name = "textBoxIdPatient";
            this.textBoxIdPatient.Size = new System.Drawing.Size(100, 30);
            this.textBoxIdPatient.TabIndex = 1;
            // 
            // btRechercher
            // 
            this.btRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercher.Location = new System.Drawing.Point(68, 111);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(131, 37);
            this.btRechercher.TabIndex = 2;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // dataGridViewPlanningPatient
            // 
            this.dataGridViewPlanningPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanningPatient.Location = new System.Drawing.Point(68, 399);
            this.dataGridViewPlanningPatient.Name = "dataGridViewPlanningPatient";
            this.dataGridViewPlanningPatient.RowHeadersWidth = 62;
            this.dataGridViewPlanningPatient.RowTemplate.Height = 28;
            this.dataGridViewPlanningPatient.Size = new System.Drawing.Size(1046, 232);
            this.dataGridViewPlanningPatient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rendez-vous du patient";
            // 
            // btPrendreRDV
            // 
            this.btPrendreRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrendreRDV.Location = new System.Drawing.Point(501, 31);
            this.btPrendreRDV.Name = "btPrendreRDV";
            this.btPrendreRDV.Size = new System.Drawing.Size(188, 95);
            this.btPrendreRDV.TabIndex = 5;
            this.btPrendreRDV.Text = "Prendre rendez-vous";
            this.btPrendreRDV.UseVisualStyleBackColor = true;
            this.btPrendreRDV.Click += new System.EventHandler(this.btPrendreRDV_Click);
            // 
            // btEditerRdv
            // 
            this.btEditerRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditerRdv.Location = new System.Drawing.Point(723, 30);
            this.btEditerRdv.Name = "btEditerRdv";
            this.btEditerRdv.Size = new System.Drawing.Size(188, 96);
            this.btEditerRdv.TabIndex = 6;
            this.btEditerRdv.Text = "Editer rendez-vous";
            this.btEditerRdv.UseVisualStyleBackColor = true;
            this.btEditerRdv.Click += new System.EventHandler(this.btEditerRdv_Click);
            // 
            // btSupprimerRDV
            // 
            this.btSupprimerRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerRDV.Location = new System.Drawing.Point(948, 29);
            this.btSupprimerRDV.Name = "btSupprimerRDV";
            this.btSupprimerRDV.Size = new System.Drawing.Size(188, 99);
            this.btSupprimerRDV.TabIndex = 7;
            this.btSupprimerRDV.Text = "Supprimer rendez-vous";
            this.btSupprimerRDV.UseVisualStyleBackColor = true;
            this.btSupprimerRDV.Click += new System.EventHandler(this.btSupprimerRDV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom patient :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prenom patient :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id patient :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(182, 227);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(0, 25);
            this.labelNom.TabIndex = 11;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(203, 267);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(0, 25);
            this.labelPrenom.TabIndex = 12;
            // 
            // labelIdPatient
            // 
            this.labelIdPatient.AutoSize = true;
            this.labelIdPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdPatient.Location = new System.Drawing.Point(162, 341);
            this.labelIdPatient.Name = "labelIdPatient";
            this.labelIdPatient.Size = new System.Drawing.Size(0, 25);
            this.labelIdPatient.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date de naissance :";
            // 
            // labelDatedeNaissance
            // 
            this.labelDatedeNaissance.AutoSize = true;
            this.labelDatedeNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatedeNaissance.Location = new System.Drawing.Point(228, 305);
            this.labelDatedeNaissance.Name = "labelDatedeNaissance";
            this.labelDatedeNaissance.Size = new System.Drawing.Size(0, 25);
            this.labelDatedeNaissance.TabIndex = 15;
            // 
            // btGoToApi
            // 
            this.btGoToApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoToApi.Location = new System.Drawing.Point(948, 146);
            this.btGoToApi.Name = "btGoToApi";
            this.btGoToApi.Size = new System.Drawing.Size(188, 69);
            this.btGoToApi.TabIndex = 16;
            this.btGoToApi.Text = "API";
            this.btGoToApi.UseVisualStyleBackColor = true;
            this.btGoToApi.Click += new System.EventHandler(this.btGoToApi_Click);
            // 
            // FormUIPatientRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btGoToApi);
            this.Controls.Add(this.labelDatedeNaissance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelIdPatient);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSupprimerRDV);
            this.Controls.Add(this.btEditerRdv);
            this.Controls.Add(this.btPrendreRDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPlanningPatient);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.textBoxIdPatient);
            this.Controls.Add(this.label1);
            this.Name = "FormUIPatientRecherche";
            this.Text = "PatientRecherche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanningPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdPatient;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.DataGridView dataGridViewPlanningPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPrendreRDV;
        private System.Windows.Forms.Button btEditerRdv;
        private System.Windows.Forms.Button btSupprimerRDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelIdPatient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDatedeNaissance;
        private System.Windows.Forms.Button btGoToApi;
    }
}