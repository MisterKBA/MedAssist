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
    public partial class FormUiEditerMatinee : Form
    {
        private int Id;
        private TimeSpan MatinéePremier;
        private TimeSpan MatinéeDernier;
        public FormUiEditerMatinee(int Id)
        {
            InitializeComponent();
            this.Id=Id;
        }
        private void btValider_Click(object sender, EventArgs e)
        {
            BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
            string JsonMatinPremier = bLMedecin.SelectConsultationMatinPremier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listMatinPremier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonMatinPremier);
            string JsonMatinDernier = bLMedecin.SelectConsultationMatinDernier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listMatinDernier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonMatinDernier);
            
            foreach (var item in listMatinPremier)
            {
                MatinéePremier = item.DebutConsulation.Value;
            }
            foreach (var item in listMatinDernier)
            {
                MatinéeDernier = item.FinConsultation.Value;
            }
            if ((textBoxHdebut.Text == "") || (textBoxhFinM.Text == "")) 
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan timed, timefm;
                if ((!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) || (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm)))
                {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) textBoxHdebut.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm)) textBoxhFinM.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires
                    TimeSpan t1 = TimeSpan.Parse("08:00");
                    TimeSpan t2 = TimeSpan.Parse("12:00");
                    TimeSpan t0 = TimeSpan.Parse("00:00");
                    if (
                        ((timed < t1) || (timed > t2)) ||
                        ((timefm < t1) || (timefm > t2)) 
                        )
                    {
                        MessageBox.Show(" L'heure du début de journée doit être entre 08:00 et 12:00" +
                            "\n L'heure fin de matinée doit être comprise entre 08:00 et 12:00");
                        if ((timed < t1) || (timed > t2)) textBoxHdebut.Text = "";
                        if ((timefm < t1) || (timefm > t2)) textBoxhFinM.Text = "";
                    }
                    else
                    {
                        if ((timed > MatinéePremier) && (MatinéePremier!=t0)) MessageBox.Show("Il y a déjà une consultation programmée"+
                            "\n La première de consultationest à : "+MatinéePremier.ToString());

                        else if ((timefm < MatinéeDernier) && (MatinéePremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée"+
                            "\n La dernière heure de consultationest pour le matin est à : " + MatinéeDernier.ToString());
                        else
                        try
                        {
                            BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                            List<dynamic> listPlanning = new List<dynamic>();
                            dynamic planning = new ExpandoObject();
                            planning.PlanningId = this.Id.ToString();
                            planning.Heured = textBoxHdebut.Text.ToString();
                            planning.Heurefm = textBoxhFinM.Text.ToString();
                            listPlanning.Add(planning);
                            string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                            blMedecin.UpdatePlanningMedecinMatin(Json);
                            MessageBox.Show("Le jour a bien été édité", "Succès");
                            this.Close();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
        }

        private async void btSaveAPI_Click(object sender, EventArgs e)
        {        
            string id = Id.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/ConsultationMatinPremier/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic list = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                foreach (var item in list)
                {
                    MatinéePremier = item.DebutConsulation.Value;
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }

            var response1 = await client.GetAsync(new Uri("https://localhost:44399/Medecin/ConsultationMatinDernier/" + id));
            if (response1.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic list1 = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                foreach (var item in list1)
                {
                    MatinéeDernier = item.FinConsultation.Value;
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }

            if ((textBoxHdebut.Text == "") || (textBoxhFinM.Text == ""))
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan timed, timefm;
                if ((!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) || (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm)))
                                    {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) textBoxHdebut.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm)) textBoxhFinM.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires

                    TimeSpan t1 = TimeSpan.Parse("08:00");
                    TimeSpan t2 = TimeSpan.Parse("12:00");
                    TimeSpan t0 = TimeSpan.Parse("00:00");

                    if (
                        ((timed < t1) || (timed > t2)) ||
                        ((timefm < t1) || (timefm > t2)) 
                        )
                    {
                        MessageBox.Show(" L'heure du début de journée doit être entre 08:00 et 12:00" +
                            "\n L'heure fin de matinée doit être comprise entre 08:00 et 12:00" );
                        if ((timed < t1) || (timed > t2)) textBoxHdebut.Text = "";
                        if ((timefm < t1) || (timefm > t2)) textBoxhFinM.Text = "";

                    }
                    else
                    {
                        if ((timed > MatinéePremier) && (MatinéePremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                                "\n La première de consultationest à : " + MatinéePremier.ToString());

                        else if ((timefm < MatinéeDernier) && (MatinéePremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                                "\n La dernière heure de consultationest pour le matin est à : " + MatinéeDernier.ToString());

                        else
                            try
                            {
                                var httpClient = new HttpClient();
                                List<dynamic> listPlanning = new List<dynamic>();
                                dynamic planning = new ExpandoObject();
                                planning.PlanningId = this.Id.ToString();
                                planning.Heured = textBoxHdebut.Text.ToString();
                                planning.Heurefm = textBoxhFinM.Text.ToString();
                                listPlanning.Add(planning);
                                var serialized = JsonConvert.SerializeObject(listPlanning);
                                var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                                var response5 = await httpClient.PostAsync("https://localhost:44399/Medecin/UpdatePlanningMatin/", content1);
                                var code = (int)response1.StatusCode;
                                if ((response5.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le jour a bien été édité via l'api", "Succès");
                                else
                                {
                                    string contentError = response1.Content.ReadAsStringAsync().Result;
                                }
                                this.Close();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                    }
                }
            }
            
        }
    }
}
