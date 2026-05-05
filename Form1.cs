using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TareaAcademica5
{
    public partial class Form1 : Form
    {
        List<Juego> dbJuegos = new List<Juego>();
        List<Participante> dbParticipantes = new List<Participante>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarJuego_Click(object sender, EventArgs e)
        {
            Juego juegoExistente = dbJuegos.Find(x => x.IdJuego == txtIdJuego.Text);

            if (juegoExistente != null)
            {
                MessageBox.Show("Este ID de juego ya fue registrado.");
                return;
            }

            Juego nuevoJuego = new Juego();
            nuevoJuego.IdJuego = txtIdJuego.Text;
            nuevoJuego.Titulo = txtTitulo.Text;

            dbJuegos.Add(nuevoJuego);

            dgvJuegos.DataSource = null;
            dgvJuegos.DataSource = dbJuegos;

            cbxJuegosDisponibles.DataSource = null;
            cbxJuegosDisponibles.DataSource = dbJuegos;
            cbxJuegosDisponibles.DisplayMember = "Titulo";

            txtIdJuego.Clear();
            txtTitulo.Clear();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            Juego juegoElegido = (Juego)cbxJuegosDisponibles.SelectedItem;

            if (juegoElegido == null)
            {
                MessageBox.Show("Debes elegir un juego de la lista.");
                return;
            }

            Participante participanteActual = dbParticipantes.Find(p => p.Documento == txtDoc.Text);

            if (participanteActual == null)
            {
                participanteActual = new Participante();
                participanteActual.Documento = txtDoc.Text;
                participanteActual.Nickname = txtNick.Text;
                dbParticipantes.Add(participanteActual);
            }
            else
            {
                if (participanteActual.Nickname != txtNick.Text)
                {
                    MessageBox.Show("El documento ingresado le pertenece a otro Nickname.");
                    return;
                }
            }

            Juego verificacion = participanteActual.JuegosInscritos.Find(j => j.IdJuego == juegoElegido.IdJuego);

            if (verificacion == null)
            {
                participanteActual.JuegosInscritos.Add(juegoElegido);
                juegoElegido.ListaParticipantes.Add(participanteActual);
            }
            else
            {
                MessageBox.Show("El participante ya compite en este juego.");
                return;
            }

            dgvParticipantes.DataSource = null;
            dgvParticipantes.DataSource = dbParticipantes.ToList();

            txtDoc.Clear();
            txtNick.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Participante resultado = dbParticipantes.Find(p => p.Documento == txtFiltroDoc.Text);

            if (resultado != null)
            {
                dgvResultados.DataSource = null;
                dgvResultados.DataSource = resultado.JuegosInscritos;
            }
            else
            {
                MessageBox.Show("No existen registros para ese documento.");
                dgvResultados.DataSource = null;
            }
        }

        private void btnJuegoTop_Click(object sender, EventArgs e)
        {
            if (dbJuegos.Count > 0)
            {
                int cantidadMaxima = 0;

                foreach (Juego j in dbJuegos)
                {
                    if (j.ListaParticipantes.Count > cantidadMaxima)
                    {
                        cantidadMaxima = j.ListaParticipantes.Count;
                    }
                }

                List<Juego> juegosMasJugados = dbJuegos.FindAll(j => j.ListaParticipantes.Count == cantidadMaxima);

                dgvMasPopulares.DataSource = null;
                dgvMasPopulares.DataSource = juegosMasJugados;
            }
        }
    }
}