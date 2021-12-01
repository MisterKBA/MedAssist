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
    public partial class FormUIComfirmationRDV : Form
    {
        private int idMedecin;
        private int idRDV;
        public FormUIComfirmationRDV(int Id)
        {
            InitializeComponent();
            idMedecin = Id;
            loadData(Id);
        }
        private async void loadData(int Id) 
        {
            string id = Id.ToString();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://localhost:44399/Medecin/MedecinConfirmation/" + id));
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                dataGridViewConfirmation.DataSource = convert;
                /*dataGridViewRDVAPI.Columns[0].Visible = false;
                dataGridViewRDVAPI.Columns[2].Visible = false;
                dataGridViewRDVAPI.Columns[5].Visible = false;
                dataGridViewRDVAPI.Columns[8].Visible = false;
                dataGridViewRDVAPI.Columns[10].Visible = false;*/
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
        }

        private async void btConfirmer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confimer le rendez-vous", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                int conf = 1;
                try
                {
                    var httpClient = new HttpClient();
                    List<dynamic> listConfirmation = new List<dynamic>();
                    dynamic Confirme = new ExpandoObject();
                    Confirme.idRDV = this.idRDV.ToString();
                    Confirme.idMedecin = this.idMedecin.ToString();
                    Confirme.Confirmation = conf.ToString();
                    listConfirmation.Add(Confirme);
                    var serialized = JsonConvert.SerializeObject(listConfirmation);
                    var content1 = new StringContent(serialized, Encoding.UTF8, "application/json");
                    var response5 = await httpClient.PostAsync("https://localhost:44399/Medecin/UpdateConfirmation/", content1);
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
        private void dataGridViewConfirmation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string x = dataGridViewConfirmation.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.idRDV = int.Parse(x);
        }
    }
}
