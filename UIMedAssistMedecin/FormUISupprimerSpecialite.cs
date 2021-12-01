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
    public partial class FormUISupprimerSpecialite : Form
    {
        private int idMe;
        private int idM;
        private int idS;
        public FormUISupprimerSpecialite(int Id)
        {
            InitializeComponent();
            this.idMe = Id;
            dynamiccheck(Id);
        }

        private void dynamiccheck(int Id)
        {

            try
            {
                BLMedecin.blMedecin blmedecin = new BLMedecin.blMedecin();
                string Json = blmedecin.SelectSpecialiteMedecin(Id);
                List<Models.Models.ModelSpecialiteMedecin> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSpecialiteMedecin>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.NomSpecialite.ToString();
                    radio.Name = item.IDSPecialite.ToString();
                    radio.Width = 200;
                    radio.CheckedChanged += new EventHandler(changecheck);
                    flowLayoutPanelSpecialite.Controls.Add(radio);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void changecheck(object sender, EventArgs e)
        {
            flowLayoutPanelMAisonMedicale.Controls.Clear();
            RadioButton radioButton = sender as RadioButton;
            this.idS = int.Parse(radioButton.Name);
            try
            {
                BLMedecin.blMedecin blmedecin = new BLMedecin.blMedecin();
                string Json = blmedecin.SelectMaisonSpecMedecinEdition(idMe, idS);
                List<Models.Models.ModelSelectMaisonMedecin> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectMaisonMedecin>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio1 = new RadioButton();
                    radio1.Text = item.Nom.ToString();
                    radio1.Name = item.IDMaisonM.ToString();
                    radio1.Width = 200;
                    radio1.CheckedChanged += new EventHandler(changeIdMaison);
                    flowLayoutPanelMAisonMedicale.Controls.Add(radio1);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void changeIdMaison(object sender, EventArgs e)
        {
            RadioButton radioButton1 = sender as RadioButton;
            this.idM = int.Parse(radioButton1.Name);
        }

        private async void btValider_Click(object sender, EventArgs e)
        {
            int cpt = 0;
            string id = idMe.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/MedecinConsultation/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                foreach (var item in convert)
                {
                    if (item.IDSPecialite == idS) cpt++;
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
            if (cpt > 0) MessageBox.Show("Cette spécialité est déjà programmées pour une consulatation");
            else 
            {
                BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                List<dynamic> listPlanning = new List<dynamic>();
                dynamic spec = new ExpandoObject();
                spec.idMedecin = this.idMe.ToString();
                spec.iDMaison = this.idM.ToString();
                spec.idSpecialite = this.idS.ToString();
                listPlanning.Add(spec);
                string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                blMedecin.DeleteSpecialite(Json);
                MessageBox.Show("La spécialité a bien été enlevée", "Succès");
                this.Close();
            }
        }

        private async void btDeleteAPI_Click(object sender, EventArgs e)
        {
            int cpt = 0;
            string id = idMe.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/MedecinConsultation/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                foreach (var item in convert)
                {
                    if (item.IDSPecialite == idS) cpt++;
                }
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
            if (cpt > 0) MessageBox.Show("Cette spécialité est déjà programmées pour une consulatation");
            else
            {
                var httpClient = new HttpClient();
                List<dynamic> listPlanning = new List<dynamic>();
                dynamic spec = new ExpandoObject();
                spec.idMedecin = this.idMe.ToString();
                spec.iDMaison = this.idM.ToString();
                spec.idSpecialite = this.idS.ToString();
                listPlanning.Add(spec);
                var serialized = JsonConvert.SerializeObject(listPlanning);
                var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                var response1 = await httpClient.PostAsync("https://localhost:44399/Medecin/DeleteSpecialite/", content1);
                var code = (int)response1.StatusCode;
                if ((response1.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("La spécialité a bien été supprimée via l'API");
                else
                {
                    string contentError = response1.Content.ReadAsStringAsync().Result;
                }
                this.Close();
            }
        }
        
    }
}
