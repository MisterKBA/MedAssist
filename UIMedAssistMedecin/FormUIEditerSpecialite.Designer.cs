
namespace UIMedAssistMedecin
{
    partial class FormUIEditerSpecialite
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
            this.flowLayoutPanelSpecialite = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMAisonMedicale = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btSaveAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editer la durée d\'un examen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir une spécialité";
            // 
            // flowLayoutPanelSpecialite
            // 
            this.flowLayoutPanelSpecialite.Location = new System.Drawing.Point(47, 186);
            this.flowLayoutPanelSpecialite.Name = "flowLayoutPanelSpecialite";
            this.flowLayoutPanelSpecialite.Size = new System.Drawing.Size(200, 364);
            this.flowLayoutPanelSpecialite.TabIndex = 2;
            // 
            // flowLayoutPanelMAisonMedicale
            // 
            this.flowLayoutPanelMAisonMedicale.Location = new System.Drawing.Point(311, 186);
            this.flowLayoutPanelMAisonMedicale.Name = "flowLayoutPanelMAisonMedicale";
            this.flowLayoutPanelMAisonMedicale.Size = new System.Drawing.Size(200, 199);
            this.flowLayoutPanelMAisonMedicale.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dans quelle maison médicale";
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.Location = new System.Drawing.Point(678, 208);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(100, 26);
            this.textBoxDuree.TabIndex = 5;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(678, 267);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(100, 42);
            this.btValider.TabIndex = 6;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nouveau temps de consultation";
            // 
            // btSaveAPI
            // 
            this.btSaveAPI.Location = new System.Drawing.Point(678, 343);
            this.btSaveAPI.Name = "btSaveAPI";
            this.btSaveAPI.Size = new System.Drawing.Size(100, 66);
            this.btSaveAPI.TabIndex = 8;
            this.btSaveAPI.Text = "Valider via l\'api";
            this.btSaveAPI.UseVisualStyleBackColor = true;
            this.btSaveAPI.Click += new System.EventHandler(this.btSaveAPI_Click);
            // 
            // FormUIEditerSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 574);
            this.Controls.Add(this.btSaveAPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.textBoxDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanelMAisonMedicale);
            this.Controls.Add(this.flowLayoutPanelSpecialite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUIEditerSpecialite";
            this.Text = "FormUIEditerSpecialite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpecialite;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMAisonMedicale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDuree;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSaveAPI;
    }
}