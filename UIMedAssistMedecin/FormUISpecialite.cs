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
    public partial class FormUISpecialite : Form
    {
        int Id;
        public FormUISpecialite(int Id)
        {
            this.Id = Id;
            InitializeComponent();
            OnloadDataMedecin(Id);
            OnLoadDataApi(Id);
        }
        private void OnloadDataMedecin(int Id)
        {
            try
            {
                BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
                string Json = bLMedecin.SelectSpecialiteMedecin(Id);
                List<Models.Models.ModelSpecialiteMedecin> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSpecialiteMedecin>>(Json);
                foreach (var item in list)
                {
                    labelNomMedecin.Text = item.Nom.ToString();
                    labelIdMedecin.Text = item.IDMedecin.ToString();
                }
                dataGridViewSpecialite.DataSource = list;       
            }
            catch (Exception)
            {

                throw;
            }

        }
        private async void OnLoadDataApi(int Id)
        {
            string id = Id.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/Specialite/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                dataGridViewAPI.DataSource = convert;
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
        }
        private void ajouterSpécialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormUIAjoutSpecialite formUIAjoutSpecialite = new FormUIAjoutSpecialite(Id);
                formUIAjoutSpecialite.FormClosed += new FormClosedEventHandler(ChildFormClosing);
                formUIAjoutSpecialite.MdiParent = this.MdiParent;
                formUIAjoutSpecialite.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ChildFormClosing(object sender, FormClosedEventArgs e)
        {
            OnloadDataMedecin(Id);
            OnLoadDataApi(Id);
        }
        private void editerDuréeSpécialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUIEditerSpecialite formUIEditerSpecialite = new FormUIEditerSpecialite(Id);
            formUIEditerSpecialite.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIEditerSpecialite.MdiParent = this.MdiParent;
            formUIEditerSpecialite.Show();
        }
        private void supprimerSpécialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUISupprimerSpecialite formUISupprimerSpecialite = new FormUISupprimerSpecialite(Id);
            formUISupprimerSpecialite.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUISupprimerSpecialite.MdiParent = this.MdiParent;
            formUISupprimerSpecialite.Show();
        }
    }
}
