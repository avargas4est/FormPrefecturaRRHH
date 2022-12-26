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
    public partial class Usuarios : Form
    {
        private Form activeForm;
        public Usuarios()
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
            groupBoxDatosIniciales.Visible = false;
            groupBoxDatosSesion.Visible = false;
            lblTitle.Visible = false;
            btnRegresar.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmBDUsuarios(), sender);
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
