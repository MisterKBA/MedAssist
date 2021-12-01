
namespace UIMedAssistMedecin
{
    partial class FormUiEditerMatinee
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHdebut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxhFinM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSaveAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Format hh:mm";
            // 
            // textBoxHdebut
            // 
            this.textBoxHdebut.Location = new System.Drawing.Point(65, 282);
            this.textBoxHdebut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxHdebut.Name = "textBoxHdebut";
            this.textBoxHdebut.Size = new System.Drawing.Size(153, 26);
            this.textBoxHdebut.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Heure début de journée";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Format hh:mm";
            // 
            // textBoxhFinM
            // 
            this.textBoxhFinM.Location = new System.Drawing.Point(400, 282);
            this.textBoxhFinM.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxhFinM.Name = "textBoxhFinM";
            this.textBoxhFinM.Size = new System.Drawing.Size(153, 26);
            this.textBoxhFinM.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Heure fin de matinée";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(118, 366);
            this.btValider.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(227, 59);
            this.btValider.TabIndex = 20;
            this.btValider.Text = "Valider les changements";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nouvelles heures à rentrée";
            // 
            // btSaveAPI
            // 
            this.btSaveAPI.Location = new System.Drawing.Point(380, 366);
            this.btSaveAPI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSaveAPI.Name = "btSaveAPI";
            this.btSaveAPI.Size = new System.Drawing.Size(227, 59);
            this.btSaveAPI.TabIndex = 22;
            this.btSaveAPI.Text = "Valider les changements via l\'api";
            this.btSaveAPI.UseVisualStyleBackColor = true;
            this.btSaveAPI.Click += new System.EventHandler(this.btSaveAPI_Click);
            // 
            // FormUiEditerMatinee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSaveAPI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxhFinM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHdebut);
            this.Controls.Add(this.label2);
            this.Name = "FormUiEditerMatinee";
            this.Text = "FormUiEditerMatinee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHdebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxhFinM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSaveAPI;
    }
}