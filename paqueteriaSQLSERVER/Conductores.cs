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
    public partial class Conductores : Form
    {
        private SqlCommand cmd;
        private SqlConnection c;
        private SqlDataAdapter data;
        private DataTable dt;
        private bool abrirConex;

        public Conductores()
        {
            InitializeComponent();
            c = new SqlConnection("Data Source=.;Initial Catalog=Paqueteria;Integrated Security=True");
            actualizaDataGrid();
            actualizaCombos();
        }

        private void Conductores_Load(object sender, EventArgs e)
        {

        }

        private void actualizaDataGrid()
        {
            String qryCond = "SELECT * from Administracion.Conductores";
            String qryTipoC = "SELECT * FROM Administracion.TipoConductor";
            String qryUnidad = "SELECT * FROM Administracion.Vehiculos";
            llenaDatagrids(qryCond, dataGridView1);
            llenaDatagrids(qryTipoC, dataGridView2);
            llenaDatagrids(qryUnidad, dataGridView3);
        }

        private void llenaDatagrids(String query, DataGridView dataG)
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tB_Nom_Cond.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tB_Ap_Cond.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tB_Am_Cond.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tB_Dir_Cond.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tBTelCond.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tBCelCond.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tBLicCond.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboUniCond.SelectedValue = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboTipoCond.SelectedValue = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            tBTipoCond.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            tBDescCond.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            tBMatVeh.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            tBModVeh.Text = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
            tBMarcaVeh.Text = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void actualizaCombos()
        {
            actualizaComboUnidad();
            actualizaComboRepartidor();
        }

        private void actualizaComboUnidad()
        {
            DataTable dt = new DataTable();
            c.Open();
            string query = "SELECT IdUnidad, Matricula FROM Administracion.Vehiculos ORDER BY Matricula ASC";

            SqlCommand cmd = new SqlCommand(query, c);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            c.Close();
            comboUniCond.DisplayMember = "Matricula";
            comboUniCond.ValueMember = "IdUnidad";
            comboUniCond.DataSource = dt;
        }

        private void actualizaComboRepartidor()
        {
            DataTable dt = new DataTable();
            c.Open();
            string query = "SELECT IdTipoConductor, Tipo FROM Administracion.TipoConductor ORDER BY Tipo ASC";

            SqlCommand cmd = new SqlCommand(query, c);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            c.Close();
            comboTipoCond.DisplayMember = "Tipo";
            comboTipoCond.ValueMember = "IdTipoConductor";
            comboTipoCond.DataSource = dt;
        }

        private void buttonInsCond_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (tB_Nom_Cond.Text != "" && tB_Ap_Cond.Text != "" && tB_Am_Cond.Text != "" && tB_Dir_Cond.Text != "" && tBTelCond.Text != "" && tBCelCond.Text != "" && tBLicCond.Text != "")
            {
                if (comboTipoCond.SelectedItem != null && comboUniCond.SelectedItem != null)
                {
                    try
                    {
                        String valor = comboTipoCond.SelectedValue.ToString();
                        String valor2 = comboUniCond.SelectedValue.ToString();
                        c.Open();
                        abrirConex = true;
                        cmd = new SqlCommand("INSERT INTO Administracion.Conductores (Nombre, ApellidoPaterno, ApellidoMaterno, Direccion, Telefono, Celular, Licencia, IdUnidad, IdTipoConductor) VALUES('" + tB_Nom_Cond.Text + "'" + "," + "'" + tB_Ap_Cond.Text + "'" + "," + "'" + tB_Am_Cond.Text + "'" + "," + "'" + tB_Dir_Cond.Text + "'" + "," + "'" + tBTelCond.Text + "'" + "," + "'" + tBCelCond.Text + "'" + ", " + "'" + tBLicCond.Text + "'" + ", " + "'" + Convert.ToInt32(valor2) + "'" + ", " + "'" + Convert.ToInt32(valor) + "')", c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDataGrid();
                        MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        actualizaCombos();
                        tB_Nom_Cond.Text = "";
                        tB_Ap_Cond.Text = "";
                        tB_Am_Cond.Text = "";
                        tB_Dir_Cond.Text = "";
                        tBTelCond.Text = "";
                        tBCelCond.Text = "";
                        tBLicCond.Text = "";
                        tB_Nom_Cond.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if(abrirConex == true)
                            c.Close();
                    }
                }
                else
                    MessageBox.Show("Error: Seleccione valores de los comboBox");
            }
            else
                MessageBox.Show("Error: LLene todos los campos");
        }

        private void buttonDelCond_Click(object sender, EventArgs e)
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
                        cmd = new SqlCommand("DELETE FROM Administracion.Conductores WHERE IdConductor=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDataGrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK);
                        actualizaCombos();
                        tB_Nom_Cond.Text = "";
                        tB_Ap_Cond.Text = "";
                        tB_Am_Cond.Text = "";
                        tB_Dir_Cond.Text = "";
                        tBTelCond.Text = "";
                        tBCelCond.Text = "";
                        tBLicCond.Text = "";
                        tB_Nom_Cond.Focus();
                    }
                    else
                        MessageBox.Show("Seleccione un conductor de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona un conductor de la lista");
        }

        private void buttonModCond_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView1.CurrentRow != null)
            {
                String id = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (tB_Nom_Cond.Text != "" && tB_Ap_Cond.Text != "" && tB_Am_Cond.Text != "" && tB_Dir_Cond.Text != "" && tBTelCond.Text != "" && tBCelCond.Text != "" && tBLicCond.Text != "")
                    {
                        if (comboTipoCond.SelectedItem != null && comboUniCond.SelectedItem != null)
                        {
                            try
                            {
                                c.Open();
                                abrirConex = true;
                                cmd = new SqlCommand("UPDATE Administracion.Conductores SET Nombre='" + tB_Nom_Cond.Text + "'" + ", " + "ApellidoPaterno='" + tB_Ap_Cond.Text + "'" + ", " + "ApellidoMaterno='" + tB_Am_Cond.Text + "'" + ", " + "Direccion='" + tB_Dir_Cond.Text + "'" + ", " + "Telefono='" + tBTelCond.Text + "'" + ", " + "Celular='" + tBCelCond.Text + "'" + ", " + "Licencia='" + tBLicCond.Text + "'" + ", " + "IdUnidad='" + comboUniCond.SelectedValue + "'" + ", " + "IdTipoConductor='" + comboTipoCond.SelectedValue + "'" + " WHERE IdConductor=" + id, c);
                                cmd.ExecuteNonQuery();
                                c.Close();
                                actualizaDataGrid();
                                MessageBox.Show("modificación correcta", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                actualizaCombos();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if(abrirConex ==true)
                                    c.Close();
                            }
                        }
                        else
                            MessageBox.Show("Seleccione un valor en los comboBox");
                    }
                    else
                    {
                        MessageBox.Show("Error: Todos los campos son requeridos, introduzca valores");
                    }
                }
                else
                    MessageBox.Show("Seleccione un conductor");
            }
            else
                MessageBox.Show("Seleccione un Conductor de la lista");
        }

        private void buttonInsTipoC_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (tBTipoCond.Text != "" && tBDescCond.Text != "")
            {
                try
                {
                    c.Open();
                    abrirConex = true;
                    cmd = new SqlCommand("INSERT INTO Administracion.TipoConductor (Tipo, descripcion) VALUES('" + tBTipoCond.Text + "'" + "," + "'" + tBDescCond.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    actualizaDataGrid();
                    MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    actualizaCombos();
                    tBTipoCond.Text = "";
                    tBDescCond.Text = "";
                    tBTipoCond.Focus();
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

        private void buttonElimCond_Click(object sender, EventArgs e)
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
                        cmd = new SqlCommand("DELETE FROM Administracion.TipoConductor WHERE IdTipoConductor=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDataGrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK);
                        actualizaCombos();
                        tBTipoCond.Text = "";
                        tBDescCond.Text = "";
                        tBTipoCond.Focus();
                    }
                    else
                        MessageBox.Show("Seleccione un Tipo de conductor de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona un Tipo de conductor de la lista");
        }

        private void buttonModTipoC_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView2.CurrentRow != null)
            {
                String id = this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (tBTipoCond.Text != null && tBDescCond.Text != "")
                    {
                        try
                        {
                            c.Open();
                            abrirConex = true;
                            cmd = new SqlCommand("UPDATE Administracion.TipoConductor SET Tipo='" + tBTipoCond.Text + "'" + ", " + "descripcion='" + tBDescCond.Text + "'" + " WHERE IdTipoConductor=" + id, c);
                            cmd.ExecuteNonQuery();
                            c.Close();
                            actualizaDataGrid();
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
                    }
                }
                else
                    MessageBox.Show("Seleccione un tipo de conductor");
            }
            else
                MessageBox.Show("Seleccione un tipo de conductor de la lista");
        }

        private void buttonInsVeh_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (tBMarcaVeh.Text != "" && tBMatVeh.Text != "" && tBModVeh.Text != "")
            {
                try
                {
                    c.Open();
                    abrirConex = true;
                    cmd = new SqlCommand("INSERT INTO Administracion.Vehiculos (Matricula, Modelo, Marca) VALUES('" + tBMatVeh.Text + "'" + "," + "'" + tBModVeh.Text + "'" + "," + "'" + tBMarcaVeh.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    actualizaDataGrid();
                    MessageBox.Show("Inserción correcta", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    actualizaCombos();
                    tBMarcaVeh.Text = "";
                    tBMatVeh.Text = "";
                    tBModVeh.Text = "";
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

        private void buttonElimVeh_Click(object sender, EventArgs e)
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
                        cmd = new SqlCommand("DELETE FROM Administracion.Vehiculos WHERE IdUnidad=" + Convert.ToInt32(id), c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                        actualizaDataGrid();
                        MessageBox.Show("Eliminación correcta", "Eliminar", MessageBoxButtons.OK);
                        actualizaCombos();
                        tBMarcaVeh.Text = "";
                        tBMatVeh.Text = "";
                        tBModVeh.Text = "";
                        tBMatVeh.Focus();
                    }
                    else
                        MessageBox.Show("Seleccione una Unidad de la lista");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(abrirConex == true)
                        c.Close();
                }
            }
            else
                MessageBox.Show("Selecciona una Unidad de la lista");
        }

        private void buttonModVeh_Click(object sender, EventArgs e)
        {
            abrirConex = false;
            if (this.dataGridView3.CurrentRow != null)
            {
                String id = this.dataGridView3.Rows[this.dataGridView3.CurrentRow.Index].Cells[0].Value.ToString();
                if (id != "")
                {
                    if (tBMatVeh.Text != "" && tBMarcaVeh.Text != "" && tBModVeh.Text != "")
                    {
                        try
                        {
                            c.Open();
                            cmd = new SqlCommand("UPDATE Administracion.Vehiculos SET Matricula='" + tBMatVeh.Text + "'" + ", " + "Modelo='" + tBModVeh.Text + "'" + ", " + "Marca='" + tBMarcaVeh.Text + "'" + " WHERE IdUnidad=" + id, c);
                            cmd.ExecuteNonQuery();
                            c.Close();
                            actualizaDataGrid();
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
                        MessageBox.Show("Error: Todos los campos son requeridos, introduzca valores");
                    }
                }
                else
                    MessageBox.Show("Seleccione un estado");
            }
            else
                MessageBox.Show("Seleccione un Vehículo de la lista");
        }
    }
}
