
namespace UIMedAssistPatient
{
    partial class FormUIPrendreRDVOption
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
            this.btRDVMaisonM = new System.Windows.Forms.Button();
            this.btRDVMedecin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir l\'option de rendez-vous";
            // 
            // btRDVMaisonM
            // 
            this.btRDVMaisonM.Location = new System.Drawing.Point(131, 146);
            this.btRDVMaisonM.Name = "btRDVMaisonM";
            this.btRDVMaisonM.Size = new System.Drawing.Size(130, 78);
            this.btRDVMaisonM.TabIndex = 1;
            this.btRDVMaisonM.Text = "Option via Maison médicale";
            this.btRDVMaisonM.UseVisualStyleBackColor = true;
            this.btRDVMaisonM.Click += new System.EventHandler(this.btRDVMaisonM_Click);
            // 
            // btRDVMedecin
            // 
            this.btRDVMedecin.Location = new System.Drawing.Point(315, 146);
            this.btRDVMedecin.Name = "btRDVMedecin";
            this.btRDVMedecin.Size = new System.Drawing.Size(127, 79);
            this.btRDVMedecin.TabIndex = 2;
            this.btRDVMedecin.Text = "Option via médecin";
            this.btRDVMedecin.UseVisualStyleBackColor = true;
            this.btRDVMedecin.Click += new System.EventHandler(this.btRDVMedecin_Click);
            // 
            // FormPrendreRDVOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 289);
            this.Controls.Add(this.btRDVMedecin);
            this.Controls.Add(this.btRDVMaisonM);
            this.Controls.Add(this.label1);
            this.Name = "FormPrendreRDVOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPrendreRDVOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRDVMaisonM;
        private System.Windows.Forms.Button btRDVMedecin;
    }
}