using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paqueteriaSQLSERVER
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonSucursal_Click(object sender, EventArgs e)
        {
            Sucursales s = new Sucursales();
            s.ShowDialog();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.ShowDialog();
        }

        private void buttonEnvios_Click(object sender, EventArgs e)
        {
            Envios envios = new Envios();
            envios.ShowDialog();
        }

        private void buttonCond_Click(object sender, EventArgs e)
        {
            Conductores cond = new Conductores();
            cond.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }
    }
}
