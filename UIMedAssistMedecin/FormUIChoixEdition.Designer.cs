
namespace UIMedAssistMedecin
{
    partial class FormUIChoixEdition
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
            this.btEditionJournee = new System.Windows.Forms.Button();
            this.btEditionMatinee = new System.Windows.Forms.Button();
            this.btEditionApresMidi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEditionJournee
            // 
            this.btEditionJournee.Location = new System.Drawing.Point(67, 88);
            this.btEditionJournee.Name = "btEditionJournee";
            this.btEditionJournee.Size = new System.Drawing.Size(133, 62);
            this.btEditionJournee.TabIndex = 0;
            this.btEditionJournee.Text = "Editer une journée";
            this.btEditionJournee.UseVisualStyleBackColor = true;
            this.btEditionJournee.Click += new System.EventHandler(this.btEditionJournee_Click);
            // 
            // btEditionMatinee
            // 
            this.btEditionMatinee.Location = new System.Drawing.Point(295, 88);
            this.btEditionMatinee.Name = "btEditionMatinee";
            this.btEditionMatinee.Size = new System.Drawing.Size(112, 62);
            this.btEditionMatinee.TabIndex = 1;
            this.btEditionMatinee.Text = "Editer une matinée";
            this.btEditionMatinee.UseVisualStyleBackColor = true;
            this.btEditionMatinee.Click += new System.EventHandler(this.btEditionMatinee_Click);
            // 
            // btEditionApresMidi
            // 
            this.btEditionApresMidi.Location = new System.Drawing.Point(503, 88);
            this.btEditionApresMidi.Name = "btEditionApresMidi";
            this.btEditionApresMidi.Size = new System.Drawing.Size(124, 62);
            this.btEditionApresMidi.TabIndex = 2;
            this.btEditionApresMidi.Text = "Editer une après-midi";
            this.btEditionApresMidi.UseVisualStyleBackColor = true;
            this.btEditionApresMidi.Click += new System.EventHandler(this.btEditionApresMidi_Click);
            // 
            // FormUIChoixEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 243);
            this.Controls.Add(this.btEditionApresMidi);
            this.Controls.Add(this.btEditionMatinee);
            this.Controls.Add(this.btEditionJournee);
            this.Name = "FormUIChoixEdition";
            this.Text = "FormUIChoixEdition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEditionJournee;
        private System.Windows.Forms.Button btEditionMatinee;
        private System.Windows.Forms.Button btEditionApresMidi;
    }
}