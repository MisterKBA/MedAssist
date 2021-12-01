
namespace UIMedAssistMedecin
{
    partial class FormUIEditerPlanning
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
            this.dataGridViewEditerPlanning = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditerPlanning)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEditerPlanning
            // 
            this.dataGridViewEditerPlanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditerPlanning.Location = new System.Drawing.Point(115, 349);
            this.dataGridViewEditerPlanning.Name = "dataGridViewEditerPlanning";
            this.dataGridViewEditerPlanning.RowHeadersWidth = 62;
            this.dataGridViewEditerPlanning.RowTemplate.Height = 28;
            this.dataGridViewEditerPlanning.Size = new System.Drawing.Size(1608, 447);
            this.dataGridViewEditerPlanning.TabIndex = 0;
            this.dataGridViewEditerPlanning.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edition d\'un jour de présence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selectionnez un jour à éditer";
            // 
            // FormUIEditerPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 915);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEditerPlanning);
            this.Name = "FormUIEditerPlanning";
            this.Text = "FormUIEditerPlanning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditerPlanning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEditerPlanning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}