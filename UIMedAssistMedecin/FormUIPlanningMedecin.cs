using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMedAssistMedecin
{
    public partial class FormUIPlanningMedecin : Form
    {
        private int Id;      
        public FormUIPlanningMedecin(int Id)
        {
            this.Id = Id;
            InitializeComponent();
            OnloadDataPlanning(Id);
            OnloadDataMedecin(Id);
            OnLoadDataConsultation(Id);
            OnloadDataPlanningAPI(Id);
            OnLoadDataConsultationAPI(Id);
            FormUIComfirmationRDV form = new FormUIComfirmationRDV(Id);
            form.MdiParent = this.MdiParent;
            form.Show();
        }
        private void OnloadDataPlanning(int Id) 
        {
            try
            {
                BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
                string Json = bLMedecin.SelectPlanningMedecinById(Id);
                List<Models.Models.ModelSelectPlanningMed> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPlanningMed>>(Json);
                dataGridViewPlanning.DataSource = list;
                dataGridViewPlanning.Columns[6].Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void OnloadDataMedecin(int Id) 
        {
            try
            {
                BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
                string Json = bLMedecin.SelectMedecinById(Id);
                List<Models.Models.ModelSelectMedecin> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectMedecin>>(Json);
                foreach (var item in list)
                {
                    labelNomMedecin.Text = item.Nom.ToString();
                    labelIdMedecin.Text = item.IDMedecin.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void OnLoadDataConsultation(int Id) 
        {
            BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
            string Json = bLMedecin.SelectConsultationMedecin(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(Json);
            dataGridViewPlanningRDV.DataSource = list;
            dataGridViewPlanningRDV.Columns[0].Visible = false;
            dataGridViewPlanningRDV.Columns[2].Visible = false;
            dataGridViewPlanningRDV.Columns[5].Visible = false;
            dataGridViewPlanningRDV.Columns[8].Visible = false;
            dataGridViewPlanningRDV.Columns[10].Visible = false;
        }
        private async void OnloadDataPlanningAPI(int Id) 
        {
            string id = Id.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/Planning/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                dataGridViewPresenceAPI.DataSource = convert;
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
        }
        private async void OnLoadDataConsultationAPI(int Id) 
        {
            string id = Id.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/PlanningRDV/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                dataGridViewRDVAPI.DataSource = convert;
                /*dataGridViewRDVAPI.Columns[0].Visible = false;
                dataGridViewRDVAPI.Columns[2].Visible = false;
                dataGridViewRDVAPI.Columns[5].Visible = false;
                dataGridViewRDVAPI.Columns[8].Visible = false;
                dataGridViewRDVAPI.Columns[10].Visible = false;*/
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void ajouterJourDePrésenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUIPlanningAjouter formUIPlanningAjouter = new FormUIPlanningAjouter(this.Id);
            formUIPlanningAjouter.MdiParent = this.MdiParent;
            formUIPlanningAjouter.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIPlanningAjouter.Show();
        }
        private void ChildFormClosing(object sender, FormClosedEventArgs e) 
        {
            OnloadDataPlanning(Id);
            OnloadDataMedecin(Id);
            //OnloadDataPlanningAPI(Id);
            //OnLoadDataConsultationAPI(Id);
        }
        private void editerUnJourDePrésenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormUIEditerPlanning formUIEditerPlanning = new FormUIEditerPlanning(Id);
            formUIEditerPlanning.MdiParent = this.MdiParent;
            formUIEditerPlanning.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIEditerPlanning.Show();
        }
        private void supprimerUnJourDuPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUISupprimerJourPlanning formUISupprimerJourPlanning = new FormUISupprimerJourPlanning(Id);
            formUISupprimerJourPlanning.MdiParent = this.MdiParent;
            formUISupprimerJourPlanning.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUISupprimerJourPlanning.Show();
        }
        private void spécialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUISpecialite formUISpecialite = new FormUISpecialite(Id);
            formUISpecialite.MdiParent = this.MdiParent;
            formUISpecialite.Show();
            this.Close();
        }
    }
}
