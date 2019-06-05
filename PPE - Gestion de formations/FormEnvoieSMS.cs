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
    public partial class FormEnvoieSMS : Form
    {
       
        public FormEnvoieSMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMS.Send(rtb_sms.Text);
            MessageBox.Show("Le SMS a été envoyé !");
            this.DialogResult = DialogResult.OK;
        }
    }
}
