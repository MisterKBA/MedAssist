using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMedAssistPatient
{
    public partial class FormUIPrendreRDVOption : Form
    {
        private int idP;
        public FormUIPrendreRDVOption(int idP)
        {
            this.idP = idP;
            InitializeComponent();
        }

        private void btRDVMaisonM_Click(object sender, EventArgs e)
        {
            FormUIRDVMaisonMedical formRDVMaisonMedical = new FormUIRDVMaisonMedical(this.idP);
            formRDVMaisonMedical.MdiParent = this.MdiParent;
            formRDVMaisonMedical.FormClosed += new FormClosedEventHandler(childFormClosing);
            formRDVMaisonMedical.Show();
            
        }

        private void btRDVMedecin_Click(object sender, EventArgs e)
        {
            FormUIRDVMedecin formRDVMedecin = new FormUIRDVMedecin(this.idP);
            formRDVMedecin.MdiParent=this.MdiParent;
            formRDVMedecin.FormClosed += new FormClosedEventHandler(childFormClosing);
            formRDVMedecin.Show();
            
        }
        private void childFormClosing(object sender, FormClosedEventArgs e) 
        {
            this.Close();
        }
    }
}
