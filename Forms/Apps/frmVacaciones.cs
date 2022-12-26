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
    public partial class frmVacaciones : Form
    {
        private Form activeForm;


        public frmVacaciones()
        {
            InitializeComponent();
            CargarExplicacion();
        }

        private void CargarExplicacion()
        {
            lblExplicacion.Text = "De conformidad con el Art. 23, Lit g) y 29 de la LOSEP, " + "VARIABLE DE NOMBRES Y APELLIDOS UNIFICADOS" + ","+ " gozará de " + "VARIABLE DE (USO DE VACACIONES)" + " días de vacaciones, que regirán desde el día " +""+ "VARIABLE (DESDE FECHA)" + "hasta el " + "VARIABLE (HASTA FECHA)" + " , debiendo reintegrarse a sus labores el " +"VARIABLE (FECHA RETORNO)" + ".";
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
            //groupBoxDatosIniciales.Visible = false;
            //groupBoxDatosSesion.Visible = false;
            lblTitle.Visible = false;
            btnRegresar.Visible = false;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Apps.frmBDVacaciones(), sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.Login ventana = new Forms.Login();
            ventana.Show();
            this.Hide();
        }
    }
}
