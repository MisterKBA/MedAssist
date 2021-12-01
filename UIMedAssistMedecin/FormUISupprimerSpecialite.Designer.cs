
namespace UIMedAssistMedecin
{
    partial class FormUISupprimerSpecialite
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
            this.flowLayoutPanelSpecialite = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMAisonMedicale = new System.Windows.Forms.FlowLayoutPanel();
            this.btValider = new System.Windows.Forms.Button();
            this.btDeleteAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supprimer une spécialité dans une maison médicale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choisir une spécialité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dans quelle maison médicale";
            // 
            // flowLayoutPanelSpecialite
            // 
            this.flowLayoutPanelSpecialite.Location = new System.Drawing.Point(62, 199);
            this.flowLayoutPanelSpecialite.Name = "flowLayoutPanelSpecialite";
            this.flowLayoutPanelSpecialite.Size = new System.Drawing.Size(200, 364);
            this.flowLayoutPanelSpecialite.TabIndex = 6;
            // 
            // flowLayoutPanelMAisonMedicale
            // 
            this.flowLayoutPanelMAisonMedicale.Location = new System.Drawing.Point(397, 199);
            this.flowLayoutPanelMAisonMedicale.Name = "flowLayoutPanelMAisonMedicale";
            this.flowLayoutPanelMAisonMedicale.Size = new System.Drawing.Size(200, 199);
            this.flowLayoutPanelMAisonMedicale.TabIndex = 7;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(397, 471);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(100, 42);
            this.btValider.TabIndex = 8;
            this.btValider.Text = "Supprimer";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btDeleteAPI
            // 
            this.btDeleteAPI.Location = new System.Drawing.Point(547, 471);
            this.btDeleteAPI.Name = "btDeleteAPI";
            this.btDeleteAPI.Size = new System.Drawing.Size(158, 59);
            this.btDeleteAPI.TabIndex = 9;
            this.btDeleteAPI.Text = "Supprimer via l\'api";
            this.btDeleteAPI.UseVisualStyleBackColor = true;
            this.btDeleteAPI.Click += new System.EventHandler(this.btDeleteAPI_Click);
            // 
            // FormUISupprimerSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.btDeleteAPI);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.flowLayoutPanelMAisonMedicale);
            this.Controls.Add(this.flowLayoutPanelSpecialite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUISupprimerSpecialite";
            this.Text = "FormUISupprimerSpecialite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpecialite;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMAisonMedicale;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btDeleteAPI;
    }
}