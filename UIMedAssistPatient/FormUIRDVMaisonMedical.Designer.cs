
namespace UIMedAssistPatient
{
    partial class FormUIRDVMaisonMedical
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
            this.flowLayoutPanelMaisonMedicale = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanelSpecialite = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelHeureM = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMedecin = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelHeureA = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prendre rendez-vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choix maison médicale";
            // 
            // flowLayoutPanelMaisonMedicale
            // 
            this.flowLayoutPanelMaisonMedicale.Location = new System.Drawing.Point(18, 103);
            this.flowLayoutPanelMaisonMedicale.Name = "flowLayoutPanelMaisonMedicale";
            this.flowLayoutPanelMaisonMedicale.Size = new System.Drawing.Size(262, 166);
            this.flowLayoutPanelMaisonMedicale.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choisir une date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 103);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(384, 35);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(731, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choisir une spécialité";
            // 
            // flowLayoutPanelSpecialite
            // 
            this.flowLayoutPanelSpecialite.Location = new System.Drawing.Point(736, 103);
            this.flowLayoutPanelSpecialite.Name = "flowLayoutPanelSpecialite";
            this.flowLayoutPanelSpecialite.Size = new System.Drawing.Size(200, 364);
            this.flowLayoutPanelSpecialite.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1041, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choisir une heure";
            // 
            // flowLayoutPanelHeureM
            // 
            this.flowLayoutPanelHeureM.Location = new System.Drawing.Point(1046, 103);
            this.flowLayoutPanelHeureM.Name = "flowLayoutPanelHeureM";
            this.flowLayoutPanelHeureM.Size = new System.Drawing.Size(135, 364);
            this.flowLayoutPanelHeureM.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1419, 753);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(169, 74);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Sauver";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Medecin";
            // 
            // flowLayoutPanelMedecin
            // 
            this.flowLayoutPanelMedecin.Location = new System.Drawing.Point(325, 220);
            this.flowLayoutPanelMedecin.Name = "flowLayoutPanelMedecin";
            this.flowLayoutPanelMedecin.Size = new System.Drawing.Size(200, 185);
            this.flowLayoutPanelMedecin.TabIndex = 12;
            // 
            // flowLayoutPanelHeureA
            // 
            this.flowLayoutPanelHeureA.Location = new System.Drawing.Point(1208, 103);
            this.flowLayoutPanelHeureA.Name = "flowLayoutPanelHeureA";
            this.flowLayoutPanelHeureA.Size = new System.Drawing.Size(135, 364);
            this.flowLayoutPanelHeureA.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1208, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 74);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sauver via API";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUIRDVMaisonMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 920);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelMedecin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.flowLayoutPanelHeureA);
            this.Controls.Add(this.flowLayoutPanelHeureM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanelSpecialite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanelMaisonMedicale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormUIRDVMaisonMedical";
            this.Text = "FormRDVMaisonMedical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMaisonMedicale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpecialite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeureM;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMedecin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeureA;
        private System.Windows.Forms.Button button1;
    }
}