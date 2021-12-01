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

namespace UIMedAssistMedecin
{
    public partial class FormUISupprimerJourPlanning : Form
    {
        private string Id;
        private int IdPlanning;
        public FormUISupprimerJourPlanning(int Id)
        {
            InitializeComponent();
            OnloadDataPlanning(Id);
            
        }
        private void OnloadDataPlanning(int Id)
        {
            try
            {
                BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
                string Json = bLMedecin.SelectPlanningMedecinById(Id);
                List<Models.Models.ModelSelectPlanningMed> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPlanningMed>>(Json);
                dataGridViewSupprimerPlanning.DataSource = list;
                dataGridViewSupprimerPlanning.Columns[6].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
            string JsonCons = blMedecin.SelectConsultationByIdPlanning(IdPlanning);
            List<Models.Models.ModelSelectConsultationMedecinById> listCons = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonCons);
            List<dynamic> listPlanning = new List<dynamic>();
            dynamic planning = new ExpandoObject();
            if (listCons.Any()) MessageBox.Show("Il y a déjà des rendez-vous prévu à cette date");
            else if(MessageBox.Show("Etes vous sûre de vouloir supprimer ce jour de présence", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)          
            {
                planning.PlanningId = this.Id.ToString();               
                listPlanning.Add(planning);
                string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                blMedecin.DeletePlanningMedecin(Json);
                MessageBox.Show("Le jour a bien été supprimé");
                this.Close();
            }         
        }
        private void dataGridViewSupprimerPlanning_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Id= dataGridViewSupprimerPlanning.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.IdPlanning = int.Parse(Id);
        }

        private async void btDeleteAPI_Click(object sender, EventArgs e)
        {
            string id = IdPlanning.ToString();
            HttpClient client = new HttpClient();
            var response =await client.GetAsync(new Uri("https://localhost:44399/Medecin/Consultation/" + id));
            dynamic planning = new ExpandoObject();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic listCons = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                List<dynamic>ListPlanning= new List<dynamic>();
                dynamic Planning1 = new ExpandoObject();
                string check = ((object)listCons).ToString();
                Planning1.PlanningId = this.Id.ToString();
                ListPlanning.Add(Planning1);
                if (check!="[]") MessageBox.Show("Il y a déjà des rendez-vous prévu à cette date");
                else if (MessageBox.Show("Etes vous sûre de vouloir supprimer ce jour de présence", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var httpClient = new HttpClient();
                    
                    var serialized = JsonConvert.SerializeObject(ListPlanning);
                    var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                    var response1 = await httpClient.PostAsync("https://localhost:44399/Medecin/DeletePlanning/", content1);
                    var code = (int)response1.StatusCode;
                    if ((response1.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le jour a bien été supprimé via l'API");
                    else
                    {
                        string contentError = response1.Content.ReadAsStringAsync().Result;
                    }
                    this.Close();
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
        }
    }

    
}
