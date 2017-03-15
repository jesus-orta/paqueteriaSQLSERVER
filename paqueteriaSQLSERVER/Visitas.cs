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
    public partial class Visitas : Form
    {

        private ConexionSQL conexion;       
        public Visitas()
        {
            InitializeComponent();
        }

        private void Visitas_Load(object sender, EventArgs e)
        {
            conexion = new ConexionSQL();
            ActualizaDAtaGrid();

        }

        private void ActualizaDAtaGrid()
        {
            string query = "Select * From Envios.Visitas";
            conexion.actualizaDataGridView(query, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch(Exception exc)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Envios.Visitas(IdEnvio, estatus) Values (";
            try
            {
                query += "'" + textBox1.Text +"' , '"+comboBox1.Text+"')" ;
                conexion.EjecutaSQL(query);
            }
            catch(Exception ex)
            {

            }
            ActualizaDAtaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "delete Envios.Visitas ";
            try
            {
                DateTime d = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                query += "where CONVERT(VARCHAR(35), Fecha, 126) LIKE '%" + d.ToString("yyyy-MM-dd HH:mm:ss").Insert(10, "%").Remove(11, 1) + "%'"; ;
                conexion.EjecutaSQL(query);                
            }
            catch (Exception ex)
            {

            }
            ActualizaDAtaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "update Envios.Visitas SET IdEnvio = '";
            try
            {
                DateTime d = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                query += textBox1.Text + "', estatus = '" + comboBox1.Text + "'";
                query += "where CONVERT(VARCHAR(35), Fecha, 126) LIKE '%" + d.ToString("yyyy-MM-dd HH:mm:ss").Insert(10,"%").Remove(11,1) + "%'";
                conexion.EjecutaSQL(query);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            ActualizaDAtaGrid();

        }
    }
}