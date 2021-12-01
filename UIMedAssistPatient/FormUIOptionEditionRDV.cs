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
    public partial class FormUIOptionEditionRDV : Form
    {
        private DateTime date;
        private int idMedecin;
        private int idMaison;
        private int idRDV;
        private int idSpecialite;
        private int idConsultation;
        private TimeSpan anHeure;
        public FormUIOptionEditionRDV(DateTime date,int idMedecin,int idMaison,int idSPecialite,int idConsultation,int IdRDV,TimeSpan anHeure)
        {
            InitializeComponent();
            this.date = date;
            this.idMedecin = idMedecin;
            this.idMaison = idMaison;
            this.idRDV = IdRDV;
            this.idSpecialite = idSPecialite;
            this.anHeure = anHeure;
            this.idConsultation = idConsultation;
        }
        private void btEditionHeure_Click(object sender, EventArgs e)
        {
            FormUIEditerRDVHeure formUIEditerRDVHeure = new FormUIEditerRDVHeure(date, idMedecin, idMaison, idSpecialite, idConsultation, idRDV, anHeure);
            formUIEditerRDVHeure.MdiParent = this.MdiParent;
            formUIEditerRDVHeure.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIEditerRDVHeure.Show();           
        }
        private void btEditionDateHeure_Click(object sender, EventArgs e)
        {
            FormUIEditerDateHeure formUIEditerDateHeure = new FormUIEditerDateHeure(date, idMedecin, idMaison, idSpecialite, idConsultation, idRDV, anHeure);
            formUIEditerDateHeure.MdiParent = this.MdiParent;
            formUIEditerDateHeure.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIEditerDateHeure.Show();  
        }
        private void ChildFormClosing(object sender, FormClosedEventArgs e) 
        {
            this.Close();
        }
    }
}
