
namespace UIMedAssistPatient
{
    partial class FormUIEditerRDVHeure
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
            this.flowLayoutPanelHeure = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateRDV = new System.Windows.Forms.Button();
            this.btSaveAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir une nouvelle heure de consultaion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heure disponible";
            // 
            // flowLayoutPanelHeure
            // 
            this.flowLayoutPanelHeure.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelHeure.Location = new System.Drawing.Point(79, 202);
            this.flowLayoutPanelHeure.Name = "flowLayoutPanelHeure";
            this.flowLayoutPanelHeure.Size = new System.Drawing.Size(200, 267);
            this.flowLayoutPanelHeure.TabIndex = 2;
            // 
            // btUpdateRDV
            // 
            this.btUpdateRDV.Location = new System.Drawing.Point(510, 202);
            this.btUpdateRDV.Name = "btUpdateRDV";
            this.btUpdateRDV.Size = new System.Drawing.Size(175, 74);
            this.btUpdateRDV.TabIndex = 3;
            this.btUpdateRDV.Text = "Enregistrer";
            this.btUpdateRDV.UseVisualStyleBackColor = true;
            this.btUpdateRDV.Click += new System.EventHandler(this.btUpdateRDV_Click);
            // 
            // btSaveAPI
            // 
            this.btSaveAPI.Location = new System.Drawing.Point(510, 329);
            this.btSaveAPI.Name = "btSaveAPI";
            this.btSaveAPI.Size = new System.Drawing.Size(175, 74);
            this.btSaveAPI.TabIndex = 4;
            this.btSaveAPI.Text = "Enregistrer via API";
            this.btSaveAPI.UseVisualStyleBackColor = true;
            this.btSaveAPI.Click += new System.EventHandler(this.btSaveAPI_Click);
            // 
            // FormUIEditerRDVHeure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 535);
            this.Controls.Add(this.btSaveAPI);
            this.Controls.Add(this.btUpdateRDV);
            this.Controls.Add(this.flowLayoutPanelHeure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUIEditerRDVHeure";
            this.Text = "FormUIEditerRDVHeure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeure;
        private System.Windows.Forms.Button btUpdateRDV;
        private System.Windows.Forms.Button btSaveAPI;
    }
}