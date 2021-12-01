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
    public partial class FormUIRDVMedecin : Form
    {
        private int idMedecin;
        private int idMaison;
        private int idSpecialite;
        private DateTime date;
        private TimeSpan heure;
        private int idPatient;
        private DateTime dateToCheck;
        private TimeSpan timeToCheck;
        public FormUIRDVMedecin(int idPatient)
        {
            InitializeComponent();
            dynamiccheck();
            this.idPatient = idPatient;
        }
        private void dynamiccheck()
        {

            try
            {
                BLPatient.blPatient blPatient = new BLPatient.blPatient();
                string Json = blPatient.SelectAllMedecin();
                List<Models.Models.ModelSelectMedecin> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectMedecin>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.Nom.ToString();
                    radio.Name = item.IDMedecin.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeMed);
                    flowLayoutPanelMedecin.Controls.Add(radio);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void changeMed(object sender, EventArgs e)
        {

            try
            {
                flowLayoutPanelMaison.Controls.Clear();
                flowLayoutPanelSpecialite.Controls.Clear();
                flowLayoutPanelHeureRDV.Controls.Clear();
                RadioButton radioButton = sender as RadioButton;
                this.idMedecin = int.Parse(radioButton.Name);
                BLPatient.blPatient blPatient = new BLPatient.blPatient();
                string Json = blPatient.SelectMaisonByMedecin(idMedecin);
                List<Models.Models.ModelSelectMaisons> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectMaisons>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.Nom.ToString();
                    radio.Name = item.IDMaisonM.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeMaison);
                    flowLayoutPanelMaison.Controls.Add(radio);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void changeMaison(object sender, EventArgs e)
        {

            try
            {
                flowLayoutPanelSpecialite.Controls.Clear();
                flowLayoutPanelHeureRDV.Controls.Clear();
                RadioButton radioButton = sender as RadioButton;
                this.idMaison = int.Parse(radioButton.Name);
                BLPatient.blPatient blPatient = new BLPatient.blPatient();
                string Json = blPatient.SelectSpecialiteByMaisonByMedecin(idMedecin, idMaison);
                List<Models.Models.ModelSelectAllSpecialite> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectAllSpecialite>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.Nom.ToString();
                    radio.Name = item.IDSPecialite.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changeSpecialite);
                    flowLayoutPanelSpecialite.Controls.Add(radio);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void changeSpecialite(object sender, EventArgs e)
        {
            try
            {
                RadioButton radio = sender as RadioButton;
                this.idSpecialite = int.Parse(radio.Name);
                BLPatient.blPatient blPatient = new BLPatient.blPatient();
                string Json = blPatient.SelectDateDePresence(idMedecin, idMaison);
                List<Models.Models.ModelSelectJourDePresence> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectJourDePresence>>(Json);
                List<Models.Models.ModelSelectJourDePresence> list1 = new List<Models.Models.ModelSelectJourDePresence>();
                foreach (var item in list)
                {
                    if (!(item.JourDePressence < DateTime.Now)) list1.Add(item);
                }
                dataGridViewJourDePresence.DataSource = list1;
                dataGridViewJourDePresence.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dataGridViewJourDePresence_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            flowLayoutPanelHeureRDV.Controls.Clear();
            string d = dataGridViewJourDePresence.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.date = DateTime.Parse(d);
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
                    radio.CheckedChanged += new EventHandler(changeHeure);
                    flowLayoutPanelHeureRDV.Controls.Add(radio);

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
                    radio.CheckedChanged += new EventHandler(changeHeure);
                    flowLayoutPanelHeureRDV.Controls.Add(radio);
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
                    radio.CheckedChanged += new EventHandler(changeHeure);
                    flowLayoutPanelHeureRDV.Controls.Add(radio);

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
                    radio.CheckedChanged += new EventHandler(changeHeure);
                    flowLayoutPanelHeureRDV.Controls.Add(radio);
                }
            }
        }
        private void changeHeure(object sender, EventArgs e)

        {
            RadioButton radioButton = sender as RadioButton;
            this.heure = TimeSpan.Parse(radioButton.Name);
        }

        private void btSaveRDV_Click(object sender, EventArgs e)
        {
            BLPatient.blPatient blPatient3 = new BLPatient.blPatient();
            string Json1 = blPatient3.SelectRDVPatientAndDate(idPatient, date);
            List<Models.Models.ModelSelectPatientRDV> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json1);
            TimeSpan heureDeMidi = TimeSpan.Parse("12:30");

            foreach (var item in list1)
            {
                timeToCheck = item.heure.Value;
                dateToCheck = item.date;
            }
            //Checker si il y a déjà un rendez-vous le matin à a date sélectionnée
            if ((dateToCheck == this.date) && (timeToCheck < heureDeMidi) && (this.heure < heureDeMidi))
                MessageBox.Show("Vous avez déjà un rendez-vous programmé le matin. " +
                                 "\n Vous pouvez reprogrammer un rendez-vous pour l'après midi");

            //Checker si il y a déjà un rendez-vous l'après-midi à la date sélectionnée
            else if ((dateToCheck == this.date) && (timeToCheck > heureDeMidi) && (this.heure > heureDeMidi))
                MessageBox.Show("Vous avez déjà un rendez-vous programmé l'après-midi. " +
                                 "\n Vous pouvez reprogrammer un rendez-vous pour le matin");
            else
                try
                {
                    BLPatient.blPatient blPatient = new BLPatient.blPatient();
                    List<dynamic> listRDV = new List<dynamic>();
                    dynamic spec = new ExpandoObject();
                    spec.idPatient = this.idPatient.ToString();
                    spec.idMedecin = this.idMedecin.ToString();
                    spec.idMaison = this.idMaison.ToString();
                    spec.idSpecialite = this.idSpecialite.ToString();
                    spec.heure = this.heure.ToString();
                    spec.date = this.date.ToString();
                    listRDV.Add(spec);
                    string Json = JsonConvert.SerializeObject(listRDV, Formatting.Indented);
                    blPatient.AddPRDVMode1(Json);
                    BLPatient.blPatient blPatient2 = new BLPatient.blPatient();
                    string json2 = blPatient2.SelectPatientById(idPatient);
                    List<Models.Models.ModelSelectPatient> listPatient = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatient>>(json2);
                    string patientNom = "";
                    string patientPrenom = "";
                    foreach (var item in listPatient)
                    {
                        patientNom = item.Nom;
                        patientPrenom = item.Prenom;
                    }
                    BLPatient.blPatient blPatient1 = new BLPatient.blPatient();
                    string JsonRDV = blPatient.SelectRDVPatientCreer(idPatient, date, heure);
                    List<Models.Models.ModelUiSelectRDVPatientPHD> listRDVPatient = JsonConvert.DeserializeObject<List<Models.Models.ModelUiSelectRDVPatientPHD>>(JsonRDV);
                    string medecinNom = "";
                    string medecinPrenom = "";
                    string dateRDV = "";
                    string heureRDV = "";
                    string local = "";
                    string MaisonMedical = "";
                    foreach (var item in listRDVPatient)
                    {
                        medecinNom = item.Nom;
                        medecinPrenom = item.Prenom_Medecin;
                        dateRDV = item.DateRDV.ToString();
                        heureRDV = item.HeureRDV.ToString();
                        local = item.Local;
                        MaisonMedical = item.Maison;

                    }
                    MessageBox.Show("Un rendez-vous à été prit. \n Patien :" + patientNom + " " + patientPrenom + "\n" +
                    "Médecin :" + medecinNom + " " + medecinPrenom + "\n" +
                    "Maison médicale :" + MaisonMedical + " Locale :" + local + "\n" +
                    "Heure du rendez-vous :" + heureRDV + "\n" +
                    "Date du rendez-vous :" + date);
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }
        }

        private async void btSaveAPI_Click(object sender, EventArgs e)
        {
            string id = idPatient.ToString();
            string date1 = date.ToString("yyyy-MM-dd");
            string values = id + "/" + date1;

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri(@"https://localhost:44399/Patient/date/" + values));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                TimeSpan heureDeMidi1 = TimeSpan.Parse("12:30");
                foreach (var item in convert)
                {
                    timeToCheck = item.heure;
                    dateToCheck = item.date;
                }
                //Checker si il y a déjà un rendez-vous le matin à a date sélectionnée
                if ((dateToCheck == this.date) && (timeToCheck < heureDeMidi1) && (this.heure < heureDeMidi1))
                    MessageBox.Show("Vous avez déjà un rendez-vous programmé le matin. " +
                                     "\n Vous pouvez reprogrammer un rendez-vous pour l'après midi");

                //Checker si il y a déjà un rendez-vous l'après-midi à la date sélectionnée
                else if ((dateToCheck == this.date) && (timeToCheck > heureDeMidi1) && (this.heure > heureDeMidi1))
                    MessageBox.Show("Vous avez déjà un rendez-vous programmé l'après-midi. " +
                                     "\n Vous pouvez reprogrammer un rendez-vous pour le matin");
                else
                {
                    var httpClient = new HttpClient();
                    List<dynamic> listRDV1 = new List<dynamic>();
                    dynamic spec1 = new ExpandoObject();
                    spec1.idPatient = this.idPatient.ToString();
                    spec1.idMedecin = this.idMedecin.ToString();
                    spec1.idMaison = this.idMaison.ToString();
                    spec1.idSpecialite = this.idSpecialite.ToString();
                    spec1.heure = this.heure.ToString();
                    spec1.date = this.date.ToString();
                    listRDV1.Add(spec1);
                    var serialized = JsonConvert.SerializeObject(listRDV1);
                    var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                    var response1 = await httpClient.PostAsync("https://localhost:44399/Patient/AddRDV/", content1);
                    var code = (int)response1.StatusCode;
                    if ((response1.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le rendez-vous est enregistré via l'API");
                    else
                    {
                        string contentError = response1.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
            this.Close();
        }
    }
}
