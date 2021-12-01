
namespace UIMedAssistMedecin
{
    partial class FormUIAjoutSpecialite
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
            this.flowLayoutPanelSpecialite = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMaisonMedicale = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btValiderAjout = new System.Windows.Forms.Button();
            this.btSaveAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSpecialite
            // 
            this.flowLayoutPanelSpecialite.Location = new System.Drawing.Point(12, 141);
            this.flowLayoutPanelSpecialite.Name = "flowLayoutPanelSpecialite";
            this.flowLayoutPanelSpecialite.Size = new System.Drawing.Size(262, 352);
            this.flowLayoutPanelSpecialite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter une spécialité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choisir une spécialité";
            // 
            // flowLayoutPanelMaisonMedicale
            // 
            this.flowLayoutPanelMaisonMedicale.Location = new System.Drawing.Point(370, 141);
            this.flowLayoutPanelMaisonMedicale.Name = "flowLayoutPanelMaisonMedicale";
            this.flowLayoutPanelMaisonMedicale.Size = new System.Drawing.Size(262, 352);
            this.flowLayoutPanelMaisonMedicale.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pour quelle maison médicale";
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.Location = new System.Drawing.Point(804, 141);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(100, 26);
            this.textBoxDuree.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(799, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Déterminer le temps de consultation";
            // 
            // btValiderAjout
            // 
            this.btValiderAjout.Location = new System.Drawing.Point(804, 261);
            this.btValiderAjout.Name = "btValiderAjout";
            this.btValiderAjout.Size = new System.Drawing.Size(133, 64);
            this.btValiderAjout.TabIndex = 6;
            this.btValiderAjout.Text = "Valider";
            this.btValiderAjout.UseVisualStyleBackColor = true;
            this.btValiderAjout.Click += new System.EventHandler(this.btValiderAjout_Click);
            // 
            // btSaveAPI
            // 
            this.btSaveAPI.Location = new System.Drawing.Point(996, 261);
            this.btSaveAPI.Name = "btSaveAPI";
            this.btSaveAPI.Size = new System.Drawing.Size(133, 64);
            this.btSaveAPI.TabIndex = 7;
            this.btSaveAPI.Text = "Valider via l\'api";
            this.btSaveAPI.UseVisualStyleBackColor = true;
            this.btSaveAPI.Click += new System.EventHandler(this.btSaveAPI_Click);
            // 
            // FormUIAjoutSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 505);
            this.Controls.Add(this.btSaveAPI);
            this.Controls.Add(this.btValiderAjout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanelMaisonMedicale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelSpecialite);
            this.Name = "FormUIAjoutSpecialite";
            this.Text = "FormUIAjoutSpecialite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpecialite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMaisonMedicale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDuree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btValiderAjout;
        private System.Windows.Forms.Button btSaveAPI;
    }
}