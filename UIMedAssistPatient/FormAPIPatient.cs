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

namespace UIMedAssistPatient
{
    public partial class FormAPIPatient : Form
    {
        private int Id;
        public FormAPIPatient(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string id = Id.ToString();
            HttpClient client = new HttpClient();
            var response =await client.GetAsync(new Uri("https://localhost:44399/Patient/"+id));
            if(response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                dynamic convert = JsonConvert.DeserializeObject<dynamic>(content) as dynamic;
                dataGridView1.DataSource = convert;
            }
            else
            {
                string content = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
    
}
