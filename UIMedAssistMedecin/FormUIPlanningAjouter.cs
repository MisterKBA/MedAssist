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
    public partial class FormUIPlanningAjouter : Form
    {
        private int Id;
        private int IdM;
        public FormUIPlanningAjouter(int Id)
        {
            this.IdM = -1;
            this.Id = Id;
            InitializeComponent();
            dynamiccheck(Id);
            dateTimePicker1.MinDate = DateTime.Now;
        }
        private void dynamiccheck(int Id)
        {

            try
            {
                BLMedecin.blMedecin blmedecin = new BLMedecin.blMedecin();
                string Json = blmedecin.SelectMaisonMedecinById(Id);
                List<Models.Models.ModelSelectMaisonMedecin> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectMaisonMedecin>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.Nom.ToString();
                    radio.Name = item.IDMaisonM.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changecheck);
                    flowLayoutPanel1.Controls.Add(radio);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void changecheck(object sender, EventArgs e)
        {
            RadioButton radioButton= sender as RadioButton;
            this.IdM = int.Parse(radioButton.Name);
            MessageBox.Show(radioButton.Text+" "+this.IdM.ToString());
        }
        private void btValiderAjoutPlanning_Click(object sender, EventArgs e)
        {
            //Test les champs vide
            if ((textBoxHDebut.Text == "") || (textBoxHFinMatin.Text == "") || (textBoxHDebutAprem.Text == "") || (textBoxHFinJournee.Text == ""))     
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan timed, timefm, timeda, timefj;
                if ((!TimeSpan.TryParse(textBoxHDebut.Text, out timed)) || (!TimeSpan.TryParse(textBoxHFinMatin.Text, out timefm))
                    || (!TimeSpan.TryParse(textBoxHDebutAprem.Text, out timeda)) || (!TimeSpan.TryParse(textBoxHFinJournee.Text, out timefj)))
                {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHDebut.Text, out timed)) textBoxHDebut.Text = "";
                    if (!TimeSpan.TryParse(textBoxHFinMatin.Text, out timefm)) textBoxHFinMatin.Text = "";
                    if (!TimeSpan.TryParse(textBoxHDebutAprem.Text, out timeda)) textBoxHDebutAprem.Text = "";
                    if (!TimeSpan.TryParse(textBoxHFinJournee.Text, out timefj)) textBoxHFinJournee.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires

                    TimeSpan t1 =TimeSpan.Parse("08:00");
                    TimeSpan t2 = TimeSpan.Parse("12:00");
                    TimeSpan t3 = TimeSpan.Parse("13:00");
                    TimeSpan t4 = TimeSpan.Parse("18:00");

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
                        if ((timed < t1) || (timed > t2)) textBoxHDebut.Text = "";
                        if ((timefm < t1) || (timefm > t2)) textBoxHFinMatin.Text = "";
                        if ((timeda < t3) || (timeda > t4)) textBoxHDebutAprem.Text = "";
                        if ((timefj < t3) || (timefj > t4)) textBoxHFinJournee.Text = "";
                    }
                    else
                    {
                        //Test si un radioButton est bien sélectionné
                        if (this.IdM == -1) MessageBox.Show("Il faut sélectionner une maison médicale");
                        else
                        {
                            //Tester si la date à été modifiée
                            if ((dateTimePicker1.Value <= DateTime.Now)) MessageBox.Show("La date doit être suppérieure à celle d'aujourd'hui");
                            else
                            {
                                try
                                {
                                     BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                                     List<dynamic> listPlanning = new List<dynamic>();
                                     dynamic planning = new ExpandoObject();
                                     planning.JourDePressence = dateTimePicker1.Value.ToString();
                                     planning.Heured = textBoxHDebut.Text.ToString();
                                     planning.Heurefm = textBoxHFinMatin.Text.ToString();
                                     planning.Heureda = textBoxHDebutAprem.Text.ToString();
                                     planning.Heurefa = textBoxHFinJournee.Text.ToString();
                                     planning.IDMedecin = this.Id.ToString();
                                     planning.IDMaisonM = this.IdM.ToString();
                                     listPlanning.Add(planning);
                                     string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                                     blMedecin.AddPlanningMedecin(Json);
                                    MessageBox.Show("Le jour a bien été ajouté","Succès");
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

        private async void btSaveAPI_Click(object sender, EventArgs e)
        {
            //Test les champs vide
            if ((textBoxHDebut.Text == "") || (textBoxHFinMatin.Text == "") || (textBoxHDebutAprem.Text == "") || (textBoxHFinJournee.Text == ""))
                MessageBox.Show("Les champs ne peuvent être vide");
            else
            {
                //Test si les heures sont valides
                TimeSpan timed, timefm, timeda, timefj;
                if ((!TimeSpan.TryParse(textBoxHDebut.Text, out timed)) || (!TimeSpan.TryParse(textBoxHFinMatin.Text, out timefm))
                    || (!TimeSpan.TryParse(textBoxHDebutAprem.Text, out timeda)) || (!TimeSpan.TryParse(textBoxHFinJournee.Text, out timefj)))
                {
                    MessageBox.Show("Le format de l'heure doit être un format valide");
                    if (!TimeSpan.TryParse(textBoxHDebut.Text, out timed)) textBoxHDebut.Text = "";
                    if (!TimeSpan.TryParse(textBoxHFinMatin.Text, out timefm)) textBoxHFinMatin.Text = "";
                    if (!TimeSpan.TryParse(textBoxHDebutAprem.Text, out timeda)) textBoxHDebutAprem.Text = "";
                    if (!TimeSpan.TryParse(textBoxHFinJournee.Text, out timefj)) textBoxHFinJournee.Text = "";
                }
                else
                {
                    //Test si l'heure est contenue dans les tranches horaires

                    TimeSpan t1 = TimeSpan.Parse("08:00");
                    TimeSpan t2 = TimeSpan.Parse("12:00");
                    TimeSpan t3 = TimeSpan.Parse("13:00");
                    TimeSpan t4 = TimeSpan.Parse("18:00");

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
                        if ((timed < t1) || (timed > t2)) textBoxHDebut.Text = "";
                        if ((timefm < t1) || (timefm > t2)) textBoxHFinMatin.Text = "";
                        if ((timeda < t3) || (timeda > t4)) textBoxHDebutAprem.Text = "";
                        if ((timefj < t3) || (timefj > t4)) textBoxHFinJournee.Text = "";
                    }
                    else
                    {
                        //Test si un radioButton est bien sélectionné
                        if (this.IdM == -1) MessageBox.Show("Il faut sélectionner une maison médicale");
                        else
                        {
                            //Tester si la date à été modifiée
                            if ((dateTimePicker1.Value <= DateTime.Now)) MessageBox.Show("La date doit être suppérieure à celle d'aujourd'hui");
                            else
                            {
                                try
                                {
                                    var httpClient = new HttpClient();
                                    BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                                    List<dynamic> listPlanning = new List<dynamic>();
                                    dynamic planning = new ExpandoObject();
                                    planning.JourDePressence = dateTimePicker1.Value.ToString();
                                    planning.Heured = textBoxHDebut.Text.ToString();
                                    planning.Heurefm = textBoxHFinMatin.Text.ToString();
                                    planning.Heureda = textBoxHDebutAprem.Text.ToString();
                                    planning.Heurefa = textBoxHFinJournee.Text.ToString();
                                    planning.IDMedecin = this.Id.ToString();
                                    planning.IDMaisonM = this.IdM.ToString();
                                    listPlanning.Add(planning);
                                    var serialized = JsonConvert.SerializeObject(listPlanning);
                                    var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                                    var response1 = await httpClient.PostAsync("https://localhost:44399/Medecin/AddPlanning/",content1);
                                    var code = (int)response1.StatusCode;
                                    if ((response1.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le jour a bien été ajouté,Succès");
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
    }
    
}
