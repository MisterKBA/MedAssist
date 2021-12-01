
namespace UIMedAssistMedecin
{
    partial class FormUIComfirmationRDV
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
            this.dataGridViewConfirmation = new System.Windows.Forms.DataGridView();
            this.btConfirmer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfirmation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConfirmation
            // 
            this.dataGridViewConfirmation.AllowUserToAddRows = false;
            this.dataGridViewConfirmation.AllowUserToDeleteRows = false;
            this.dataGridViewConfirmation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfirmation.Location = new System.Drawing.Point(102, 214);
            this.dataGridViewConfirmation.Name = "dataGridViewConfirmation";
            this.dataGridViewConfirmation.ReadOnly = true;
            this.dataGridViewConfirmation.RowHeadersWidth = 62;
            this.dataGridViewConfirmation.RowTemplate.Height = 28;
            this.dataGridViewConfirmation.Size = new System.Drawing.Size(1264, 234);
            this.dataGridViewConfirmation.TabIndex = 0;
            this.dataGridViewConfirmation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewConfirmation_CellMouseClick);
            // 
            // btConfirmer
            // 
            this.btConfirmer.Location = new System.Drawing.Point(102, 502);
            this.btConfirmer.Name = "btConfirmer";
            this.btConfirmer.Size = new System.Drawing.Size(153, 47);
            this.btConfirmer.TabIndex = 1;
            this.btConfirmer.Text = "Confirmer";
            this.btConfirmer.UseVisualStyleBackColor = true;
            this.btConfirmer.Click += new System.EventHandler(this.btConfirmer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirmation de rendez-vous";
            // 
            // FormUIComfirmationRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConfirmer);
            this.Controls.Add(this.dataGridViewConfirmation);
            this.Name = "FormUIComfirmationRDV";
            this.Text = "FormUIComfirmationRDV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfirmation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConfirmation;
        private System.Windows.Forms.Button btConfirmer;
        private System.Windows.Forms.Label label1;
    }
}