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
    public partial class FormUIEditerPlanningData : Form
    {
        private int Id;
        private TimeSpan ApresPremier;
        private TimeSpan ApresDernier;
        private TimeSpan MatinéePremier;
        private TimeSpan MatinéeDernier;
        public FormUIEditerPlanningData(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
            string JsonMatinPremier = bLMedecin.SelectConsultationMatinPremier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listMatinPremier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonMatinPremier);
            string JsonMatinDernier = bLMedecin.SelectConsultationMatinDernier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listMatinDernier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonMatinDernier);
            string JsonApresMidiPremier = bLMedecin.SelectConsultationApresMidiPremier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listApresMidiPremier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonApresMidiPremier);
            string JsonApresMidiDernier = bLMedecin.SelectConsultationApresMidiDernier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listApresMidiDernier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonApresMidiDernier);
            foreach (var item in listMatinPremier)
            {
                MatinéePremier = item.DebutConsulation.Value;
            }
            foreach (var item in listMatinDernier)
            {
                MatinéeDernier = item.FinConsultation.Value;
            }
            foreach (var item in listApresMidiPremier)
            {
                ApresPremier = item.DebutConsulation.Value;
            }
            foreach (var item in listApresMidiDernier)
            {
                ApresDernier = item.FinConsultation.Value;
            }

            if ((textBoxHdebut.Text == "") || (textBoxhFinM.Text == "") || (textBoxHdebutA.Text == "") || (textBoxhFinJ.Text == ""))
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan timed, timefm, timeda, timefj;
                if ((!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) || (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm))
                    || (!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) || (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)))
                {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) textBoxHdebut.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm)) textBoxhFinM.Text = "";
                    if (!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) textBoxHdebutA.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)) textBoxhFinJ.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires

                    TimeSpan t1 = TimeSpan.Parse("08:00");
                    TimeSpan t2 = TimeSpan.Parse("12:00");
                    TimeSpan t3 = TimeSpan.Parse("13:00");
                    TimeSpan t4 = TimeSpan.Parse("18:00");
                    TimeSpan t0 = TimeSpan.Parse("00:00");

                    if (
                        ((timed < t1) || (timed > t2)) ||
                        ((timefm < t1) || (timefm > t2)) ||
                        ((timeda < t3) || (timeda > t4)) ||
                        ((timefj < t3) || (timefj > t4))
                        )
                    {
                        MessageBox.Show(" L'heure du début de journée doit être entre 08:00 et 12:00" +
                            "\n L'heure fin de matinée doit être comprise entre 08:00 et 12:00" +
                            "\n L'heure de début d'après midi doit être comprise entre  13:00 et 18:00" +
                            "\n L'heure de fin de journée doit être comprise entre 13:00 et 18:00");
                        if ((timed < t1) || (timed > t2)) textBoxHdebut.Text = "";
                        if ((timefm < t1) || (timefm > t2)) textBoxhFinM.Text = "";
                        if ((timeda < t3) || (timeda > t4)) textBoxHdebutA.Text = "";
                        if ((timefj < t3) || (timefj > t4)) textBoxhFinJ.Text = "";
                    }
                    else 
                    {
                        if ((timed > MatinéePremier)&&(MatinéePremier!=t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La première de consultationest à : " + MatinéePremier.ToString());

                        else if (timefm < MatinéeDernier) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La dernière heure de consultationest pour le matin est à : " + MatinéeDernier.ToString());

                        else if ((timeda > ApresPremier)&& (MatinéePremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La première de consultation de l'après-midi est à : " + ApresPremier.ToString());

                        else if ((timefj > ApresDernier)&& (MatinéePremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La dernière heure de consultation est pour l'après-midi est à : " + ApresDernier.ToString());
                        else
                        try
                        {
                            BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                            List<dynamic> listPlanning = new List<dynamic>();
                            dynamic planning = new ExpandoObject();
                            planning.PlanningId = this.Id.ToString() ;
                            planning.Heured = textBoxHdebut.Text.ToString();
                            planning.Heurefm = textBoxhFinM.Text.ToString();
                            planning.Heureda = textBoxHdebutA.Text.ToString();
                            planning.Heurefa = textBoxhFinJ.Text.ToString();
                            listPlanning.Add(planning);
                            string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                            blMedecin.UpdatePlanningMedecin(Json);
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

        private async void button2_Click(object sender, EventArgs e)
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

            var response2 = await client.GetAsync(new Uri("https://localhost:44399/Medecin/Medecin/ConsultationApresMidiPremier/" + id));
            if (response2.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic list2 = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                foreach (var item in list2)
                {
                    ApresPremier = item.DebutConsulation.Value;
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }

            var response3 = await client.GetAsync(new Uri("https://localhost:44399/Medecin/Medecin/Medecin/ConsultationApresMidiDernier/" + id));
            if (response3.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic list3 = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                foreach (var item in list3)
                {
                    ApresDernier = item.FinConsultation.Value;
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }


            if ((textBoxHdebut.Text == "") || (textBoxhFinM.Text == "") || (textBoxHdebutA.Text == "") || (textBoxhFinJ.Text == ""))
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan timed, timefm, timeda, timefj;
                if ((!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) || (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm))
                    || (!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) || (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)))
                {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHdebut.Text, out timed)) textBoxHdebut.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinM.Text, out timefm)) textBoxhFinM.Text = "";
                    if (!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) textBoxHdebutA.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)) textBoxhFinJ.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires

                    TimeSpan t1 = TimeSpan.Parse("08:00");
                    TimeSpan t2 = TimeSpan.Parse("12:00");
                    TimeSpan t3 = TimeSpan.Parse("13:00");
                    TimeSpan t4 = TimeSpan.Parse("18:00");
                    TimeSpan t0 = TimeSpan.Parse("00:00");

                    if (
                        ((timed < t1) || (timed > t2)) ||
                        ((timefm < t1) || (timefm > t2)) ||
                        ((timeda < t3) || (timeda > t4)) ||
                        ((timefj < t3) || (timefj > t4))
                        )
                    {
                        MessageBox.Show(" L'heure du début de journée doit être entre 08:00 et 12:00" +
                            "\n L'heure fin de matinée doit être comprise entre 08:00 et 12:00" +
                            "\n L'heure de début d'après midi doit être comprise entre  13:00 et 18:00" +
                            "\n L'heure de fin de journée doit être comprise entre 13:00 et 18:00");
                        if ((timed < t1) || (timed > t2)) textBoxHdebut.Text = "";
                        if ((timefm < t1) || (timefm > t2)) textBoxhFinM.Text = "";
                        if ((timeda < t3) || (timeda > t4)) textBoxHdebutA.Text = "";
                        if ((timefj < t3) || (timefj > t4)) textBoxhFinJ.Text = "";
                    }
                    else
                    {
                        if ((timed > MatinéePremier)&&(MatinéePremier!=t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La première de consultationest à : " + MatinéePremier.ToString());

                        else if ((timefm < MatinéeDernier)&& (MatinéePremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La dernière heure de consultationest pour le matin est à : " + MatinéeDernier.ToString());

                        else if ((timeda > ApresPremier)&& (ApresPremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La première de consultation de l'après-midi est à : " + ApresPremier.ToString());

                        else if ((timefj > ApresDernier)&& (ApresDernier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La dernière heure de consultation est pour l'après-midi est à : " + ApresDernier.ToString());
                        else
                            try
                            {
                                var httpClient = new HttpClient();
                                List<dynamic> listPlanning = new List<dynamic>();
                                dynamic planning = new ExpandoObject();
                                planning.PlanningId = this.Id.ToString();
                                planning.Heured = textBoxHdebut.Text.ToString();
                                planning.Heurefm = textBoxhFinM.Text.ToString();
                                planning.Heureda = textBoxHdebutA.Text.ToString();
                                planning.Heurefa = textBoxhFinJ.Text.ToString();
                                listPlanning.Add(planning);
                                var serialized = JsonConvert.SerializeObject(listPlanning);
                                var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                                var response5 = await httpClient.PostAsync("https://localhost:44399/Medecin/UpdateAllPlanning/", content1);
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
