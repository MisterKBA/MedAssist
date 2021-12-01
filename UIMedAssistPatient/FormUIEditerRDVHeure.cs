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
    public partial class FormUIEditerRDVHeure : Form
    {
        private TimeSpan heure;
        private DateTime date;
        private int idMedecin;
        private int idMaison;
        private int idRDV;
        private int idSpecialite;
        private int idConsultation;
        private TimeSpan anHeure;
        public FormUIEditerRDVHeure(DateTime date,int idMedecin,int idMaison,int idSpecialite,int idConsultation,int idRDV,TimeSpan anHeure)
        {
            InitializeComponent();
            LoadHeureDispo(date, idMedecin, idMaison);
            this.date = date;
            this.idMedecin = idMedecin;
            this.idMaison = idMaison;
            this.idRDV = idRDV;
            this.idSpecialite = idSpecialite;
            this.anHeure = anHeure;
            this.idConsultation = idConsultation;
        }

        public void LoadHeureDispo(DateTime date,int idMedecin,int idMaison)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            string Json = blPatient.SelectHeureConsultationByMMatin(date, idMedecin, idMaison);
            string Json1 = blPatient.SelectHeureConsultationByMMidi(date, idMedecin, idMaison);
            string JsonMat = blPatient.SelectHeureConsultationMAt(date, idMaison, idMedecin);
            string JsonAp = blPatient.SelectHeureConsultationAp(date, idMaison, idMedecin);
            List<Models.Models.ModelSelectHeureRDVMCon> listconMat = new List<Models.Models.ModelSelectHeureRDVMCon>();
            List<Models.Models.ModelSelectHeureRDVMCon> listconAp = new List<Models.Models.ModelSelectHeureRDVMCon>();
            List<Models.Models.ModelSelectHeureRDVMPlan> listplan = new List<Models.Models.ModelSelectHeureRDVMPlan>();
            if (Json.Contains("DebutConsulation"))
            {
                listconMat = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectHeureRDVMCon>>(JsonMat);
                foreach (var item in listconMat)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.FinConsultation.ToString();
                    radio.Name = item.FinConsultation.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeHeureM);
                    flowLayoutPanelHeure.Controls.Add(radio);
                }
            }
            else
            {
                listplan = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectHeureRDVMPlan>>(Json);
                foreach (var item in listplan)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.HeureDebutJournee.ToString();
                    radio.Name = item.HeureDebutJournee.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeHeureM);
                    flowLayoutPanelHeure.Controls.Add(radio);
                }
            }
            if (Json1.Contains("DebutConsulation"))
            {
                listconAp = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectHeureRDVMCon>>(JsonAp);
                foreach (var item in listconAp)
                {

                    RadioButton radio = new RadioButton();
                    radio.Text = item.FinConsultation.ToString();
                    radio.Name = item.FinConsultation.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeHeureM);
                    flowLayoutPanelHeure.Controls.Add(radio);
                }
            }
            else
            {
                foreach (var item in listplan)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.HeureDebutAprem.ToString();
                    radio.Name = item.HeureDebutAprem.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeHeureM);
                    flowLayoutPanelHeure.Controls.Add(radio);
                }
            }
        }
        private void changeHeureM(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            this.heure = TimeSpan.Parse(radioButton.Name);
        }
        private void btUpdateRDV_Click(object sender, EventArgs e)
        {
           BLPatient.blPatient blPatient = new BLPatient.blPatient();
            List<dynamic> listRDV = new List<dynamic>();
            dynamic RDV = new ExpandoObject();
            RDV.date = this.date.ToString();
            RDV.idRDV = this.idRDV.ToString();
            RDV.idConsultation = this.idConsultation.ToString();
            RDV.idMedecin = this.idMedecin.ToString();
            RDV.idMaison = this.idMaison.ToString();
            RDV.idSpecialite = this.idSpecialite.ToString();
            RDV.anHeure = this.anHeure.ToString();
            RDV.heure = this.heure.ToString();
            listRDV.Add(RDV);
            string Json = JsonConvert.SerializeObject(listRDV, Formatting.Indented);
            blPatient.UpdateRDV(Json);
            MessageBox.Show("Le rendez-vous a bien été modifié", "Succès");
            this.Close();
        }

        private async void btSaveAPI_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            List<dynamic> listRDV1 = new List<dynamic>();
            dynamic RDV1 = new ExpandoObject();
            RDV1.date = this.date.ToString();
            RDV1.idRDV = this.idRDV.ToString();
            RDV1.idConsultation = this.idConsultation.ToString();
            RDV1.idMedecin = this.idMedecin.ToString();
            RDV1.idMaison = this.idMaison.ToString();
            RDV1.idSpecialite = this.idSpecialite.ToString();
            RDV1.anHeure = this.anHeure.ToString();
            RDV1.heure = this.heure.ToString();
            listRDV1.Add(RDV1);
            var serialized = JsonConvert.SerializeObject(listRDV1);
            var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
            var response1 = await httpClient.PostAsync("https://localhost:44399/Patient/UpdateRDV/", content1);
            var code = (int)response1.StatusCode;
            if ((response1.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le rendez-vous a bien été modifié et enregistré via l'API");
            else
            {
                string contentError = response1.Content.ReadAsStringAsync().Result;
            }
            this.Close();
        }
    }
}

//date,idPlanningRDV,idConsultation,idMedecin,iDMaison,idSpecialite,anHeure,heure