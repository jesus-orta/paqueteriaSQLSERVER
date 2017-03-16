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
    public partial class Paquetes : Form
    {

        ConexionSQL conexion;
        public Paquetes()
        {
            InitializeComponent();
        }

        private void Paquetes_Load(object sender, EventArgs e)
        {
            conexion = new ConexionSQL();
        }

        private void ActualizaGrid()
        {
            string query = "SELECT * FROM Envios.Paquetes";
            conexion.actualizaDataGridView(query, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Envios.Paquetes(IdEnvio, descripcion, volumen, peso, costo) VALUES ('";
            query += IdEnvio.Text + "', '" + Descripcion.Text + "' , '" + Volumen.Text + "' , '";
            query += Peso.Text + "' , '" + Costo.Text + "')";
            try
            {
                conexion.EjecutaSQL(query);
            }
            catch (Exception exc)
            {

            }
            ActualizaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE Envios.Paquetes";
            try
            {
                query += " WHERE IdPaquete = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                conexion.EjecutaSQL(query);
            }
            catch(Exception ex)
            {

            }
            ActualizaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Envios.Paquetes SET ";
            try
            {
                query += "IdEnvio = '"+IdEnvio.Text +"' ,";
                query += "descripcion = '" + Descripcion.Text + "' ,";
                query += "volumen = '" + Volumen.Text + "' ,";
                query += "peso = '"+Peso.Text+"', costo = '"+Costo.Text + "' ";
                query += " WHERE IdPaquete = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                conexion.EjecutaSQL(query);
            }
            catch (Exception ex)
            {

            }
            ActualizaGrid();

        }

        private void Data_Click(object sender, EventArgs e)
        {
            try
            {
                IdEnvio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Descripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Volumen.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Peso.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Costo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            }
            catch(Exception ex)
            {

            }
        }
    }
}
