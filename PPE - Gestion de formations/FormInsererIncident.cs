using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE___Gestion_de_formations
{
    public partial class FormInsererIncident : Form
    {
        public FormInsererIncident()
        {
            InitializeComponent();
        }

        private void btn_saisir_incident_Click(object sender, EventArgs e)
        {
            IncidentManager incidentManager = new IncidentManager();
            string lib = tb_lib_incident.Text;
            string message = rtb_message_incident.Text;
            incidentManager.insertIncident(lib, message);
            this.DialogResult = DialogResult.OK;

        }
    }
}
