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
    public partial class FormUIEditerApresMidi : Form
    {
        private int Id;
        private TimeSpan ApresPremier;
        private TimeSpan ApresDernier;
        public FormUIEditerApresMidi(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLMedecin.blMedecin bLMedecin1 = new BLMedecin.blMedecin();
            string JsonApresMidiPremier = bLMedecin1.SelectConsultationApresMidiPremier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listApresMidiPremier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonApresMidiPremier);
            string JsonApresMidiDernier = bLMedecin1.SelectConsultationApresMidiDernier(Id);
            List<Models.Models.ModelSelectConsultationMedecinById> listApresMidiDernier = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectConsultationMedecinById>>(JsonApresMidiDernier);


            foreach (var item in listApresMidiPremier)
            {
                ApresPremier = item.DebutConsulation.Value;
            }
            foreach (var item in listApresMidiDernier)
            {
                ApresDernier = item.FinConsultation.Value;
            }

            if  ((textBoxHdebutA.Text == "") || (textBoxhFinJ.Text == ""))
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan  timeda, timefj;
                if ((!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) || (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)))
                {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) textBoxHdebutA.Text = "";
                    if (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)) textBoxhFinJ.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires
                    TimeSpan t3 = TimeSpan.Parse("13:00");
                    TimeSpan t4 = TimeSpan.Parse("18:00");

                    if (
                        ((timeda < t3) || (timeda > t4)) ||
                        ((timefj < t3) || (timefj > t4))
                        )
                    {
                        MessageBox.Show("\n L'heure de début d'après midi doit être comprise entre  13:00 et 18:00" +
                            "\n L'heure de fin de journée doit être comprise entre 13:00 et 18:00");
                        if ((timeda < t3) || (timeda > t4)) textBoxHdebutA.Text = "";
                        if ((timefj < t3) || (timefj > t4)) textBoxhFinJ.Text = "";
                    }
                    else
                    {
                        if (timeda > ApresPremier) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La première de consultation de l'après-midi est à : " + ApresPremier.ToString());

                        else if (timefj > ApresDernier) MessageBox.Show("Il y a déjà une consultation programmée" +
                            "\n La dernière heure de consultation est pour l'après-midi est à : " + ApresDernier.ToString());
                        else
                        try
                        {
                            BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                            List<dynamic> listPlanning = new List<dynamic>();
                            dynamic planning = new ExpandoObject();
                            planning.PlanningId = this.Id.ToString();
                            planning.Heureda = textBoxHdebutA.Text.ToString();
                            planning.Heurefa = textBoxhFinJ.Text.ToString();
                            listPlanning.Add(planning);
                            string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                            blMedecin.UpdatePlanningMedecinApres(Json);
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

            {
                string id = Id.ToString();
                HttpClient client = new HttpClient();


                var response2 = await client.GetAsync(new Uri("https://localhost:44399/Medecin/Medecin/ConsultationApresMidiPremier/" + id));
                if (response2.IsSuccessStatusCode)
                {
                    string content = response2.Content.ReadAsStringAsync().Result;
                    dynamic list2 = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                    foreach (var item in list2)
                    {
                        ApresPremier = item.DebutConsulation.Value;
                    }
                }
                else
                {
                    string content = response2.Content.ReadAsStringAsync().Result;
                }

                var response3 = await client.GetAsync(new Uri("https://localhost:44399/Medecin/Medecin/Medecin/ConsultationApresMidiDernier/" + id));
                if (response3.IsSuccessStatusCode)
                {
                    string content = response3.Content.ReadAsStringAsync().Result;
                    dynamic list3 = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                    foreach (var item in list3)
                    {
                        ApresDernier = item.FinConsultation.Value;
                    }
                }
                else
                {
                    string content = response3.Content.ReadAsStringAsync().Result;
                }


                if ((textBoxHdebutA.Text == "") || (textBoxhFinJ.Text == ""))
                    MessageBox.Show("Les champs ne peuvent être vide");
                else
                {
                    //Test si les heures sont valides
                    TimeSpan  timeda, timefj;
                    if ((!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) || (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)))
                    {
                        MessageBox.Show("Le format de l'heure doit être un format valide");
                        if (!TimeSpan.TryParse(textBoxHdebutA.Text, out timeda)) textBoxHdebutA.Text = "";
                        if (!TimeSpan.TryParse(textBoxhFinJ.Text, out timefj)) textBoxhFinJ.Text = "";
                    }
                    else
                    {
                        //Test si l'heure est contenue dans les tranches horaires                    
                        TimeSpan t3 = TimeSpan.Parse("13:00");
                        TimeSpan t4 = TimeSpan.Parse("18:00");
                        TimeSpan t0 = TimeSpan.Parse("00:00");

                        if (
                            ((timeda < t3) || (timeda > t4)) ||
                            ((timefj < t3) || (timefj > t4))
                            )
                        {
                            MessageBox.Show("L'heure de début d'après midi doit être comprise entre  13:00 et 18:00" +
                                "\n L'heure de fin de journée doit être comprise entre 13:00 et 18:00");
                            if ((timeda < t3) || (timeda > t4)) textBoxHdebutA.Text = "";
                            if ((timefj < t3) || (timefj > t4)) textBoxhFinJ.Text = "";
                        }
                        else
                        {
                            if ((timeda > ApresPremier) && (ApresPremier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                                 "\n La première de consultation de l'après-midi est à : " + ApresPremier.ToString());

                            else if ((timefj > ApresDernier) && (ApresDernier != t0)) MessageBox.Show("Il y a déjà une consultation programmée" +
                                 "\n La dernière heure de consultation est pour l'après-midi est à : " + ApresDernier.ToString());
                            else
                                try
                                {
                                    var httpClient = new HttpClient();
                                    List<dynamic> listPlanning = new List<dynamic>();
                                    dynamic planning = new ExpandoObject();
                                    planning.PlanningId = this.Id.ToString();
                                    planning.Heureda = textBoxHdebutA.Text.ToString();
                                    planning.Heurefa = textBoxhFinJ.Text.ToString();
                                    listPlanning.Add(planning);
                                    var serialized = JsonConvert.SerializeObject(listPlanning);
                                    var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                                    var response5 = await httpClient.PostAsync("https://localhost:44399/Medecin/UpdatePlanningApresMidi/", content1);
                                    var code = (int)response5.StatusCode;
                                    if ((response5.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le jour a bien été édité via l'api", "Succès");
                                    else
                                    {
                                        string contentError = response5.Content.ReadAsStringAsync().Result;
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
}
