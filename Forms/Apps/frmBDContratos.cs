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
    public partial class frmBDContratos : Form
    {
        private Form activeForm;
        public frmBDContratos()
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
            //groupBoxGestionar.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Apps.frmApps(), sender);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Forms.Apps.frmContratos CambiarLabel = new Forms.Apps.frmContratos();
            OpenChildForm(CambiarLabel, sender);
            CambiarLabel.lblTitle.Text = "     Nuevo Contrato";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Forms.Apps.frmContratos CambiarLabel = new Forms.Apps.frmContratos();
            OpenChildForm(CambiarLabel, sender);
            CambiarLabel.lblTitle.Text = "     Editar Contrato";
        }
    }
}

