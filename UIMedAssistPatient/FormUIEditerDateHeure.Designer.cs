
namespace UIMedAssistPatient
{
    partial class FormUIEditerDateHeure
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
            this.dataGridViewDate = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelHeure = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btValiderEditionRDV = new System.Windows.Forms.Button();
            this.btSaveAPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDate
            // 
            this.dataGridViewDate.AllowUserToAddRows = false;
            this.dataGridViewDate.AllowUserToDeleteRows = false;
            this.dataGridViewDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDate.Location = new System.Drawing.Point(96, 201);
            this.dataGridViewDate.Name = "dataGridViewDate";
            this.dataGridViewDate.ReadOnly = true;
            this.dataGridViewDate.RowHeadersWidth = 62;
            this.dataGridViewDate.RowTemplate.Height = 28;
            this.dataGridViewDate.Size = new System.Drawing.Size(271, 249);
            this.dataGridViewDate.TabIndex = 0;
            this.dataGridViewDate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDate_CellMouseClick);
            // 
            // flowLayoutPanelHeure
            // 
            this.flowLayoutPanelHeure.Location = new System.Drawing.Point(402, 201);
            this.flowLayoutPanelHeure.Name = "flowLayoutPanelHeure";
            this.flowLayoutPanelHeure.Size = new System.Drawing.Size(200, 249);
            this.flowLayoutPanelHeure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Changer la date et l\'heure du rendez-vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heure";
            // 
            // btValiderEditionRDV
            // 
            this.btValiderEditionRDV.Location = new System.Drawing.Point(753, 406);
            this.btValiderEditionRDV.Name = "btValiderEditionRDV";
            this.btValiderEditionRDV.Size = new System.Drawing.Size(175, 68);
            this.btValiderEditionRDV.TabIndex = 5;
            this.btValiderEditionRDV.Text = "Valider";
            this.btValiderEditionRDV.UseVisualStyleBackColor = true;
            this.btValiderEditionRDV.Click += new System.EventHandler(this.btValiderEditionRDV_Click);
            // 
            // btSaveAPI
            // 
            this.btSaveAPI.Location = new System.Drawing.Point(973, 406);
            this.btSaveAPI.Name = "btSaveAPI";
            this.btSaveAPI.Size = new System.Drawing.Size(175, 68);
            this.btSaveAPI.TabIndex = 6;
            this.btSaveAPI.Text = "Valider via l\'api";
            this.btSaveAPI.UseVisualStyleBackColor = true;
            this.btSaveAPI.Click += new System.EventHandler(this.btSaveAPI_Click);
            // 
            // FormUIEditerDateHeure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 545);
            this.Controls.Add(this.btSaveAPI);
            this.Controls.Add(this.btValiderEditionRDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelHeure);
            this.Controls.Add(this.dataGridViewDate);
            this.Name = "FormUIEditerDateHeure";
            this.Text = "FormUIEditerDateHeure";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHeure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btValiderEditionRDV;
        private System.Windows.Forms.Button btSaveAPI;
    }
}