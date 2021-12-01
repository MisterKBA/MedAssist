using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMedAssistMedecin
{
    public partial class FormUIChoixEdition : Form
    {
        private int Id;
        public FormUIChoixEdition(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btEditionJournee_Click(object sender, EventArgs e)
        {
            FormUIEditerPlanningData formUIEditerPlanningData = new FormUIEditerPlanningData(Id);
            formUIEditerPlanningData.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIEditerPlanningData.MdiParent = this.MdiParent;
            formUIEditerPlanningData.Show();
        }

        private void btEditionMatinee_Click(object sender, EventArgs e)
        {
            FormUiEditerMatinee formUiEditerMatinee = new FormUiEditerMatinee(Id);
            formUiEditerMatinee.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUiEditerMatinee.MdiParent = this.MdiParent;
            formUiEditerMatinee.Show();
        }

        private void btEditionApresMidi_Click(object sender, EventArgs e)
        {
            FormUIEditerApresMidi formUIEditerApres= new FormUIEditerApresMidi(Id);
            formUIEditerApres.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIEditerApres.MdiParent = this.MdiParent;
            formUIEditerApres.Show();
        }
        private void ChildFormClosing(object sender,FormClosedEventArgs e) 
        {
            this.Close();
        }
    }
}
