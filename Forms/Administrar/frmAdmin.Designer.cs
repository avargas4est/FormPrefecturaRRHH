
namespace FormPrefecturaRRHH.Forms
{
    partial class frmAdmin
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
            this.groupBoxGestionar = new System.Windows.Forms.GroupBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSecretarias = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.groupBoxGestionar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGestionar
            // 
            this.groupBoxGestionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGestionar.Controls.Add(this.btnEmpleados);
            this.groupBoxGestionar.Controls.Add(this.btnUsuarios);
            this.groupBoxGestionar.Controls.Add(this.btnSecretarias);
            this.groupBoxGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGestionar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGestionar.Name = "groupBoxGestionar";
            this.groupBoxGestionar.Size = new System.Drawing.Size(580, 133);
            this.groupBoxGestionar.TabIndex = 1;
            this.groupBoxGestionar.TabStop = false;
            this.groupBoxGestionar.Text = "Gestionar";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Image = global::FormPrefecturaRRHH.Properties.Resources.users_40493;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleados.Location = new System.Drawing.Point(125, 26);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(89, 87);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Image = global::FormPrefecturaRRHH.Properties.Resources.work_office_64;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(27, 26);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(78, 87);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSecretarias
            // 
            this.btnSecretarias.FlatAppearance.BorderSize = 0;
            this.btnSecretarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecretarias.Image = global::FormPrefecturaRRHH.Properties.Resources.workplace_64;
            this.btnSecretarias.Location = new System.Drawing.Point(228, 26);
            this.btnSecretarias.Name = "btnSecretarias";
            this.btnSecretarias.Size = new System.Drawing.Size(86, 87);
            this.btnSecretarias.TabIndex = 2;
            this.btnSecretarias.Text = "Secretarías";
            this.btnSecretarias.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSecretarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSecretarias.UseVisualStyleBackColor = true;
            this.btnSecretarias.Click += new System.EventHandler(this.btnSecretarias_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.groupBoxGestionar);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(620, 370);
            this.panelDesktopPanel.TabIndex = 3;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 370);
            this.Controls.Add(this.panelDesktopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.Text = "Administrar";
            this.groupBoxGestionar.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxGestionar;
        private System.Windows.Forms.Button btnSecretarias;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}