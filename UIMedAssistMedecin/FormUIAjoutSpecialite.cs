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
    public partial class FormUIAjoutSpecialite : Form
    {
        private int idM;
        private int idS;
        private int idMe;
        public FormUIAjoutSpecialite(int Id)
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
                string Json = blmedecin.SelectAllSpecialite(Id);
                List<Models.Models.ModelSelectAllSpecialite> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectAllSpecialite>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = item.Nom.ToString();
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
            flowLayoutPanelMaisonMedicale.Controls.Clear();
            RadioButton radioButton = sender as RadioButton;           
            
            this.idS = int.Parse(radioButton.Name);
            try
            {
                BLMedecin.blMedecin blmedecin = new BLMedecin.blMedecin();
                string Json = blmedecin.SelectMaisonSpecMedecin(idMe,idS);
                List<Models.Models.ModelSelectMaisonMedecin> list =
                    JsonConvert.DeserializeObject<List<Models.Models.ModelSelectMaisonMedecin>>(Json);
                foreach (var item in list)
                {
                    RadioButton radio1 = new RadioButton();
                    radio1.Text = item.Nom.ToString();
                    radio1.Name = item.IDMaisonM.ToString();
                    radio1.Width = 200;
                    radio1.CheckedChanged += new EventHandler(changeIdMaison);
                    flowLayoutPanelMaisonMedicale.Controls.Add(radio1);
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

        private void btValiderAjout_Click(object sender, EventArgs e)
        {
            int rDurée = -1;
            if (textBoxDuree.Text == "") MessageBox.Show("Il faut une durée de consultation");
            else
            {
                if (!int.TryParse(textBoxDuree.Text, out rDurée))
                {
                    MessageBox.Show("La durée doit correspondre a un nombre");
                    textBoxDuree.Text = "";
                }
                else
                {
                    BLMedecin.blMedecin blMedecin = new BLMedecin.blMedecin();
                    List<dynamic> listPlanning = new List<dynamic>();
                    dynamic spec = new ExpandoObject();
                    spec.idMedecin = this.idMe.ToString();
                    spec.iDMaison = this.idM.ToString();
                    spec.idSpecialite = this.idS.ToString();
                    spec.duree = rDurée.ToString();

                    listPlanning.Add(spec);
                    string Json = JsonConvert.SerializeObject(listPlanning, Formatting.Indented);
                    blMedecin.AddSpecialite(Json);
                    MessageBox.Show("Le jour a bien été ajouté", "Succès");
                    this.Close();
                }
            }
        }

        private async void btSaveAPI_Click(object sender, EventArgs e)
        {
            int rDurée = -1;
            if (textBoxDuree.Text == "") MessageBox.Show("Il faut une durée de consultation");
            else
            {
                if (!int.TryParse(textBoxDuree.Text, out rDurée))
                {
                    MessageBox.Show("La durée doit correspondre a un nombre");
                    textBoxDuree.Text = "";
                }
                else
                {
                    var httpClient = new HttpClient();
                    List<dynamic> listPlanning = new List<dynamic>();
                    dynamic spec = new ExpandoObject();
                    spec.idMedecin = this.idMe.ToString();
                    spec.iDMaison = this.idM.ToString();
                    spec.idSpecialite = this.idS.ToString();
                    spec.duree = rDurée.ToString();
                    listPlanning.Add(spec);
                    var serialized = JsonConvert.SerializeObject(listPlanning);
                    var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                    var response5 = await httpClient.PostAsync("https://localhost:44399/Medecin/AddSpecialite", content1);
                    var code = (int)response5.StatusCode;
                    if ((response5.IsSuccessStatusCode) || (code == 204)) MessageBox.Show("Le jour a bien été édité via l'api", "Succès");
                    else
                    {
                        string contentError = response5.Content.ReadAsStringAsync().Result;
                    }
                    this.Close();
                }
            }
        }
    }
   
}
