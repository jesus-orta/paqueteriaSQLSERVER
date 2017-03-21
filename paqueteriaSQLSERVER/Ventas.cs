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
    public partial class Ventas : Form
    {
        private ConexionSQL conexion;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            conexion = new ConexionSQL();
            this.actualizaVentasGrid();
            this.actualizaComboBox();
            this.comboBoxDetalleVenta();
            this.actualizaDataGridDetalle();
        }

        //ventas
        private void actualizaVentasGrid()
        {
            conexion.actualizaDataGridView("Select * From Ventas.Ventas", this.dataGridVentas);
        }

        private void buttonInsVenta_Click(object sender, EventArgs e)
        {
            try
            {
                String idSuc = comboBoxSuc_venta.SelectedValue.ToString();
                string query = "INSERT INTO Ventas.Ventas(IdSucursal, total)";
                query += "VALUES ('"+Convert.ToInt32(idSuc) + "', '" + textBoxTotal.Text + "')";

                conexion.EjecutaSQL(query);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error en la insercion ");

            }
            actualizaVentasGrid();
        }

        private void actualizaComboBox()
        {
            conexion.actualizarComboBox("SELECT * FROM Administracion.Sucursales", "nombre", "IdSucursal", 
                comboBoxSuc_venta);
        }

        private void dataGridVentas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxTotal.Text = this.dataGridVentas.CurrentRow.Cells[3].Value.ToString();
                comboBoxSuc_venta.SelectedValue = this.dataGridVentas.CurrentRow.Cells[1].Value.ToString();
                dateTimePickerventa.Text = this.dataGridVentas.CurrentRow.Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void buttonElimVenta_Click(object sender, EventArgs e)
        {
            try
            {
                String idVenta = this.dataGridVentas.Rows[this.dataGridVentas.CurrentRow.Index].Cells[0].Value.ToString();
                string query = "DELETE FROM Ventas.Ventas WHERE IdVenta =" + Convert.ToInt32(idVenta);

                conexion.EjecutaSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la eliminación: "+ex.Message);

            }
            actualizaVentasGrid();
        }

        private void buttonActVenta_Click(object sender, EventArgs e)
        {
            try
            {
                String idSuc = comboBoxSuc_venta.SelectedValue.ToString();
                String idVenta = this.dataGridVentas.Rows[this.dataGridVentas.CurrentRow.Index].Cells[0].Value.ToString();
                string query = "UPDATE Ventas.Ventas SET IdSucursal= '" + Convert.ToInt32(idSuc) + "', total='" + textBoxTotal.Text + "'" + "WHERE IdVenta =" +idVenta;
                conexion.EjecutaSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Modificación: " + ex.Message);

            }
            actualizaVentasGrid();
        }

        //Detalle de Venta
        private void actualizaDataGridDetalle()
        {
            conexion.actualizaDataGridView("Select * From Ventas.DetalleVenta", this.dataGridDetVenta);
        }

        private void actualizaComboEnvios()
        {
            conexion.actualizarComboBox("SELECT * FROM Envios.Envios", "IdEnvio", "IdEnvio",
               comboBoxIdEnvio_vnta);
        }

        private void actualizaComboVenta()
        {
            conexion.actualizarComboBox("SELECT * FROM Ventas.Ventas", "IdVenta", "IdVenta",
               comboBoxIdVnta_Vnta);
        }

        private void comboBoxDetalleVenta()
        {
            actualizaComboEnvios();
            actualizaComboVenta();
        }

        private void InsertarDetalleV_Click(object sender, EventArgs e)
        {
            try
            {
                String idEnvio = comboBoxIdEnvio_vnta.SelectedValue.ToString();
                String idVenta = comboBoxIdVnta_Vnta.SelectedValue.ToString();

                string query = "INSERT INTO Ventas.DetalleVenta(IdVenta,IdEnvio,  subtotal)";
                query += "VALUES ('" + Convert.ToInt32(idVenta) +"' , '"+ Convert.ToInt32(idEnvio) + "', '" + textBoxSubTotal.Text + "')";

                conexion.EjecutaSQL(query);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error en la insercion :" + exc.Message);

            }
            actualizaDataGridDetalle();
        }

        private void dataGridDetVenta_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxSubTotal.Text = this.dataGridDetVenta.CurrentRow.Cells[2].Value.ToString();
                comboBoxIdVnta_Vnta.SelectedValue = this.dataGridDetVenta.CurrentRow.Cells[0].Value.ToString();
                comboBoxIdEnvio_vnta.SelectedValue = this.dataGridDetVenta.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void EliminarDetalleV_Click(object sender, EventArgs e)
        {
            try
            {
                String idEnvio = this.dataGridDetVenta.Rows[this.dataGridDetVenta.CurrentRow.Index].Cells[1].Value.ToString();
                string query = "DELETE FROM Ventas.DetalleVenta WHERE IdEnvio =" + Convert.ToInt32(idEnvio);

                conexion.EjecutaSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la eliminación: " + ex.Message);

            }
            actualizaDataGridDetalle();
        }

        private void ActualizarDetalleV_Click(object sender, EventArgs e)
        {
            try
            {
                String idVenta = comboBoxIdVnta_Vnta.SelectedValue.ToString();
                String idEnvio2 = this.dataGridDetVenta.Rows[this.dataGridDetVenta.CurrentRow.Index].Cells[1].Value.ToString();
                string query = "UPDATE Ventas.DetalleVenta SET IdVenta= '" + Convert.ToInt32(idVenta) + "', subtotal='" + textBoxSubTotal.Text + "'" + "WHERE IdEnvio =" + idEnvio2;
                conexion.EjecutaSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Modificación: " + ex.Message);

            }
            actualizaDataGridDetalle();
        }
    }
}
