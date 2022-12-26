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
    public partial class frmBDEmpleados : Form
    {
        private Form activeForm;
        public frmBDEmpleados()
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
            //groupBoxDatosPersonales.Visible = false;
            //groupBoxSituacionActual.Visible = false;
            //lblTitle.Visible = false;
            btnRegresar.Visible = false;
            //lblTitle.Text = "Nuevo";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmAdmin(), sender);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Forms.frmEmpleados CambiarLabel = new Forms.frmEmpleados();
            OpenChildForm(CambiarLabel, sender);
            CambiarLabel.lblTitle.Text = "     Nuevo Empleado";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Forms.frmEmpleados CambiarLabel = new Forms.frmEmpleados();
            OpenChildForm(CambiarLabel, sender);
            CambiarLabel.lblTitle.Text = "     Editar Empleado";
        }
    }
}
