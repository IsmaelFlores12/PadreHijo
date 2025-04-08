using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadreHijo
{
    public partial class Form1 : Form
    {
        Acciones acciones = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DGdatos.DataSource = null;
            DGdatos.DataSource = acciones.mostrarP();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (acciones.EliminarJuego(Convert.ToInt32(txbEliminar.Text)))
                MessageBox.Show("Eliminada con exito");
            else
                MessageBox.Show("Fallo");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (acciones.InsertarJuego(txbGenero.Text, Convert.ToDouble(txbPrecio), txbModelo.Text, Convert.ToInt32(txbAlmacenamiento), Convert.ToInt32(txbAño)))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("fallo algo al agregar");
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (acciones.actualizar(txbGenero.Text, Convert.ToDouble(txbPrecio), txbModelo.Text, Convert.ToInt32(txbAlmacenamiento), Convert.ToInt32(txbAño)))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("fallo algo al agregar");
        }
    }
}
