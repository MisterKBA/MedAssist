using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMedAssistPatient
{
    public partial class FormUISupprimerRDV : Form
    {
        private int Id;
        private TimeSpan heure;
        private int idPlanning;
        private int idConsultation;
        private DateTime date;
        private int idLocal;
        public FormUISupprimerRDV(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            onLoadData(Id);
        }
        private void onLoadData(int Id)
        { 

            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            string Json = blPatient.SelectPatientRDV(Id);
            List<Models.Models.ModelSelectPatientRDV> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json);
            dataGridViewRDV.DataSource = list;
            dataGridViewRDV.Columns[0].Visible = false;
            dataGridViewRDV.Columns[3].Visible = false;
            dataGridViewRDV.Columns[4].Visible = false;
            dataGridViewRDV.Columns[5].Visible = false;
        }
        private void btSupprimerRDV_Click(object sender, EventArgs e)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            List<dynamic> listRDV = new List<dynamic>();
            dynamic RDV = new ExpandoObject();

            if (MessageBox.Show("Etes vous sûre de vouloir supprimer ce jour de présence", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                RDV.idRDV = this.idPlanning.ToString();
                RDV.idConsultation = this.idConsultation.ToString();
                RDV.idlocal = this.idLocal.ToString();
                RDV.date = this.date.ToString();
                RDV.heure = this.heure.ToString();
                listRDV.Add(RDV);
                string Json = JsonConvert.SerializeObject(listRDV, Formatting.Indented);
                blPatient.DeleteRDV(Json);
                MessageBox.Show("Le jour a bien été supprimé");
                this.Close();
            }
        }

        private void dataGridViewRDV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string h = dataGridViewRDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            string plann = dataGridViewRDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Cons = dataGridViewRDV.Rows[e.RowIndex].Cells[11].Value.ToString();
            string dat = dataGridViewRDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            string local = dataGridViewRDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.heure = TimeSpan.Parse(h);
            this.idPlanning = int.Parse(plann);
            this.idConsultation = int.Parse(Cons);
            this.date = DateTime.Parse(dat);
            this.idLocal = int.Parse(local);
        }

        private async void btDeleteAPI_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            List<dynamic> listdel = new List<dynamic>();
            dynamic RDVdel = new ExpandoObject();
            RDVdel.idRDV = this.idPlanning.ToString();
            RDVdel.idConsultation = this.idConsultation.ToString();
            RDVdel.idlocal = this.idLocal.ToString();
            RDVdel.date = this.date.ToString();
            RDVdel.heure = this.heure.ToString();
            listdel.Add(RDVdel);
            var serialized = JsonConvert.SerializeObject(listdel);
            var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
            var response1 = await httpClient.PostAsync("https://localhost:44399/Patient/DeleteRDV/", content1);
            var code = (int)response1.StatusCode;
            if ((response1.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le jour a bien été supprimé");
            else
            {
                string contentError = response1.Content.ReadAsStringAsync().Result;
            }
            this.Close();
        }
    }
}
