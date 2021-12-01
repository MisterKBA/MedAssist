
namespace UIMedAssistPatient
{
    partial class FormUISupprimerRDV
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
            this.dataGridViewRDV = new System.Windows.Forms.DataGridView();
            this.btSupprimerRDV = new System.Windows.Forms.Button();
            this.btDeleteAPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionnez un rendez-vous à supprimer";
            // 
            // dataGridViewRDV
            // 
            this.dataGridViewRDV.AllowUserToAddRows = false;
            this.dataGridViewRDV.AllowUserToDeleteRows = false;
            this.dataGridViewRDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRDV.Location = new System.Drawing.Point(57, 143);
            this.dataGridViewRDV.Name = "dataGridViewRDV";
            this.dataGridViewRDV.ReadOnly = true;
            this.dataGridViewRDV.RowHeadersWidth = 62;
            this.dataGridViewRDV.RowTemplate.Height = 28;
            this.dataGridViewRDV.Size = new System.Drawing.Size(1221, 309);
            this.dataGridViewRDV.TabIndex = 1;
            this.dataGridViewRDV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRDV_CellMouseClick);
            // 
            // btSupprimerRDV
            // 
            this.btSupprimerRDV.Location = new System.Drawing.Point(57, 527);
            this.btSupprimerRDV.Name = "btSupprimerRDV";
            this.btSupprimerRDV.Size = new System.Drawing.Size(145, 52);
            this.btSupprimerRDV.TabIndex = 2;
            this.btSupprimerRDV.Text = "Supprimer";
            this.btSupprimerRDV.UseVisualStyleBackColor = true;
            this.btSupprimerRDV.Click += new System.EventHandler(this.btSupprimerRDV_Click);
            // 
            // btDeleteAPI
            // 
            this.btDeleteAPI.Location = new System.Drawing.Point(246, 527);
            this.btDeleteAPI.Name = "btDeleteAPI";
            this.btDeleteAPI.Size = new System.Drawing.Size(145, 52);
            this.btDeleteAPI.TabIndex = 3;
            this.btDeleteAPI.Text = "Supprimer via l\'api";
            this.btDeleteAPI.UseVisualStyleBackColor = true;
            this.btDeleteAPI.Click += new System.EventHandler(this.btDeleteAPI_Click);
            // 
            // FormUISupprimerRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 626);
            this.Controls.Add(this.btDeleteAPI);
            this.Controls.Add(this.btSupprimerRDV);
            this.Controls.Add(this.dataGridViewRDV);
            this.Controls.Add(this.label1);
            this.Name = "FormUISupprimerRDV";
            this.Text = "FormSupprimerRDV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRDV;
        private System.Windows.Forms.Button btSupprimerRDV;
        private System.Windows.Forms.Button btDeleteAPI;
    }
}