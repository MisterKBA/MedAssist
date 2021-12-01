using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMedAssistPatient
{
    public partial class FormUIPatientRecherche : Form
    {
        private int idP;
        public FormUIPatientRecherche()
        {
            InitializeComponent();
        }
        private void ChildFormClosing(object sender, FormClosedEventArgs e)
        {
            BLPatient.blPatient blPatient = new BLPatient.blPatient();
            string Json1 = blPatient.SelectPatientRDV(idP);
            List<Models.Models.ModelSelectPatientRDV> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json1);
            dataGridViewPlanningPatient.DataSource = list1;
            dataGridViewPlanningPatient.Columns[0].Visible = false;
            dataGridViewPlanningPatient.Columns[3].Visible = false;
            dataGridViewPlanningPatient.Columns[4].Visible = false;
            dataGridViewPlanningPatient.Columns[5].Visible = false;
        }
        private void btPrendreRDV_Click(object sender, EventArgs e)
        {
            if (textBoxIdPatient.Text == "") MessageBox.Show("Il faut un Id de patient");
            else
            {
                int Id;
                if (!int.TryParse(textBoxIdPatient.Text, out Id))
                {
                    MessageBox.Show("L'Id de patient doit être un nombre");
                    textBoxIdPatient.Text = "";
                }
                else
                {
                    this.idP = Id;
                    FormUIPrendreRDVOption formPrendreRDVOption = new FormUIPrendreRDVOption(idP);
                    formPrendreRDVOption.MdiParent = this.MdiParent;
                    formPrendreRDVOption.FormClosed += new FormClosedEventHandler(ChildFormClosing);
                    formPrendreRDVOption.Show();
                }
            }
        }
        private void btEditerRdv_Click(object sender, EventArgs e)
        {
            if (textBoxIdPatient.Text == "") MessageBox.Show("Il faut un Id de patient");
            else
            {
                int Id;
                if (!int.TryParse(textBoxIdPatient.Text, out Id))
                {
                    MessageBox.Show("L'Id de patient doit être un nombre");
                    textBoxIdPatient.Text = "";
                }
                else
                {
                    FormUIEditerRDV formUIEditerRDV = new FormUIEditerRDV(Id);
                    formUIEditerRDV.MdiParent = this.MdiParent;
                    formUIEditerRDV.FormClosed += new FormClosedEventHandler(ChildFormClosing);
                    formUIEditerRDV.Show();
                }
            }               
        }
        private void btSupprimerRDV_Click(object sender, EventArgs e)
        {
            if (textBoxIdPatient.Text == "") MessageBox.Show("Il faut un Id de patient");
            else
            {
                int Id;
                if (!int.TryParse(textBoxIdPatient.Text, out Id))
                {
                    MessageBox.Show("L'Id de patient doit être un nombre");
                    textBoxIdPatient.Text = "";
                }
                else
                {
                    FormUISupprimerRDV formUISupprimerRDV = new FormUISupprimerRDV(Id);
                    formUISupprimerRDV.MdiParent = this.MdiParent;
                    formUISupprimerRDV.FormClosed += new FormClosedEventHandler(ChildFormClosing);
                    formUISupprimerRDV.Show();
                }
            }
                
        }
        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (textBoxIdPatient.Text == "") MessageBox.Show("Il faut un Id de patient");
            else
            {
                int Id;
                if (!int.TryParse(textBoxIdPatient.Text, out Id))
                {
                    MessageBox.Show("L'Id de patient doit être un nombre");
                    textBoxIdPatient.Text = "";
                }
                else
                {
                    Id = int.Parse(textBoxIdPatient.Text);
                    this.idP = Id;
                    BLPatient.blPatient blPatient = new BLPatient.blPatient();
                    string Json = blPatient.SelectPatientById(Id);
                    List<Models.Models.ModelSelectPatient> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatient>>(Json);

                    foreach (var item in list)
                    {
                        labelNom.Text = item.Nom.ToString();
                        labelPrenom.Text = item.Prenom.ToString();
                        labelDatedeNaissance.Text = item.DateDeNaissance.ToString();
                        labelIdPatient.Text = item.IDPatient.ToString();
                    }
                    
                    string Json1 = blPatient.SelectPatientRDV(Id);
                    List<Models.Models.ModelSelectPatientRDV> list1 = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPatientRDV>>(Json1);
                    dataGridViewPlanningPatient.DataSource = list1;
                    dataGridViewPlanningPatient.Columns[0].Visible = false; 
                    dataGridViewPlanningPatient.Columns[3].Visible = false;
                    dataGridViewPlanningPatient.Columns[4].Visible = false;
                    dataGridViewPlanningPatient.Columns[5].Visible = false;
                }
            }
        }

        private void btGoToApi_Click(object sender, EventArgs e)
        {
            FormAPIPatient formAPI = new FormAPIPatient(idP);
            formAPI.MdiParent = this.MdiParent;
            formAPI.Show();
        }
    }  
}

