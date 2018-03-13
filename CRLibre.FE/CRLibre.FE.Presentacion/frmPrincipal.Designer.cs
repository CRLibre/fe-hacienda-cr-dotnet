namespace CRLibre.FE.Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgvCertificados = new System.Windows.Forms.TabPage();
            this.txtPasswordContibuynete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacionContribuyente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbicacionCertificadoDigital = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCertificado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombreCertificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDatosCertificado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dgvCertificados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.dgvCertificados);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // dgvCertificados
            // 
            this.dgvCertificados.Controls.Add(this.lblDatosCertificado);
            this.dgvCertificados.Controls.Add(this.txtPasswordContibuynete);
            this.dgvCertificados.Controls.Add(this.label5);
            this.dgvCertificados.Controls.Add(this.txtIdentificacionContribuyente);
            this.dgvCertificados.Controls.Add(this.label4);
            this.dgvCertificados.Controls.Add(this.label3);
            this.dgvCertificados.Controls.Add(this.txtUbicacionCertificadoDigital);
            this.dgvCertificados.Controls.Add(this.btnSeleccionarCertificado);
            this.dgvCertificados.Controls.Add(this.dataGridView1);
            this.dgvCertificados.Controls.Add(this.label2);
            this.dgvCertificados.Controls.Add(this.label1);
            this.dgvCertificados.Location = new System.Drawing.Point(4, 22);
            this.dgvCertificados.Name = "dgvCertificados";
            this.dgvCertificados.Padding = new System.Windows.Forms.Padding(3);
            this.dgvCertificados.Size = new System.Drawing.Size(1021, 534);
            this.dgvCertificados.TabIndex = 0;
            this.dgvCertificados.Text = "Paso 1. Cargar certificado";
            this.dgvCertificados.UseVisualStyleBackColor = true;
            // 
            // txtPasswordContibuynete
            // 
            this.txtPasswordContibuynete.Location = new System.Drawing.Point(221, 146);
            this.txtPasswordContibuynete.Name = "txtPasswordContibuynete";
            this.txtPasswordContibuynete.Size = new System.Drawing.Size(256, 20);
            this.txtPasswordContibuynete.TabIndex = 9;
            this.txtPasswordContibuynete.Text = "8204";
            this.txtPasswordContibuynete.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Paso 2) Su contraseña de ingreso es:";
            // 
            // txtIdentificacionContribuyente
            // 
            this.txtIdentificacionContribuyente.Location = new System.Drawing.Point(221, 102);
            this.txtIdentificacionContribuyente.Name = "txtIdentificacionContribuyente";
            this.txtIdentificacionContribuyente.Size = new System.Drawing.Size(256, 20);
            this.txtIdentificacionContribuyente.TabIndex = 7;
            this.txtIdentificacionContribuyente.Text = "205930122";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paso 1) Su identificación de ingreso es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paso 3)";
            // 
            // txtUbicacionCertificadoDigital
            // 
            this.txtUbicacionCertificadoDigital.Location = new System.Drawing.Point(221, 194);
            this.txtUbicacionCertificadoDigital.Name = "txtUbicacionCertificadoDigital";
            this.txtUbicacionCertificadoDigital.ReadOnly = true;
            this.txtUbicacionCertificadoDigital.Size = new System.Drawing.Size(256, 20);
            this.txtUbicacionCertificadoDigital.TabIndex = 4;
            // 
            // btnSeleccionarCertificado
            // 
            this.btnSeleccionarCertificado.Location = new System.Drawing.Point(73, 187);
            this.btnSeleccionarCertificado.Name = "btnSeleccionarCertificado";
            this.btnSeleccionarCertificado.Size = new System.Drawing.Size(133, 32);
            this.btnSeleccionarCertificado.TabIndex = 3;
            this.btnSeleccionarCertificado.Text = "Seleccionar Certificado";
            this.btnSeleccionarCertificado.UseVisualStyleBackColor = true;
            this.btnSeleccionarCertificado.Click += new System.EventHandler(this.btnSeleccionarCertificado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreCertificado});
            this.dataGridView1.Location = new System.Drawing.Point(585, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 154);
            this.dataGridView1.TabIndex = 2;
            // 
            // colNombreCertificado
            // 
            this.colNombreCertificado.HeaderText = "Nombre";
            this.colNombreCertificado.Name = "colNombreCertificado";
            this.colNombreCertificado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una vez generado el certificado desde el sitio de ATV del Ministerio de Hacienda," +
    " se debe cargar para su uso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargar certificado digital del ATV";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(942, 562);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDatosCertificado
            // 
            this.lblDatosCertificado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosCertificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatosCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDatosCertificado.Location = new System.Drawing.Point(25, 231);
            this.lblDatosCertificado.Name = "lblDatosCertificado";
            this.lblDatosCertificado.Size = new System.Drawing.Size(987, 292);
            this.lblDatosCertificado.TabIndex = 10;
            this.lblDatosCertificado.Text = "Datos del certificado:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(1029, 592);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "Proyecto de CRLibre.org";
            this.tabControl1.ResumeLayout(false);
            this.dgvCertificados.ResumeLayout(false);
            this.dgvCertificados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dgvCertificados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordContibuynete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacionContribuyente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUbicacionCertificadoDigital;
        private System.Windows.Forms.Button btnSeleccionarCertificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCertificado;
        private System.Windows.Forms.Label lblDatosCertificado;
    }
}

