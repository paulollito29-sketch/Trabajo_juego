namespace TareaAcademica5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.gbxAdminJuegos = new System.Windows.Forms.GroupBox();
            this.btnGuardarJuego = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIdJuego = new System.Windows.Forms.TextBox();
            this.lblIdJuego = new System.Windows.Forms.Label();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.gbxInscripcion = new System.Windows.Forms.GroupBox();
            this.cbxJuegosDisponibles = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.dgvMasPopulares = new System.Windows.Forms.DataGridView();
            this.btnJuegoTop = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtFiltroDoc = new System.Windows.Forms.TextBox();
            this.lblFiltroDoc = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.gbxAdminJuegos.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.gbxInscripcion.SuspendLayout();
            this.tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasPopulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();

            // Panel de Encabezado Estilo UTP/UPC
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlNav.Controls.Add(this.lblHeader);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1000, 75);
            this.pnlNav.TabIndex = 0;

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(350, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PLATAFORMA TORNEO GAMER";

            // TabControl Principal
            this.tbcMain.Controls.Add(this.tabConfig);
            this.tbcMain.Controls.Add(this.tabRegistro);
            this.tbcMain.Controls.Add(this.tabReportes);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbcMain.Location = new System.Drawing.Point(0, 75);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1000, 586);
            this.tbcMain.TabIndex = 1;

            // Pestaña 1: Configuración de Juegos
            this.tabConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabConfig.Controls.Add(this.dgvJuegos);
            this.tabConfig.Controls.Add(this.gbxAdminJuegos);
            this.tabConfig.Location = new System.Drawing.Point(4, 26);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(15);
            this.tabConfig.Size = new System.Drawing.Size(992, 556);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Catálogo de Juegos";

            this.dgvJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJuegos.BackgroundColor = System.Drawing.Color.White;
            this.dgvJuegos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Location = new System.Drawing.Point(340, 30);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.Size = new System.Drawing.Size(620, 490);
            this.dgvJuegos.TabIndex = 1;

            this.gbxAdminJuegos.Controls.Add(this.btnGuardarJuego);
            this.gbxAdminJuegos.Controls.Add(this.txtTitulo);
            this.gbxAdminJuegos.Controls.Add(this.lblTitulo);
            this.gbxAdminJuegos.Controls.Add(this.txtIdJuego);
            this.gbxAdminJuegos.Controls.Add(this.lblIdJuego);
            this.gbxAdminJuegos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbxAdminJuegos.Location = new System.Drawing.Point(20, 30);
            this.gbxAdminJuegos.Name = "gbxAdminJuegos";
            this.gbxAdminJuegos.Size = new System.Drawing.Size(300, 240);
            this.gbxAdminJuegos.TabIndex = 0;
            this.gbxAdminJuegos.TabStop = false;
            this.gbxAdminJuegos.Text = "Registro de Títulos";

            this.btnGuardarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGuardarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarJuego.ForeColor = System.Drawing.Color.White;
            this.btnGuardarJuego.Location = new System.Drawing.Point(25, 175);
            this.btnGuardarJuego.Name = "btnGuardarJuego";
            this.btnGuardarJuego.Size = new System.Drawing.Size(250, 40);
            this.btnGuardarJuego.TabIndex = 4;
            this.btnGuardarJuego.Text = "AGREGAR AL CATÁLOGO";
            this.btnGuardarJuego.UseVisualStyleBackColor = false;
            this.btnGuardarJuego.Click += new System.EventHandler(this.btnGuardarJuego_Click);

            this.txtTitulo.Location = new System.Drawing.Point(25, 125);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(250, 25);
            this.txtTitulo.TabIndex = 3;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 103);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 19);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título del Juego:";

            this.txtIdJuego.Location = new System.Drawing.Point(25, 65);
            this.txtIdJuego.Name = "txtIdJuego";
            this.txtIdJuego.Size = new System.Drawing.Size(250, 25);
            this.txtIdJuego.TabIndex = 1;

            this.lblIdJuego.AutoSize = true;
            this.lblIdJuego.Location = new System.Drawing.Point(21, 43);
            this.lblIdJuego.Name = "lblIdJuego";
            this.lblIdJuego.Size = new System.Drawing.Size(113, 19);
            this.lblIdJuego.TabIndex = 0;
            this.lblIdJuego.Text = "ID Identificador:";

            // Pestaña 2: Registro Participantes
            this.tabRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRegistro.Controls.Add(this.dgvParticipantes);
            this.tabRegistro.Controls.Add(this.gbxInscripcion);
            this.tabRegistro.Location = new System.Drawing.Point(4, 26);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(15);
            this.tabRegistro.Size = new System.Drawing.Size(992, 556);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "Control de Inscripción";

            this.dgvParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParticipantes.Location = new System.Drawing.Point(340, 30);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.Size = new System.Drawing.Size(620, 490);
            this.dgvParticipantes.TabIndex = 3;

            this.gbxInscripcion.Controls.Add(this.cbxJuegosDisponibles);
            this.gbxInscripcion.Controls.Add(this.lblSeleccion);
            this.gbxInscripcion.Controls.Add(this.btnInscribir);
            this.gbxInscripcion.Controls.Add(this.txtNick);
            this.gbxInscripcion.Controls.Add(this.lblNick);
            this.gbxInscripcion.Controls.Add(this.txtDoc);
            this.gbxInscripcion.Controls.Add(this.lblDoc);
            this.gbxInscripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbxInscripcion.Location = new System.Drawing.Point(20, 30);
            this.gbxInscripcion.Name = "gbxInscripcion";
            this.gbxInscripcion.Size = new System.Drawing.Size(300, 330);
            this.gbxInscripcion.TabIndex = 2;
            this.gbxInscripcion.TabStop = false;
            this.gbxInscripcion.Text = "Datos del Participante";

            this.cbxJuegosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJuegosDisponibles.Location = new System.Drawing.Point(25, 205);
            this.cbxJuegosDisponibles.Name = "cbxJuegosDisponibles";
            this.cbxJuegosDisponibles.Size = new System.Drawing.Size(250, 25);
            this.cbxJuegosDisponibles.TabIndex = 6;

            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(21, 183);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(126, 19);
            this.lblSeleccion.TabIndex = 5;
            this.lblSeleccion.Text = "Juego del Torneo:";

            this.btnInscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.ForeColor = System.Drawing.Color.White;
            this.btnInscribir.Location = new System.Drawing.Point(25, 260);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(250, 40);
            this.btnInscribir.TabIndex = 4;
            this.btnInscribir.Text = "CONFIRMAR REGISTRO";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);

            this.txtNick.Location = new System.Drawing.Point(25, 135);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(250, 25);
            this.txtNick.TabIndex = 3;

            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(21, 113);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(74, 19);
            this.lblNick.TabIndex = 2;
            this.lblNick.Text = "Nickname:";

            this.txtDoc.Location = new System.Drawing.Point(25, 75);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(250, 25);
            this.txtDoc.TabIndex = 1;

            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(21, 53);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(112, 19);
            this.lblDoc.TabIndex = 0;
            this.lblDoc.Text = "Documento DNI:";

            // Pestaña 3: Reportes Avanzados
            this.tabReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReportes.Controls.Add(this.dgvMasPopulares);
            this.tabReportes.Controls.Add(this.btnJuegoTop);
            this.tabReportes.Controls.Add(this.dgvResultados);
            this.tabReportes.Controls.Add(this.btnConsultar);
            this.tabReportes.Controls.Add(this.txtFiltroDoc);
            this.tabReportes.Controls.Add(this.lblFiltroDoc);
            this.tabReportes.Location = new System.Drawing.Point(4, 26);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Size = new System.Drawing.Size(992, 556);
            this.tabReportes.TabIndex = 2;
            this.tabReportes.Text = "Panel de Consultas";

            this.lblFiltroDoc.AutoSize = true;
            this.lblFiltroDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblFiltroDoc.Location = new System.Drawing.Point(25, 30);
            this.lblFiltroDoc.Name = "lblFiltroDoc";
            this.lblFiltroDoc.Size = new System.Drawing.Size(155, 19);
            this.lblFiltroDoc.TabIndex = 0;
            this.lblFiltroDoc.Text = "DNI para seguimiento:";

            this.txtFiltroDoc.Location = new System.Drawing.Point(29, 60);
            this.txtFiltroDoc.Name = "txtFiltroDoc";
            this.txtFiltroDoc.Size = new System.Drawing.Size(180, 25);
            this.txtFiltroDoc.TabIndex = 1;

            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(220, 58);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 30);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.Location = new System.Drawing.Point(29, 110);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(430, 410);
            this.dgvResultados.TabIndex = 3;

            this.btnJuegoTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnJuegoTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuegoTop.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnJuegoTop.ForeColor = System.Drawing.Color.White;
            this.btnJuegoTop.Location = new System.Drawing.Point(500, 58);
            this.btnJuegoTop.Name = "btnJuegoTop";
            this.btnJuegoTop.Size = new System.Drawing.Size(450, 30);
            this.btnJuegoTop.TabIndex = 4;
            this.btnJuegoTop.Text = "CALCULAR JUEGOS CON MÁXIMA AUDIENCIA";
            this.btnJuegoTop.UseVisualStyleBackColor = false;
            this.btnJuegoTop.Click += new System.EventHandler(this.btnJuegoTop_Click);

            this.dgvMasPopulares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasPopulares.BackgroundColor = System.Drawing.Color.White;
            this.dgvMasPopulares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMasPopulares.Location = new System.Drawing.Point(500, 110);
            this.dgvMasPopulares.Name = "dgvMasPopulares";
            this.dgvMasPopulares.Size = new System.Drawing.Size(450, 410);
            this.dgvMasPopulares.TabIndex = 5;

            // Formulario Principal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 661);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Campeonatos";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.gbxAdminJuegos.ResumeLayout(false);
            this.gbxAdminJuegos.PerformLayout();
            this.tabRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.gbxInscripcion.ResumeLayout(false);
            this.gbxInscripcion.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasPopulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.GroupBox gbxAdminJuegos;
        private System.Windows.Forms.Label lblIdJuego;
        private System.Windows.Forms.TextBox txtIdJuego;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnGuardarJuego;
        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.GroupBox gbxInscripcion;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.ComboBox cbxJuegosDisponibles;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.Label lblFiltroDoc;
        private System.Windows.Forms.TextBox txtFiltroDoc;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnJuegoTop;
        private System.Windows.Forms.DataGridView dgvMasPopulares;
    }
}