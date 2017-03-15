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
    public partial class OpcionesEnvio : Form
    {

        private ConexionSQL conexion;

        private string idEnvio;

        private int Tabla; // 1 = Historial, 2 = Envios Entregados, 3 = Envios a Regresar , 4 = Envios a Repartir

        public OpcionesEnvio()
        {
            InitializeComponent();
        }

        public OpcionesEnvio(int op)
        {
            InitializeComponent();
            Tabla = op;
        }

        private void OpcionesEnvio_Load(object sender, EventArgs e)
        {
            conexion = new ConexionSQL();
            switch(Tabla)
            {
                case 1:
                    Grupo1.Visible = true;
                    Grupo2.Visible = false;
                    Grupo1.Text = "Historial de Envios";    
                break;

                case 2:
                    Grupo1.Visible = true;
                    Grupo2.Visible = false;
                    Grupo1.Text = "Envios Entregados";
                    label2.Visible = label3.Visible = label4.Visible = false;
                    Ciudad.Visible = Destino.Visible = false;
                    Accion.Visible = false;
                break;

                case 3:
                    Grupo1.Visible = false;
                    Grupo2.Visible = true;
                    Grupo2.Text = "Envios a Regresar";
                break;

                case 4:
                    Grupo1.Visible = false;
                    Grupo2.Visible = true;
                    label5.Visible = false;
                    Cliente.Visible = false;
                    Grupo2.Text = "Envios a Entregar";
                    break;
            }
            ActualizaGrid();
        }

        // 1 = Historial, 2 = Envios Entregados, 3 = Envios a Regresar , 4 = Envios a Repartir
        private void ActualizaGrid()
        {
            switch(Tabla)
            {
                case 1:
                    conexion.actualizaDataGridView("Select* From Envios.Historial", GridDatos);
                break;
                case 2:
                    conexion.actualizaDataGridView("Select* From Envios.EnviosEntregados", GridDatos);
                break;
                case 3:
                    conexion.actualizaDataGridView("Select* From Envios.EnviosARegresar", GridDatos);
                break;
                case 4:
                    conexion.actualizaDataGridView("Select* From Envios.EnviosARepartir", GridDatos);
                break;
            }
        }

        private void G1_Insertar_Click(object sender, EventArgs e)
        {
            string query = "insert into ";
            switch (Tabla)
            {
                case 1:
                    query += "Envios.Historial(IdEnvio, IdCiudadActual, accion, destino) VALUES ";
                    query += "(";
                    query += "'" + IdEnvio.Text + "', '" + Ciudad.Text + "', '" + Accion.Text + "', '" + Destino.Text + "'";
                    query += ")";
                    
                break;
                case 2:
                    query += "Envios.EnviosEntregados (IdEnvio) VALUES ('" + IdEnvio.Text + "')";
                break;
            }
            conexion.EjecutaSQL(query);
            ActualizaGrid();

        }

        private void G1_Actualizar_Click(object sender, EventArgs e)
        {
            switch (Tabla)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            ActualizaGrid();
        }

        private void G1_Eliminar_Click(object sender, EventArgs e)
        {
            switch (Tabla)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            ActualizaGrid();
        }

        private void Insertar_Grupo2_Click(object sender, EventArgs e)
        {
            switch (Tabla)
            {
                case 3:
                    break;
                case 4:
                    break;
            }
            ActualizaGrid();
        }

        private void Actualizar_Grupo2_Click(object sender, EventArgs e)
        {
            switch (Tabla)
            {
                case 3:
                    break;
                case 4:
                    break;
            }
            ActualizaGrid();

        }

        private void Eliminar_Grupo2_Click(object sender, EventArgs e)
        {
            switch (Tabla)
            {
                case 3:
                    break;
                case 4:
                    break;
            }
            ActualizaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idEnvio = IdEnvio.Text = IdEnvio2.Text = GridDatos.CurrentRow.Cells[0].Value.ToString();
                switch(Tabla)
                {
                    case 1:

                    break;
                    case 2:
                    break;
                    case 3:
                    break;
                    case 4:
                    break;
                }

            }
            catch
            {

            }
        }
    }
}
