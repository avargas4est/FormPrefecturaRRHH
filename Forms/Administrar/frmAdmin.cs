using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrefecturaRRHH.Forms
{
    public partial class frmAdmin : Form
    {
        private Form activeForm;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            groupBoxGestionar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmBDUsuarios(), sender);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmBDEmpleados(), sender);
        }

        private void btnSecretarias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmBDSecretarias(), sender);
        }
    }
}
