using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrefecturaRRHH.Forms.Apps
{
    public partial class frmApps : Form
    {

        private Form activeForm;
        public frmApps()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            groupBoxGestiondelTiempo.Visible = false;
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Apps.frmBDVacaciones(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Apps.frmBDContratos(), sender);
        }

        private void groupBoxGestiondelTiempo_Enter(object sender, EventArgs e)
        {

        }
    }
}
