using Newtonsoft.Json;
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
    public partial class FormUIEditerRDV : Form
    {
        private int Id;
        public FormUIEditerRDV(int Id)
        {
            InitializeComponent();
            loadData(Id);
            this.Id = Id;
           
        }
        private void loadData(int id) 
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            string Json1 = blPatient.SelectPatientRDV(id);
            List<Models.Models.ModelSelectPatientRDV> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json1);
            dataGridViewRDVPatient.DataSource = list1;
            dataGridViewRDVPatient.Columns[0].Visible = false;
            dataGridViewRDVPatient.Columns[3].Visible = false;
            dataGridViewRDVPatient.Columns[4].Visible = false;
            dataGridViewRDVPatient.Columns[5].Visible = false;
            dataGridViewRDVPatient.Columns[10].Visible = false;
        }

        private void dataGridViewRDVPatient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string IdR= dataGridViewRDVPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
            string aH = dataGridViewRDVPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
            string d = dataGridViewRDVPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
            string idMe = dataGridViewRDVPatient.Rows[e.RowIndex].Cells[10].Value.ToString();
            string idM = dataGridViewRDVPatient.Rows[e.RowIndex].Cells[5].Value.ToString();
            string idspec = dataGridViewRDVPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
            string idCons = dataGridViewRDVPatient.Rows[e.RowIndex].Cells[11].Value.ToString();
            int IdRDV = int.Parse(IdR);        
            TimeSpan anHeure = TimeSpan.Parse(aH);
            DateTime date = DateTime.Parse(d);           
            int idMedecin = int.Parse(idMe);
            int idMaison = int.Parse(idM);
            int idSPecialite = int.Parse(idspec);
            int idConsultation = int.Parse(idCons);
            FormUIOptionEditionRDV formUIOptionEditionRDV = new FormUIOptionEditionRDV(date, idMedecin, idMaison, idSPecialite, idConsultation, IdRDV, anHeure);
            formUIOptionEditionRDV.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIOptionEditionRDV.Show();
            
        }

        private void dataGridViewRDVPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ChildFormClosing(object sender, FormClosedEventArgs e) 
        {
            loadData(Id);
        }
    }
}
