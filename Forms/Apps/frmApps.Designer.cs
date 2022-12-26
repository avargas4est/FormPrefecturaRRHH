
namespace FormPrefecturaRRHH.Forms.Apps
{
    partial class frmApps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxGestiondelTiempo = new System.Windows.Forms.GroupBox();
            this.btnVacaciones = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxGestiondelTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGestiondelTiempo
            // 
            this.groupBoxGestiondelTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGestiondelTiempo.Controls.Add(this.btnVacaciones);
            this.groupBoxGestiondelTiempo.Controls.Add(this.btnContratos);
            this.groupBoxGestiondelTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGestiondelTiempo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGestiondelTiempo.Name = "groupBoxGestiondelTiempo";
            this.groupBoxGestiondelTiempo.Size = new System.Drawing.Size(596, 133);
            this.groupBoxGestiondelTiempo.TabIndex = 2;
            this.groupBoxGestiondelTiempo.TabStop = false;
            this.groupBoxGestiondelTiempo.Text = "Gestión del Tiempo";
            this.groupBoxGestiondelTiempo.Enter += new System.EventHandler(this.groupBoxGestiondelTiempo_Enter);
            // 
            // btnVacaciones
            // 
            this.btnVacaciones.FlatAppearance.BorderSize = 0;
            this.btnVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacaciones.Image = global::FormPrefecturaRRHH.Properties.Resources.holiday_64;
            this.btnVacaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacaciones.Location = new System.Drawing.Point(125, 26);
            this.btnVacaciones.Name = "btnVacaciones";
            this.btnVacaciones.Size = new System.Drawing.Size(89, 87);
            this.btnVacaciones.TabIndex = 5;
            this.btnVacaciones.Text = "Vacaciones";
            this.btnVacaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVacaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVacaciones.UseVisualStyleBackColor = true;
            this.btnVacaciones.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.FlatAppearance.BorderSize = 0;
            this.btnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratos.Image = global::FormPrefecturaRRHH.Properties.Resources.contract_64;
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContratos.Location = new System.Drawing.Point(27, 26);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(78, 87);
            this.btnContratos.TabIndex = 4;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(620, 370);
            this.panelDesktopPanel.TabIndex = 4;
            // 
            // frmApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 370);
            this.Controls.Add(this.groupBoxGestiondelTiempo);
            this.Controls.Add(this.panelDesktopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApps";
            this.Text = "Aplicaciones";
            this.groupBoxGestiondelTiempo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGestiondelTiempo;
        private System.Windows.Forms.Button btnVacaciones;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}