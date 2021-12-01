
namespace UIMedAssistMedecin
{
    partial class FormUIChoisirMedecin
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
            this.btRechercheMedecinID = new System.Windows.Forms.Button();
            this.textBoxIDMedecin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MedAssist Accueil médecin";
            // 
            // btRechercheMedecinID
            // 
            this.btRechercheMedecinID.Location = new System.Drawing.Point(432, 199);
            this.btRechercheMedecinID.Name = "btRechercheMedecinID";
            this.btRechercheMedecinID.Size = new System.Drawing.Size(124, 62);
            this.btRechercheMedecinID.TabIndex = 1;
            this.btRechercheMedecinID.Text = "Rechercher";
            this.btRechercheMedecinID.UseVisualStyleBackColor = true;
            this.btRechercheMedecinID.Click += new System.EventHandler(this.btRechercheMedecinID_Click);
            // 
            // textBoxIDMedecin
            // 
            this.textBoxIDMedecin.Location = new System.Drawing.Point(81, 235);
            this.textBoxIDMedecin.Name = "textBoxIDMedecin";
            this.textBoxIDMedecin.Size = new System.Drawing.Size(100, 26);
            this.textBoxIDMedecin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entrez votre ID médecin";
            // 
            // FormUIChoisirMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDMedecin);
            this.Controls.Add(this.btRechercheMedecinID);
            this.Controls.Add(this.label1);
            this.Name = "FormUIChoisirMedecin";
            this.Text = "FormUIChoisirMedecin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRechercheMedecinID;
        private System.Windows.Forms.TextBox textBoxIDMedecin;
        private System.Windows.Forms.Label label2;
    }
}