
namespace UIMedAssistPatient
{
    partial class FormUIEditerRDV
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
            this.dataGridViewRDVPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRDVPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un jour à éditer";
            // 
            // dataGridViewRDVPatient
            // 
            this.dataGridViewRDVPatient.AllowUserToAddRows = false;
            this.dataGridViewRDVPatient.AllowUserToDeleteRows = false;
            this.dataGridViewRDVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRDVPatient.Location = new System.Drawing.Point(54, 142);
            this.dataGridViewRDVPatient.Name = "dataGridViewRDVPatient";
            this.dataGridViewRDVPatient.ReadOnly = true;
            this.dataGridViewRDVPatient.RowHeadersWidth = 62;
            this.dataGridViewRDVPatient.RowTemplate.Height = 28;
            this.dataGridViewRDVPatient.Size = new System.Drawing.Size(694, 270);
            this.dataGridViewRDVPatient.TabIndex = 1;
            this.dataGridViewRDVPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRDVPatient_CellContentClick);
            this.dataGridViewRDVPatient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRDVPatient_CellMouseClick);
            // 
            // FormUIEditerRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRDVPatient);
            this.Controls.Add(this.label1);
            this.Name = "FormUIEditerRDV";
            this.Text = "FormEditerRDV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRDVPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRDVPatient;
    }
}