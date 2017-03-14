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
    public partial class Sucursales : Form
    {
        private SqlCommand cmd;
        private SqlConnection c;
        private SqlDataAdapter data;
        private DataTable dt;
        private bool abrirConex;

        public Sucursales()
        {
            InitializeComponent();
            c = new SqlConnection("Data Source=DESKTOP-O5C197G;Initial Catalog=Paqueteria;Integrated Security=True");
            timeSucursal1.Format = DateTimePickerFormat.Time;
            timeSucursal1.ShowUpDown = true;
            timeSucursal2.Format = DateTimePickerFormat.Time;
            timeSucursal2.ShowUpDown = true;
            actualizaDatagrid();
            actualizaCombos();
        }

        private void actualizaCombos()
        {
            actualizarComboSuc();
            actualizarComboEdos();
        }

        private void actualizarComboSuc()
        {
            abrirConex = false;
            try
            {
                dt = new DataTable();
                c.Open();
                abrirConex = true;
                string query = "SELECT IdCiudad, Nombre FROM Administracion.Ciudades ORDER BY Nombre ASC";

                cmd = new SqlCommand(query, c);
                data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                c.Close();
                comboCd_Suc.DisplayMember = "Nombre";
                comboCd_Suc.ValueMember = "IdCiudad";
                comboCd_Suc.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (abrirConex == true)
                    c.Close();
            }
        }

        private void actualizaDatagrid()
        {
            llenarDataGrid("SELECT * from Administracion.Sucursales", dataGridView1);
            llenarDataGrid("SELECT * from Administracion.Estados", dataGridView2);
            llenarDataGrid("SELECT * FROM Administracion.Ciudades", dataGridView3);
        }

        private void actualizarComboEdos()
        {
            DataTable dt = new DataTable();
            c.Open();
            string query = "SELECT IdEstado, Nombre FROM Administracion.Estados ORDER BY Nombre ASC";

            SqlCommand cmd = new SqlCommand(query, c);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            c.Close();
            comboSucEdo.DisplayMember = "Nombre";
            comboSucEdo.ValueMember = "IdEstado";
            comboSucEdo.DataSource = dt;
        }

        private void bInsertSuc_Click(object sender, EventArgs e)
        {
            if (textBoxSuc.Text != "" && textBoxTel_Suc.Text != "" && textBoxDir_Suc.Text != "" && timeSucursal1.Text != "" && timeSucursal2.Text != "" && comboCd_Suc.SelectedValue != null)
            {
                try
                {
                    String valor = comboCd_Suc.SelectedValue.ToString();
                    c.Open();
                    cmd = new SqlCommand("INSERT INTO Administracion.Sucursales (IdCiudad, nombre, direccion, telefono, horaApertura, horaCierre) VALUES('" + Convert.ToInt32(valor) + "'" + "," + "'" + textBoxSuc.Text + "'" + "," + "'" + textBoxDir_Suc.Text + "'" + "," + "'" + textBoxTel_Suc.Text + "'" + "," + "'" + timeSucursal1.Text + "'" + "," + "'" + timeSucursal2.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    actualizaCombos();
                    actualizaDatagrid();
                    MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBoxSuc.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.Close();
                }
            }
            else
                MessageBox.Show("Error: LLene todos los campos");
        }

        private void llenarDataGrid(String qry, DataGridView dataG)
        {
            abrirConex = false;
            try
            {
                c.Open();
                abrirConex = true;
                string query = qry;//"SELECT * from Envios.Envios";
                cmd = new SqlCommand(query, c);
                data = new SqlDataAdapter(cmd);
                dt = new DataTable();
                data.Fill(dt);
                dataG.DataSource = dt;
                c.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (abrirConex == true)
                    c.Close();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSuc.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboCd_Suc.SelectedValue = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDir_Suc.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxTel_Suc.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            timeSucursal1.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            timeSucursal2.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void buttDelSuc_Click(object sender, EventArgs e)
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
                        cmd = new SqlCommand("DELETE FROM Administracion.Sucursales WHERE IdSucursal=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDatagrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK);
                        textBoxCd.Text = "";
                        actualizarComboSuc();
                    }
                    else
                        MessageBox.Show("Seleccione una Sucursal de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona una Sucursal de la lista");
        }

        private void buttUpdSuc_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView1.CurrentRow != null)
            {
                String id = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (textBoxSuc.Text != "" && textBoxTel_Suc.Text != "" && textBoxDir_Suc.Text != "" && timeSucursal1.Text != "" && timeSucursal2.Text != "")
                    {
                        if (comboCd_Suc.SelectedItem != null)
                        {
                            try
                            {
                                String valor = comboCd_Suc.SelectedValue.ToString();
                                c.Open();
                                abrirConex = true;
                                cmd = new SqlCommand("UPDATE Administracion.Sucursales SET IdCiudad='" + Convert.ToInt32(valor) + "'" + ", " + "nombre='" + textBoxSuc.Text + "'" + ", " + "direccion='" + textBoxDir_Suc.Text + "'" + ", " + "telefono='" + textBoxTel_Suc.Text + "'" + ", " + "horaApertura='" + timeSucursal1.Text + "'" + ", " + "horaCierre='" + timeSucursal2.Text + "'" + " WHERE IdSucursal=" + id, c);
                                cmd.ExecuteNonQuery();
                                c.Close();
                                actualizaDatagrid();
                                MessageBox.Show("modificación correcta", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                actualizaCombos();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if(abrirConex == true)
                                    c.Close();
                            }
                        }
                        else
                            MessageBox.Show("Error: Combobox de Ciudad esta Vacio");
                    }
                    else
                    {
                        MessageBox.Show("Error: Todos los campos son requeridos, introduzca valores");
                        textBoxEdo.Focus();
                    }
                }
                else
                    MessageBox.Show("Seleccione un estado");
            }
            else
                MessageBox.Show("Seleccione un Estado de la lista");
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxEdo.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void buttInsEdo_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (textBoxEdo.Text != "")
            {
                try
                {
                    c.Open();
                    abrirConex = true;
                    cmd = new SqlCommand("INSERT INTO Administracion.Estados (Nombre) VALUES('" + textBoxEdo.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    actualizaDatagrid();
                    MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBoxEdo.Text = "";
                    actualizaCombos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                    if(abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Campo vacio,Introduzca un Estado");
        }

        private void buttDelEdo_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView2.CurrentRow != null)
            {
                try
                {
                    String id = this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
                    if (id != "")
                    {
                        c.Open();
                        abrirConex = true;
                        cmd = new SqlCommand("DELETE FROM Administracion.Estados WHERE IdEstado=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDatagrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBoxEdo.Text = "";
                        actualizaCombos();
                    }
                    else
                        MessageBox.Show("Seleccione un Estado de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona un Estado de la lista");
        }

        private void buttUpdEdo_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView2.CurrentRow != null)
            {
                String id = this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (textBoxEdo.Text != null)
                    {
                        try
                        {
                            c.Open();
                            abrirConex = true;
                            cmd = new SqlCommand("UPDATE Administracion.Estados SET Nombre='" + textBoxEdo.Text + "'" + " WHERE IdEstado=" + id, c);
                            cmd.ExecuteNonQuery();
                            c.Close();
                            actualizaDatagrid();
                            MessageBox.Show("modificación correcta", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            actualizaCombos();
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
                        MessageBox.Show("Error: Campo Estado Vacio");
                        textBoxEdo.Focus();
                    }
                }
                else
                    MessageBox.Show("Seleccione un estado");
            }
            else
                MessageBox.Show("Seleccione un Estado del dataGrid");
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxCd.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            comboSucEdo.SelectedValue = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttInsCd_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (textBoxCd.Text != "")
            {
                if (comboSucEdo.SelectedItem != null)
                {
                    try
                    {
                        String valor = comboSucEdo.SelectedValue.ToString();
                        c.Open();
                        abrirConex = true;
                        abrirConex = true;
                        cmd = new SqlCommand("INSERT INTO Administracion.Ciudades (Nombre, IdEstado) VALUES('" + textBoxCd.Text + "', '" + Convert.ToInt32(valor) + "')", c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDatagrid();
                        MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBoxCd.Text = "";
                        actualizaCombos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                        if(abrirConex == true)
                            c.Close();
                    }
                }
                else
                    MessageBox.Show("Seleccione un Estado del combo");
            }
            else
                MessageBox.Show("Campo vacio,Introduzca un Estado");
        }

        private void buttDelCd_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView3.CurrentRow != null)
            {
                try
                {
                    String id = this.dataGridView3.Rows[this.dataGridView3.CurrentRow.Index].Cells[0].Value.ToString();
                    if (id != "")
                    {
                        c.Open();
                        abrirConex = true;
                        cmd = new SqlCommand("DELETE FROM Administracion.Ciudades WHERE IdCiudad=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDatagrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK);
                        textBoxCd.Text = "";
                        actualizaCombos();
                    }
                    else
                        MessageBox.Show("Seleccione una Ciudad de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona un Estado de la lista");
        }

        private void buttUpdCd_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView3.CurrentRow != null)
            {
                String id = this.dataGridView3.Rows[this.dataGridView3.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (textBoxCd.Text != null)
                    {
                        if (comboSucEdo.SelectedItem != null)
                        {
                            try
                            {
                                String valor = comboSucEdo.SelectedValue.ToString();
                                c.Open();
                                abrirConex = true;
                                cmd = new SqlCommand("UPDATE Administracion.Ciudades SET Nombre='" + textBoxCd.Text + "'" + ", " + "IdEstado='" + Convert.ToInt32(valor) + "'" + " WHERE IdCiudad=" + id, c);
                                cmd.ExecuteNonQuery();
                                c.Close();
                                actualizaDatagrid();
                                MessageBox.Show("modificación correcta", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                actualizaCombos();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if(abrirConex == true)
                                    c.Close();
                            }
                        }
                        else
                            MessageBox.Show("Error: Combobox de Estado esta Vacio");
                    }
                    else
                    {
                        MessageBox.Show("Error: Campo Ciudad Vacio");
                        textBoxEdo.Focus();
                    }
                }
                else
                    MessageBox.Show("Seleccione un estado");
            }
            else
                MessageBox.Show("Seleccione un Estado de la lista");
        }
    }
}
