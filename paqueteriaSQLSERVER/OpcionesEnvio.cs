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
            try
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
            }catch(Exception exc) { }

        }

        private void G1_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Envios.";
                switch (Tabla)
                {
                    case 1:
                        query += "Historial SET ";
                        query += "IdEnvio = '" + IdEnvio.Text + "' , IdCiudadActual = '" + Ciudad.Text + "' , accion = '" + Accion.Text + "' , ";
                        query += "destino = ' " + Destino.Text + "' ";
                        query += "WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "' AND  CONVERT(VARCHAR(35), Fecha, 126) LIKE '" + Fecha() + "'";
                        break;
                    case 2:
                        query += "EnviosEntregados SET ";
                        query += "IdEnvio = '" + IdEnvio.Text + "' ";
                        query += "WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "'";

                        break;
                }
                conexion.EjecutaSQL(query);
                ActualizaGrid();
            }catch(Exception ex) { }

        }


        private void G1_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE ";
                switch (Tabla)
                {
                    case 1:
                        query += "Envios.Historial WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "' AND  CONVERT(VARCHAR(35), Fecha, 126) LIKE '" + Fecha() + "'";
                        break;
                    case 2:
                        query += "Envios.EnviosEntregados WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "'";
                        break;
                }
                conexion.EjecutaSQL(query);
                ActualizaGrid();
            }catch(Exception ex) { }
        }

        private void Insertar_Grupo2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Envios.";
                switch (Tabla)
                {
                    case 3:
                        query += "EnviosARegresar (IdEnvio, IdCliente, Direccion) VALUES ( '";
                        query += IdEnvio2.Text + "' , '" + Cliente.Text + "' ,'" + Direccion.Text + "')";
                        break;
                    case 4:
                        query += "EnviosAEntregar (IdEnvio, direccion) VALUES ('";
                        query += IdEnvio2.Text + "' , '" + Direccion + "')";
                        break;
                }
                conexion.EjecutaSQL(query);
                ActualizaGrid();
            }
            catch (Exception ex) { }
        }
        

        private void Actualizar_Grupo2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Envios. ";
                switch (Tabla)
                {
                    case 3:
                        query += "EnviosARegresar SET IdEnvio = '" + IdEnvio2.Text + "' , IdCliente = '" + Cliente.Text + "', Direccion = '" + Direccion.Text + "' ";
                        break;
                    case 4:
                        query += "EnviosAEntregar SET IdEnvio = '" + IdEnvio2.Text + "' , Direccion = '" + Direccion.Text + "' ";
                        break;
                }
                query += "WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "'";
                conexion.EjecutaSQL(query);
                ActualizaGrid();
            }
            catch (Exception exc) { }

        }

        private void Eliminar_Grupo2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE ";
                switch (Tabla)
                {
                    case 3:
                        query += "Envios.EnviosARegresar WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "'";
                        break;
                    case 4:
                        query += "Envios.EnviosARepartir WHERE IdEnvio = '" + GridDatos.CurrentRow.Cells[0].Value.ToString() + "'";
                        break;
                }
                conexion.EjecutaSQL(query);
                ActualizaGrid();
            }
            catch(Exception ex)
            {

            }
        }


        private string Fecha()
        {
             DateTime d = Convert.ToDateTime(GridDatos.CurrentRow.Cells[1].Value.ToString());
            return "%" + d.ToString("yyyy-MM-dd HH:mm:ss").Insert(10, "%").Remove(11, 1) + "%";
        }

        // 1 = Historial, 2 = Envios Entregados, 3 = Envios a Regresar , 4 = Envios a Repartir
        /// <summary>
        /// Recupera Datos de un Renglon Seleccionado en  el DatagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void click_data(object sender, EventArgs e)
        {
            try
            {
                this.idEnvio = IdEnvio.Text = IdEnvio2.Text = GridDatos.CurrentRow.Cells[0].Value.ToString();
                switch (Tabla)
                {
                    case 1:
                        Ciudad.Text = GridDatos.CurrentRow.Cells[2].Value.ToString();
                        Accion.Text = GridDatos.CurrentRow.Cells[3].Value.ToString();
                        Destino.Text = GridDatos.CurrentRow.Cells[4].Value.ToString();
                    break;
                    case 3:
                        Cliente.Text = GridDatos.CurrentRow.Cells[2].Value.ToString();
                        Direccion.Text = GridDatos.CurrentRow.Cells[3].Value.ToString();
                    break;
                    case 4:
                        Direccion.Text = GridDatos.CurrentRow.Cells[3].Value.ToString();
                    break;
                }

            }
            catch
            {

            }

        }
    }
}
