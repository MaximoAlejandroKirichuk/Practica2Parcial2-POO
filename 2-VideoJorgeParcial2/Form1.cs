using _2_VideoJorgeParcial2.Exepciones;
using _2_VideoJorgeParcial2.Intreface;
using _2_VideoJorgeParcial2.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_VideoJorgeParcial2
{
    public partial class Form1 : Form
    {
        ListaCliente ListaCliente = new ListaCliente();
        ListaVehiculos ListaVehiculos = new ListaVehiculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            try
            {
                Cliente nuevoCliente = new Cliente(nombre,apellido);
                ListaCliente.Agregar(nuevoCliente);
                ActualizarLista();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }
        public void ActualizarLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaCliente.MostrarLista();
        }
        public void ActualizarLista2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ListaVehiculos.MostrarLista();

           
        }

        

        private void MostrarMensajeAlquiler(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void MostrarMensajeDevolucion(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string eleccion = comboBox1.SelectedItem.ToString();
                int idVehiculo = Convert.ToInt32(txtIdVehiculo.Text);
                string dominio = txtDominio.Text;
                string nombreVehiculo = txtNombreVehiculo.Text;
                string descripcion = txtDescripcion.Text;
                string tipoCombustible = comboBoxTipoCombustible.SelectedItem.ToString();
                if(eleccion == "Auto")
                {
                    return;
                }
                if(eleccion == "Moto")
                {
                    Moto moto = new Moto(true,idVehiculo,dominio,tipoCombustible,nombreVehiculo,descripcion);
                    ListaVehiculos.Agregar(moto);
                    ActualizarLista2();
                    moto.AlquilarVehiculo += MostrarMensajeAlquiler;
                    moto.DevolverVehiculo += MostrarMensajeDevolucion;
                    return;
                }
                throw new NoSeleccionadoExpection();
            }
            catch (NoSeleccionadoExpection ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al generar el vehiculo: " + ex.Message);
            }
        }

        

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView2.Columns[e.ColumnIndex].Name == "Disponible")
            {
                var vehiculo = (Vehiculo)dataGridView2.Rows[e.RowIndex].DataBoundItem;

                bool disponible = (bool)dataGridView2.Rows[e.RowIndex].Cells["Disponible"].Value;

                if (!disponible)
                {
                    vehiculo.Alquilar(); // dispara evento de alquiler
                }
                else
                {
                    vehiculo.Devolver(); // dispara evento de devolución
                }

                dataGridView2.Refresh();
            }
        }

        private void dataGridView2_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dataGridView2.IsCurrentCellDirty)
            {
                dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var vehiculos = ListaVehiculos.MostrarLista();
            dataGridView2.DataSource = vehiculos.Where(v => v.Disponible == true).ToList(); ;
        }
    }
}
