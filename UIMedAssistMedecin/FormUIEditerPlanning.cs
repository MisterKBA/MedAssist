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

namespace UIMedAssistMedecin
{
    public partial class FormUIEditerPlanning : Form
    {
        public FormUIEditerPlanning(int Id)
        {
            InitializeComponent();
            OnloadDataPlanning(Id);
        }
        private void OnloadDataPlanning(int Id)
        {
            try
            {
                BLMedecin.blMedecin bLMedecin = new BLMedecin.blMedecin();
                string Json = bLMedecin.SelectPlanningMedecinById(Id);
                List<Models.Models.ModelSelectPlanningMed> list = JsonConvert.DeserializeObject<List<Models.Models.ModelSelectPlanningMed>>(Json);
                dataGridViewEditerPlanning.DataSource = list;
                dataGridViewEditerPlanning.Columns[6].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string x = dataGridViewEditerPlanning.Rows[e.RowIndex].Cells[6].Value.ToString();
            int Id = int.Parse(x);
            FormUIChoixEdition formUIChoixEdition = new FormUIChoixEdition(Id);
            formUIChoixEdition.MdiParent = this.MdiParent;
            formUIChoixEdition.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            formUIChoixEdition.Show();
            
        }
        private void ChildFormClosing(object sender, FormClosedEventArgs e) 
        {
            this.Close();
        }
    }
}
