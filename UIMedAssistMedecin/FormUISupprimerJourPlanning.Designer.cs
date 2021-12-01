
namespace UIMedAssistMedecin
{
    partial class FormUISupprimerJourPlanning
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
            this.dataGridViewSupprimerPlanning = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeleteAPI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupprimerPlanning)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupprimerPlanning
            // 
            this.dataGridViewSupprimerPlanning.AllowUserToAddRows = false;
            this.dataGridViewSupprimerPlanning.AllowUserToDeleteRows = false;
            this.dataGridViewSupprimerPlanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupprimerPlanning.Location = new System.Drawing.Point(48, 231);
            this.dataGridViewSupprimerPlanning.Name = "dataGridViewSupprimerPlanning";
            this.dataGridViewSupprimerPlanning.ReadOnly = true;
            this.dataGridViewSupprimerPlanning.RowHeadersWidth = 62;
            this.dataGridViewSupprimerPlanning.RowTemplate.Height = 28;
            this.dataGridViewSupprimerPlanning.Size = new System.Drawing.Size(1539, 219);
            this.dataGridViewSupprimerPlanning.TabIndex = 0;
            this.dataGridViewSupprimerPlanning.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSupprimerPlanning_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1349, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supprimer un jour du planning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectionnez un jour à supprimer";
            // 
            // btDeleteAPI
            // 
            this.btDeleteAPI.Location = new System.Drawing.Point(1079, 474);
            this.btDeleteAPI.Name = "btDeleteAPI";
            this.btDeleteAPI.Size = new System.Drawing.Size(194, 69);
            this.btDeleteAPI.TabIndex = 4;
            this.btDeleteAPI.Text = "Supprimer via l\'api";
            this.btDeleteAPI.UseVisualStyleBackColor = true;
            this.btDeleteAPI.Click += new System.EventHandler(this.btDeleteAPI_Click);
            // 
            // FormUISupprimerJourPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 624);
            this.Controls.Add(this.btDeleteAPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSupprimerPlanning);
            this.Name = "FormUISupprimerJourPlanning";
            this.Text = "FormUISupprimerJourPlanning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupprimerPlanning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupprimerPlanning;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeleteAPI;
    }
}