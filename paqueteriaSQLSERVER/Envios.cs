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
    public partial class Envios : Form
    {
        private ConexionSQL conexion;
        public Envios()
        {
            InitializeComponent();
        }

        private void Envios_Load(object sender, EventArgs e)
        {
            conexion = new ConexionSQL();
            this.ActualizaEnviosGrid();
        }
        
       
        private void EnviosDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            // 8 3 1 2 4 6 5 7
            try
            {
                this.ClienteCombo.Text = EnviosDataGrid.CurrentRow.Cells[8].Value.ToString();
                this.CiudadCombo.Text = EnviosDataGrid.CurrentRow.Cells[3].Value.ToString();
                this.FechaRecibido.Text = EnviosDataGrid.CurrentRow.Cells[1].Value.ToString();
                this.FechaEntrega.Text = EnviosDataGrid.CurrentRow.Cells[2].Value.ToString();
                this.Destinatario.Text = EnviosDataGrid.CurrentRow.Cells[4].Value.ToString();
                this.Telefono.Text = EnviosDataGrid.CurrentRow.Cells[6].Value.ToString();
                this.Direccion.Text = EnviosDataGrid.CurrentRow.Cells[5].Value.ToString();
                this.CP.Text = EnviosDataGrid.CurrentRow.Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Envios.Envios( IdCiudadEnviar, NombreDestino, Direccion, Telefono, CP, IdClienteEmisor)";
                query += "VALUES ('" + CiudadCombo.Text + "', '" + Destinatario.Text + "','"+Direccion.Text+"',";
                query += "'"+Telefono.Text+"', '"+CP.Text+"', '"+ClienteCombo.Text+"')";

                conexion.EjecutaSQL(query);


            }
            catch(Exception exc)
            {
                MessageBox.Show("Error en la insercion ");

            }
            ActualizaEnviosGrid();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = EnviosDataGrid.CurrentRow.Cells[0].Value.ToString();
                conexion.EjecutaSQL("delete from Envios.Envios where IdEnvio = '" + id + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Borrar el Envio ");
            }
            this.ActualizaEnviosGrid();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                string id = EnviosDataGrid.CurrentRow.Cells[0].Value.ToString();
                string query = "update Envios.Envios SET idCiudadEnviar = '" + CiudadCombo.Text + "', NombreDestino = '"+Destinatario.Text+"',";
                query += "Direccion = '"+Direccion.Text+"', Telefono = '"+Telefono.Text+"', CP = '"+CP.Text+"', IdClienteEmisor = '"+ClienteCombo.Text+"'";
                query += " where IdEnvio = '" + id + "'";                
                conexion.EjecutaSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Borrar al Actualizar ");
            }
            ActualizaEnviosGrid();         
        }

        private void ActualizaEnviosGrid()
        {
            conexion.actualizaDataGridView("Select * From Envios.Envios", this.EnviosDataGrid);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpcionesEnvio en = new OpcionesEnvio(1);
            en.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpcionesEnvio en = new OpcionesEnvio(2);
            en.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpcionesEnvio en = new OpcionesEnvio(4);
            en.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpcionesEnvio en = new OpcionesEnvio(3);
            en.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Visitas v = new Visitas();
            v.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
