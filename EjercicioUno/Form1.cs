using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EjercicioUno
{
    public partial class frmEjercicioUno : Form
    {
        public frmEjercicioUno()
        {
            InitializeComponent();
        }

        private List<Paciente> listPaciente = new List<Paciente>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MostrarLista()
        {
            lstPacientes.Items.Clear();
            foreach (var paciente in listPaciente)
            {
                lstPacientes.Items.Add(paciente);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };

            listPaciente.Add(nuevoPaciente);
            MostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string curItem = lstPacientes.SelectedItem.ToString();
            int index = lstPacientes.FindString(curItem);
            for (int i = 0; i < listPaciente.Count; i++)
            {
                if (i == index)
                {
                    listPaciente.RemoveAt(i);
                }
            }
            MostrarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string curItem = lstPacientes.SelectedItem.ToString();
            int index = lstPacientes.FindString(curItem);

            if(index >= 0)
            {
                listPaciente[index].Codigo = txtCodigo.Text;
                listPaciente[index].Nombre = txtNombre.Text;
                listPaciente[index].Apellido = txtApellido.Text;
                listPaciente[index].Direccion = txtDireccion.Text;
                listPaciente[index].Telefono = txtTelefono.Text;
                MostrarLista();
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            string curItem = lstPacientes.SelectedItem.ToString();
            int index = lstPacientes.FindString(curItem);
            Paciente nuevoPaciente = new Paciente
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };
            listPaciente.Insert(index + 1, nuevoPaciente);
            MostrarLista();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }
    }
}
