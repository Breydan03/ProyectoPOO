namespace Covid_19
{
    partial class FrmCovid19
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCovid19));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pickCovid19 = new System.Windows.Forms.PictureBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.txtHoraActual = new System.Windows.Forms.TextBox();
            this.btnCerrarA = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbSintomas = new System.Windows.Forms.GroupBox();
            this.btnDianostico = new System.Windows.Forms.Button();
            this.btnResumir = new System.Windows.Forms.Button();
            this.chkIncapacidad = new System.Windows.Forms.CheckBox();
            this.chkDolorPecho = new System.Windows.Forms.CheckBox();
            this.chkRespiracion = new System.Windows.Forms.CheckBox();
            this.lblSintomasGraves = new System.Windows.Forms.Label();
            this.chkCansancio = new System.Windows.Forms.CheckBox();
            this.chkTos = new System.Windows.Forms.CheckBox();
            this.chkFiebre = new System.Windows.Forms.CheckBox();
            this.lblSintomasBasicos = new System.Windows.Forms.Label();
            this.gbInformacionPacientes = new System.Windows.Forms.GroupBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            this.lblNivelAcademico = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pickCovid19)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbSintomas.SuspendLayout();
            this.gbInformacionPacientes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(66, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DIAGNÓSTICO DE PACIENTES";
            // 
            // pickCovid19
            // 
            this.pickCovid19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pickCovid19.BackgroundImage")));
            this.pickCovid19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pickCovid19.Location = new System.Drawing.Point(408, 23);
            this.pickCovid19.Name = "pickCovid19";
            this.pickCovid19.Size = new System.Drawing.Size(221, 114);
            this.pickCovid19.TabIndex = 1;
            this.pickCovid19.TabStop = false;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(646, 45);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(120, 20);
            this.lblFechaActual.TabIndex = 2;
            this.lblFechaActual.Text = "Fecha Actual:";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Enabled = false;
            this.txtFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaActual.Location = new System.Drawing.Point(772, 42);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(128, 26);
            this.txtFechaActual.TabIndex = 3;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(907, 46);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(109, 20);
            this.lblHoraActual.TabIndex = 4;
            this.lblHoraActual.Text = "Hora Actual:";
            // 
            // txtHoraActual
            // 
            this.txtHoraActual.Enabled = false;
            this.txtHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraActual.Location = new System.Drawing.Point(1022, 43);
            this.txtHoraActual.Name = "txtHoraActual";
            this.txtHoraActual.Size = new System.Drawing.Size(128, 26);
            this.txtHoraActual.TabIndex = 5;
            // 
            // btnCerrarA
            // 
            this.btnCerrarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarA.Location = new System.Drawing.Point(1040, 94);
            this.btnCerrarA.Name = "btnCerrarA";
            this.btnCerrarA.Size = new System.Drawing.Size(109, 43);
            this.btnCerrarA.TabIndex = 6;
            this.btnCerrarA.Text = "Cerrar Aplicación";
            this.btnCerrarA.UseVisualStyleBackColor = true;
            this.btnCerrarA.Click += new System.EventHandler(this.btnCerrarA_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.gbSintomas);
            this.tabPage1.Controls.Add(this.gbInformacionPacientes);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del paciente";
            // 
            // gbSintomas
            // 
            this.gbSintomas.Controls.Add(this.btnDianostico);
            this.gbSintomas.Controls.Add(this.btnResumir);
            this.gbSintomas.Controls.Add(this.chkIncapacidad);
            this.gbSintomas.Controls.Add(this.chkDolorPecho);
            this.gbSintomas.Controls.Add(this.chkRespiracion);
            this.gbSintomas.Controls.Add(this.lblSintomasGraves);
            this.gbSintomas.Controls.Add(this.chkCansancio);
            this.gbSintomas.Controls.Add(this.chkTos);
            this.gbSintomas.Controls.Add(this.chkFiebre);
            this.gbSintomas.Controls.Add(this.lblSintomasBasicos);
            this.gbSintomas.Location = new System.Drawing.Point(407, 7);
            this.gbSintomas.Name = "gbSintomas";
            this.gbSintomas.Size = new System.Drawing.Size(754, 474);
            this.gbSintomas.TabIndex = 1;
            this.gbSintomas.TabStop = false;
            this.gbSintomas.Text = "Síntomas";
            // 
            // btnDianostico
            // 
            this.btnDianostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDianostico.Location = new System.Drawing.Point(616, 345);
            this.btnDianostico.Name = "btnDianostico";
            this.btnDianostico.Size = new System.Drawing.Size(114, 52);
            this.btnDianostico.TabIndex = 32;
            this.btnDianostico.Text = "Nuevo Diagnóstico";
            this.btnDianostico.UseVisualStyleBackColor = true;
            this.btnDianostico.Click += new System.EventHandler(this.btnDianostico_Click);
            // 
            // btnResumir
            // 
            this.btnResumir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumir.Location = new System.Drawing.Point(348, 249);
            this.btnResumir.Name = "btnResumir";
            this.btnResumir.Size = new System.Drawing.Size(89, 30);
            this.btnResumir.TabIndex = 31;
            this.btnResumir.Text = "Resumir";
            this.btnResumir.UseVisualStyleBackColor = true;
            this.btnResumir.Click += new System.EventHandler(this.btnResumir_Click);
            // 
            // chkIncapacidad
            // 
            this.chkIncapacidad.AutoSize = true;
            this.chkIncapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncapacidad.Location = new System.Drawing.Point(163, 192);
            this.chkIncapacidad.Name = "chkIncapacidad";
            this.chkIncapacidad.Size = new System.Drawing.Size(273, 20);
            this.chkIncapacidad.TabIndex = 30;
            this.chkIncapacidad.Text = "Incapacidad para hablar o moverse";
            this.chkIncapacidad.UseVisualStyleBackColor = true;
            this.chkIncapacidad.CheckedChanged += new System.EventHandler(this.chkIncapacidad_CheckedChanged);
            // 
            // chkDolorPecho
            // 
            this.chkDolorPecho.AutoSize = true;
            this.chkDolorPecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDolorPecho.Location = new System.Drawing.Point(163, 166);
            this.chkDolorPecho.Name = "chkDolorPecho";
            this.chkDolorPecho.Size = new System.Drawing.Size(218, 20);
            this.chkDolorPecho.TabIndex = 29;
            this.chkDolorPecho.Text = "Dolor o presión en el pecho\r\n";
            this.chkDolorPecho.UseVisualStyleBackColor = true;
            this.chkDolorPecho.CheckedChanged += new System.EventHandler(this.chkDolorPecho_CheckedChanged);
            // 
            // chkRespiracion
            // 
            this.chkRespiracion.AutoSize = true;
            this.chkRespiracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRespiracion.Location = new System.Drawing.Point(163, 140);
            this.chkRespiracion.Name = "chkRespiracion";
            this.chkRespiracion.Size = new System.Drawing.Size(382, 20);
            this.chkRespiracion.TabIndex = 28;
            this.chkRespiracion.Text = "Dificultad para respirar o sensación de falta de aire";
            this.chkRespiracion.UseVisualStyleBackColor = true;
            this.chkRespiracion.CheckedChanged += new System.EventHandler(this.chkRespiracion_CheckedChanged);
            // 
            // lblSintomasGraves
            // 
            this.lblSintomasGraves.AutoSize = true;
            this.lblSintomasGraves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomasGraves.ForeColor = System.Drawing.Color.Maroon;
            this.lblSintomasGraves.Location = new System.Drawing.Point(6, 141);
            this.lblSintomasGraves.Name = "lblSintomasGraves";
            this.lblSintomasGraves.Size = new System.Drawing.Size(127, 16);
            this.lblSintomasGraves.TabIndex = 27;
            this.lblSintomasGraves.Text = "Síntomas graves:";
            // 
            // chkCansancio
            // 
            this.chkCansancio.AutoSize = true;
            this.chkCansancio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCansancio.Location = new System.Drawing.Point(163, 79);
            this.chkCansancio.Name = "chkCansancio";
            this.chkCansancio.Size = new System.Drawing.Size(99, 20);
            this.chkCansancio.TabIndex = 26;
            this.chkCansancio.Text = "Cansancio";
            this.chkCansancio.UseVisualStyleBackColor = true;
            this.chkCansancio.CheckedChanged += new System.EventHandler(this.chkCansancio_CheckedChanged);
            // 
            // chkTos
            // 
            this.chkTos.AutoSize = true;
            this.chkTos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTos.Location = new System.Drawing.Point(163, 53);
            this.chkTos.Name = "chkTos";
            this.chkTos.Size = new System.Drawing.Size(91, 20);
            this.chkTos.TabIndex = 25;
            this.chkTos.Text = "Tos seca";
            this.chkTos.UseVisualStyleBackColor = true;
            this.chkTos.CheckedChanged += new System.EventHandler(this.chkTos_CheckedChanged);
            // 
            // chkFiebre
            // 
            this.chkFiebre.AutoSize = true;
            this.chkFiebre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiebre.Location = new System.Drawing.Point(163, 27);
            this.chkFiebre.Name = "chkFiebre";
            this.chkFiebre.Size = new System.Drawing.Size(71, 20);
            this.chkFiebre.TabIndex = 24;
            this.chkFiebre.Text = "Fiebre";
            this.chkFiebre.UseVisualStyleBackColor = true;
            this.chkFiebre.CheckedChanged += new System.EventHandler(this.chkFiebre_CheckedChanged);
            // 
            // lblSintomasBasicos
            // 
            this.lblSintomasBasicos.AutoSize = true;
            this.lblSintomasBasicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomasBasicos.ForeColor = System.Drawing.Color.Maroon;
            this.lblSintomasBasicos.Location = new System.Drawing.Point(6, 25);
            this.lblSintomasBasicos.Name = "lblSintomasBasicos";
            this.lblSintomasBasicos.Size = new System.Drawing.Size(134, 16);
            this.lblSintomasBasicos.TabIndex = 23;
            this.lblSintomasBasicos.Text = "Síntomas básicos:";
            // 
            // gbInformacionPacientes
            // 
            this.gbInformacionPacientes.Controls.Add(this.txtNacionalidad);
            this.gbInformacionPacientes.Controls.Add(this.txtEstadoCivil);
            this.gbInformacionPacientes.Controls.Add(this.lblNacionalidad);
            this.gbInformacionPacientes.Controls.Add(this.lblEstadoCivil);
            this.gbInformacionPacientes.Controls.Add(this.dtpFechaNacimiento);
            this.gbInformacionPacientes.Controls.Add(this.lblFechaNacimiento);
            this.gbInformacionPacientes.Controls.Add(this.txtCorreo);
            this.gbInformacionPacientes.Controls.Add(this.lblCorreo);
            this.gbInformacionPacientes.Controls.Add(this.rbFemenino);
            this.gbInformacionPacientes.Controls.Add(this.rbMasculino);
            this.gbInformacionPacientes.Controls.Add(this.lblSexo);
            this.gbInformacionPacientes.Controls.Add(this.txtDireccion);
            this.gbInformacionPacientes.Controls.Add(this.lblDireccion);
            this.gbInformacionPacientes.Controls.Add(this.lblProvincia);
            this.gbInformacionPacientes.Controls.Add(this.cbNivelAcademico);
            this.gbInformacionPacientes.Controls.Add(this.cbProvincias);
            this.gbInformacionPacientes.Controls.Add(this.lblNivelAcademico);
            this.gbInformacionPacientes.Controls.Add(this.txtSegundoApellido);
            this.gbInformacionPacientes.Controls.Add(this.lblSegundoApellido);
            this.gbInformacionPacientes.Controls.Add(this.txtPrimerApellido);
            this.gbInformacionPacientes.Controls.Add(this.lblPrimerApellido);
            this.gbInformacionPacientes.Controls.Add(this.txtNombre);
            this.gbInformacionPacientes.Controls.Add(this.lblNombre);
            this.gbInformacionPacientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbInformacionPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionPacientes.Location = new System.Drawing.Point(6, 6);
            this.gbInformacionPacientes.Name = "gbInformacionPacientes";
            this.gbInformacionPacientes.Size = new System.Drawing.Size(379, 475);
            this.gbInformacionPacientes.TabIndex = 0;
            this.gbInformacionPacientes.TabStop = false;
            this.gbInformacionPacientes.Text = "Información de pacientes";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.BackColor = System.Drawing.Color.Gold;
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(164, 433);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(204, 22);
            this.txtNacionalidad.TabIndex = 22;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.BackColor = System.Drawing.Color.Gold;
            this.txtEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCivil.Location = new System.Drawing.Point(164, 398);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(204, 22);
            this.txtEstadoCivil.TabIndex = 21;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.ForeColor = System.Drawing.Color.Maroon;
            this.lblNacionalidad.Location = new System.Drawing.Point(7, 439);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(104, 16);
            this.lblNacionalidad.TabIndex = 20;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.Maroon;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 400);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(94, 16);
            this.lblEstadoCivil.TabIndex = 19;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(164, 359);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(204, 22);
            this.dtpFechaNacimiento.TabIndex = 18;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Maroon;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 359);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(155, 16);
            this.lblFechaNacimiento.TabIndex = 17;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Gold;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(164, 322);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(204, 22);
            this.txtCorreo.TabIndex = 16;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.Maroon;
            this.lblCorreo.Location = new System.Drawing.Point(7, 324);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 16);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(265, 289);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(93, 20);
            this.rbFemenino.TabIndex = 14;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(164, 289);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(95, 20);
            this.rbMasculino.TabIndex = 13;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.Maroon;
            this.lblSexo.Location = new System.Drawing.Point(7, 291);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 16);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Gold;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(164, 222);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(204, 58);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.Maroon;
            this.lblDireccion.Location = new System.Drawing.Point(7, 224);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(77, 16);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.ForeColor = System.Drawing.Color.Maroon;
            this.lblProvincia.Location = new System.Drawing.Point(6, 182);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(76, 16);
            this.lblProvincia.TabIndex = 9;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cbNivelAcademico
            // 
            this.cbNivelAcademico.BackColor = System.Drawing.Color.Gold;
            this.cbNivelAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelAcademico.FormattingEnabled = true;
            this.cbNivelAcademico.Items.AddRange(new object[] {
            "Primaria incompleta",
            "Primera completa",
            "Secundaria incompleta",
            "Secundaria completa",
            "Bachillerato completo",
            "Universidad incompleta",
            "Universidad completa"});
            this.cbNivelAcademico.Location = new System.Drawing.Point(164, 139);
            this.cbNivelAcademico.Name = "cbNivelAcademico";
            this.cbNivelAcademico.Size = new System.Drawing.Size(204, 24);
            this.cbNivelAcademico.TabIndex = 8;
            this.cbNivelAcademico.SelectedIndexChanged += new System.EventHandler(this.cbNivelAcademico_SelectedIndexChanged);
            // 
            // cbProvincias
            // 
            this.cbProvincias.BackColor = System.Drawing.Color.Gold;
            this.cbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.Items.AddRange(new object[] {
            "San José",
            "Cartago",
            "Heredia",
            "Alajuela",
            "Heredia",
            "Guanacaste",
            "Limón"});
            this.cbProvincias.Location = new System.Drawing.Point(164, 179);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(204, 24);
            this.cbProvincias.TabIndex = 7;
            this.cbProvincias.SelectedIndexChanged += new System.EventHandler(this.cbProvincias_SelectedIndexChanged);
            // 
            // lblNivelAcademico
            // 
            this.lblNivelAcademico.AutoSize = true;
            this.lblNivelAcademico.ForeColor = System.Drawing.Color.Maroon;
            this.lblNivelAcademico.Location = new System.Drawing.Point(7, 142);
            this.lblNivelAcademico.Name = "lblNivelAcademico";
            this.lblNivelAcademico.Size = new System.Drawing.Size(129, 16);
            this.lblNivelAcademico.TabIndex = 6;
            this.lblNivelAcademico.Text = "Nivel Académico:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.Gold;
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSegundoApellido.Location = new System.Drawing.Point(164, 100);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(204, 22);
            this.txtSegundoApellido.TabIndex = 5;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.Maroon;
            this.lblSegundoApellido.Location = new System.Drawing.Point(6, 102);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(135, 16);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.Gold;
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrimerApellido.Location = new System.Drawing.Point(164, 63);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(204, 22);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrimerApellido.Location = new System.Drawing.Point(7, 65);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(118, 16);
            this.lblPrimerApellido.TabIndex = 2;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gold;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(164, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Maroon;
            this.lblNombre.Location = new System.Drawing.Point(6, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 520);
            this.tabControl1.TabIndex = 7;
            // 
            // FrmCovid19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrarA);
            this.Controls.Add(this.txtHoraActual);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.pickCovid19);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCovid19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de pacientes COVID-19";
            this.Load += new System.EventHandler(this.FrmCovid19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickCovid19)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.gbSintomas.ResumeLayout(false);
            this.gbSintomas.PerformLayout();
            this.gbInformacionPacientes.ResumeLayout(false);
            this.gbInformacionPacientes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pickCovid19;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.TextBox txtHoraActual;
        private System.Windows.Forms.Button btnCerrarA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox gbInformacionPacientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.ComboBox cbProvincias;
        private System.Windows.Forms.Label lblNivelAcademico;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cbNivelAcademico;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.GroupBox gbSintomas;
        private System.Windows.Forms.CheckBox chkTos;
        private System.Windows.Forms.CheckBox chkFiebre;
        private System.Windows.Forms.Label lblSintomasBasicos;
        private System.Windows.Forms.Label lblSintomasGraves;
        private System.Windows.Forms.CheckBox chkCansancio;
        private System.Windows.Forms.Button btnDianostico;
        private System.Windows.Forms.Button btnResumir;
        private System.Windows.Forms.CheckBox chkIncapacidad;
        private System.Windows.Forms.CheckBox chkDolorPecho;
        private System.Windows.Forms.CheckBox chkRespiracion;
    }
}

