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
    public partial class FormUIMedecin : Form
    {
        public FormUIMedecin()
        {
            InitializeComponent();
            FormUIChoisirMedecin formUIChoisirMedecin = new FormUIChoisirMedecin();
            formUIChoisirMedecin.MdiParent = this;
            formUIChoisirMedecin.Show();
        }
    }
}
