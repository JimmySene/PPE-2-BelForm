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
    public partial class PromptForm : Form
    {
        
        public PromptForm(string nom, string lbl)
        {
            InitializeComponent();
            this.Text = nom;
            lbl_prompt.Text = lbl; 
        }

        private void PromptForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_prompt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string getMessage()
        {
            return rtb_prompt.Text;
        }
    }
}
