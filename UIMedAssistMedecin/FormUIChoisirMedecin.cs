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
    public partial class FormUIChoisirMedecin : Form
    {
        public FormUIChoisirMedecin()
        {
            InitializeComponent();
        }

        private void btRechercheMedecinID_Click(object sender, EventArgs e)
        {
            if (textBoxIDMedecin.Text == "") MessageBox.Show("");
            else 
            {
                int Id;
                if (!int.TryParse(textBoxIDMedecin.Text, out Id))
                {
                    MessageBox.Show("");
                    textBoxIDMedecin.Text = "";
                }
                else
                {
                    Id = int.Parse(textBoxIDMedecin.Text);
                    var _myForm = (FormUIPlanningMedecin)Application.OpenForms["FormUIPlanningMedecin"];
                    if (_myForm == null)
                    {
                        FormUIPlanningMedecin formUIPlanningMedecin = new FormUIPlanningMedecin(Id);
                        formUIPlanningMedecin.MdiParent = this.MdiParent;
                        formUIPlanningMedecin.Show();
                    }
                    else
                    {
                        MessageBox.Show("");
                    }
                }
            }
        }
    }
}
