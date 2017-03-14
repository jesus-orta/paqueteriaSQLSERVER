using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace paqueteriaSQLSERVER
{
    public partial class Clientes : Form
    {
        private SqlCommand cmd;
        private SqlConnection c;
        private SqlDataAdapter data;
        private DataTable dt;
        private bool abrirConex;

        public Clientes()
        {
            InitializeComponent();
            c = new SqlConnection("Data Source=DESKTOP-O5C197G;Initial Catalog=Paqueteria;Integrated Security=True");
            actualizarDataGrid();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void actualizarDataGrid()
        {
            String qry2 = "Select * from Administracion.Clientes";
            llenarDataGrid(qry2, dataGridView1);
        }

        private void llenarDataGrid(String query, DataGridView dataG)
        {
            abrirConex = false;
            try
            {
                c.Open();
                abrirConex = true;
                cmd = new SqlCommand(query, c);
                data = new SqlDataAdapter(cmd);
                dt = new DataTable();
                data.Fill(dt);
                dataG.DataSource = dt;
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (abrirConex == true)
                    c.Close();
            }
        }

        private void buttonInsClie_Click(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tB_Nombre_Clie.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tB_Ap_Clie.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tB_Am_Clie.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tB_dir_Clie.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tB_Cp_Clie.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tB_tel_Clie.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tB_cel_Clie.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void buttonInsClie_Click_1(object sender, EventArgs e)
        {
            abrirConex = false;
            if (tB_Nombre_Clie.Text != "" && tB_Ap_Clie.Text != "" && tB_Am_Clie.Text != "" && tB_dir_Clie.Text != "" && tB_Cp_Clie.Text != "" && tB_tel_Clie.Text != "" && tB_cel_Clie.Text != "")
            {
                try
                {
                    c.Open();
                    abrirConex = true;
                    cmd = new SqlCommand("INSERT INTO Administracion.Clientes (Nombre, ApellidoPaterno, ApellidoMaterno, Direccion, CP, telefono, celular) VALUES('" + tB_Nombre_Clie.Text + "'" + "," + "'" + tB_Ap_Clie.Text + "'" + "," + "'" + tB_Am_Clie.Text + "'" + "," + "'" + tB_dir_Clie.Text + "'" + "," + "'" + Convert.ToInt32(tB_Cp_Clie.Text) + "'" + "," + "'" + tB_tel_Clie.Text + "'" + ", " + "'" + tB_cel_Clie.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    actualizarDataGrid();
                    MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tB_Nombre_Clie.Text = "";
                    tB_Ap_Clie.Text = "";
                    tB_Am_Clie.Text = "";
                    tB_dir_Clie.Text = "";
                    tB_Cp_Clie.Text = "";
                    tB_tel_Clie.Text = "";
                    tB_cel_Clie.Text = "";
                    tB_Nombre_Clie.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Error: LLene todos los campos");
        }

        private void buttonDelClie_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView1.CurrentRow != null)
            {
                try
                {
                    String id = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    if (id != "")
                    {
                        c.Open();
                        abrirConex = true;
                        cmd = new SqlCommand("DELETE FROM Administracion.Clientes WHERE IdCliente=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizarDataGrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK);
                        tB_Nombre_Clie.Text = "";
                        tB_Ap_Clie.Text = "";
                        tB_Am_Clie.Text = "";
                        tB_dir_Clie.Text = "";
                        tB_Cp_Clie.Text = "";
                        tB_tel_Clie.Text = "";
                        tB_cel_Clie.Text = "";
                        tB_Nombre_Clie.Focus();
                    }
                    else
                        MessageBox.Show("Seleccione un Cliente de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(abrirConex ==true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona un Cliente de la lista");
        }

        private void buttonUpdClie_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView1.CurrentRow != null)
            {
                String id = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (tB_Nombre_Clie.Text != "" && tB_Ap_Clie.Text != "" && tB_Am_Clie.Text != "" && tB_dir_Clie.Text != "" && tB_Cp_Clie.Text != "" && tB_tel_Clie.Text != "" && tB_cel_Clie.Text != "")
                    {
                        try
                        {
                            c.Open();
                            cmd = new SqlCommand("UPDATE Administracion.Clientes SET Nombre='" + tB_Nombre_Clie.Text + "'" + ", " + "ApellidoPaterno='" + tB_Ap_Clie.Text + "'" + ", " + "ApellidoMaterno='" + tB_Am_Clie.Text + "'" + ", " + "Direccion='" + tB_dir_Clie.Text + "'" + ", " + "CP='" + tB_Cp_Clie.Text + "'" + ", " + "telefono='" + tB_tel_Clie.Text + "'" + ", " + "celular='" + tB_cel_Clie.Text + "'" + " WHERE IdCliente=" + id, c);
                            cmd.ExecuteNonQuery();
                            c.Close();
                            actualizarDataGrid();
                            MessageBox.Show("modificación correcta", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if(abrirConex == true)
                                c.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Todos los campos son requeridos, introduzca valores");
                    }
                }
                else
                    MessageBox.Show("Seleccione un Cliente");
            }
            else
                MessageBox.Show("Seleccione un Cliente de la lista");
        }
    }
}
