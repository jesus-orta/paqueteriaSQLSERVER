namespace paqueteriaSQLSERVER
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxVenta = new System.Windows.Forms.GroupBox();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.dateTimePickerventa = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSuc_venta = new System.Windows.Forms.ComboBox();
            this.buttonActVenta = new System.Windows.Forms.Button();
            this.buttonElimVenta = new System.Windows.Forms.Button();
            this.buttonInsVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDetalleVenta = new System.Windows.Forms.GroupBox();
            this.dataGridDetVenta = new System.Windows.Forms.DataGridView();
            this.comboBoxIdEnvio_vnta = new System.Windows.Forms.ComboBox();
            this.comboBoxIdVnta_Vnta = new System.Windows.Forms.ComboBox();
            this.labelIdVnta_Vnta = new System.Windows.Forms.Label();
            this.IdVentaLabel = new System.Windows.Forms.Label();
            this.ActualizarDetalleV = new System.Windows.Forms.Button();
            this.EliminarDetalleV = new System.Windows.Forms.Button();
            this.InsertarDetalleV = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.groupBoxVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.groupBoxDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVenta
            // 
            this.groupBoxVenta.Controls.Add(this.textBoxTotal);
            this.groupBoxVenta.Controls.Add(this.labelTotal);
            this.groupBoxVenta.Controls.Add(this.dataGridVentas);
            this.groupBoxVenta.Controls.Add(this.dateTimePickerventa);
            this.groupBoxVenta.Controls.Add(this.comboBoxSuc_venta);
            this.groupBoxVenta.Controls.Add(this.buttonActVenta);
            this.groupBoxVenta.Controls.Add(this.buttonElimVenta);
            this.groupBoxVenta.Controls.Add(this.buttonInsVenta);
            this.groupBoxVenta.Controls.Add(this.label2);
            this.groupBoxVenta.Controls.Add(this.label1);
            this.groupBoxVenta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVenta.Name = "groupBoxVenta";
            this.groupBoxVenta.Size = new System.Drawing.Size(368, 373);
            this.groupBoxVenta.TabIndex = 0;
            this.groupBoxVenta.TabStop = false;
            this.groupBoxVenta.Text = "Ventas";
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Location = new System.Drawing.Point(6, 136);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.Size = new System.Drawing.Size(355, 231);
            this.dataGridVentas.TabIndex = 10;
            this.dataGridVentas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridVentas_MouseClick);
            // 
            // dateTimePickerventa
            // 
            this.dateTimePickerventa.Location = new System.Drawing.Point(229, 20);
            this.dateTimePickerventa.Name = "dateTimePickerventa";
            this.dateTimePickerventa.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerventa.TabIndex = 9;
            // 
            // comboBoxSuc_venta
            // 
            this.comboBoxSuc_venta.FormattingEnabled = true;
            this.comboBoxSuc_venta.Location = new System.Drawing.Point(62, 20);
            this.comboBoxSuc_venta.Name = "comboBoxSuc_venta";
            this.comboBoxSuc_venta.Size = new System.Drawing.Size(108, 21);
            this.comboBoxSuc_venta.TabIndex = 8;
            // 
            // buttonActVenta
            // 
            this.buttonActVenta.Location = new System.Drawing.Point(203, 91);
            this.buttonActVenta.Name = "buttonActVenta";
            this.buttonActVenta.Size = new System.Drawing.Size(75, 23);
            this.buttonActVenta.TabIndex = 5;
            this.buttonActVenta.Text = "Actualizar";
            this.buttonActVenta.UseVisualStyleBackColor = true;
            this.buttonActVenta.Click += new System.EventHandler(this.buttonActVenta_Click);
            // 
            // buttonElimVenta
            // 
            this.buttonElimVenta.Location = new System.Drawing.Point(109, 91);
            this.buttonElimVenta.Name = "buttonElimVenta";
            this.buttonElimVenta.Size = new System.Drawing.Size(75, 23);
            this.buttonElimVenta.TabIndex = 6;
            this.buttonElimVenta.Text = "Eliminar";
            this.buttonElimVenta.UseVisualStyleBackColor = true;
            this.buttonElimVenta.Click += new System.EventHandler(this.buttonElimVenta_Click);
            // 
            // buttonInsVenta
            // 
            this.buttonInsVenta.Location = new System.Drawing.Point(10, 91);
            this.buttonInsVenta.Name = "buttonInsVenta";
            this.buttonInsVenta.Size = new System.Drawing.Size(75, 23);
            this.buttonInsVenta.TabIndex = 7;
            this.buttonInsVenta.Text = "Insertar";
            this.buttonInsVenta.UseVisualStyleBackColor = true;
            this.buttonInsVenta.Click += new System.EventHandler(this.buttonInsVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal";
            // 
            // groupBoxDetalleVenta
            // 
            this.groupBoxDetalleVenta.Controls.Add(this.textBoxSubTotal);
            this.groupBoxDetalleVenta.Controls.Add(this.labelSubtotal);
            this.groupBoxDetalleVenta.Controls.Add(this.dataGridDetVenta);
            this.groupBoxDetalleVenta.Controls.Add(this.comboBoxIdEnvio_vnta);
            this.groupBoxDetalleVenta.Controls.Add(this.comboBoxIdVnta_Vnta);
            this.groupBoxDetalleVenta.Controls.Add(this.labelIdVnta_Vnta);
            this.groupBoxDetalleVenta.Controls.Add(this.IdVentaLabel);
            this.groupBoxDetalleVenta.Controls.Add(this.ActualizarDetalleV);
            this.groupBoxDetalleVenta.Controls.Add(this.EliminarDetalleV);
            this.groupBoxDetalleVenta.Controls.Add(this.InsertarDetalleV);
            this.groupBoxDetalleVenta.Location = new System.Drawing.Point(386, 12);
            this.groupBoxDetalleVenta.Name = "groupBoxDetalleVenta";
            this.groupBoxDetalleVenta.Size = new System.Drawing.Size(368, 373);
            this.groupBoxDetalleVenta.TabIndex = 1;
            this.groupBoxDetalleVenta.TabStop = false;
            this.groupBoxDetalleVenta.Text = "Detalle de Ventas";
            // 
            // dataGridDetVenta
            // 
            this.dataGridDetVenta.AllowUserToAddRows = false;
            this.dataGridDetVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetVenta.Location = new System.Drawing.Point(6, 136);
            this.dataGridDetVenta.Name = "dataGridDetVenta";
            this.dataGridDetVenta.Size = new System.Drawing.Size(355, 229);
            this.dataGridDetVenta.TabIndex = 11;
            this.dataGridDetVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridDetVenta_MouseClick);
            // 
            // comboBoxIdEnvio_vnta
            // 
            this.comboBoxIdEnvio_vnta.FormattingEnabled = true;
            this.comboBoxIdEnvio_vnta.Location = new System.Drawing.Point(254, 17);
            this.comboBoxIdEnvio_vnta.Name = "comboBoxIdEnvio_vnta";
            this.comboBoxIdEnvio_vnta.Size = new System.Drawing.Size(108, 21);
            this.comboBoxIdEnvio_vnta.TabIndex = 13;
            // 
            // comboBoxIdVnta_Vnta
            // 
            this.comboBoxIdVnta_Vnta.FormattingEnabled = true;
            this.comboBoxIdVnta_Vnta.Location = new System.Drawing.Point(71, 19);
            this.comboBoxIdVnta_Vnta.Name = "comboBoxIdVnta_Vnta";
            this.comboBoxIdVnta_Vnta.Size = new System.Drawing.Size(108, 21);
            this.comboBoxIdVnta_Vnta.TabIndex = 9;
            // 
            // labelIdVnta_Vnta
            // 
            this.labelIdVnta_Vnta.AutoSize = true;
            this.labelIdVnta_Vnta.Location = new System.Drawing.Point(201, 20);
            this.labelIdVnta_Vnta.Name = "labelIdVnta_Vnta";
            this.labelIdVnta_Vnta.Size = new System.Drawing.Size(46, 13);
            this.labelIdVnta_Vnta.TabIndex = 12;
            this.labelIdVnta_Vnta.Text = "Id Envio";
            // 
            // IdVentaLabel
            // 
            this.IdVentaLabel.AutoSize = true;
            this.IdVentaLabel.Location = new System.Drawing.Point(6, 23);
            this.IdVentaLabel.Name = "IdVentaLabel";
            this.IdVentaLabel.Size = new System.Drawing.Size(47, 13);
            this.IdVentaLabel.TabIndex = 8;
            this.IdVentaLabel.Text = "Id Venta";
            // 
            // ActualizarDetalleV
            // 
            this.ActualizarDetalleV.Location = new System.Drawing.Point(199, 91);
            this.ActualizarDetalleV.Name = "ActualizarDetalleV";
            this.ActualizarDetalleV.Size = new System.Drawing.Size(75, 23);
            this.ActualizarDetalleV.TabIndex = 8;
            this.ActualizarDetalleV.Text = "Actualizar";
            this.ActualizarDetalleV.UseVisualStyleBackColor = true;
            this.ActualizarDetalleV.Click += new System.EventHandler(this.ActualizarDetalleV_Click);
            // 
            // EliminarDetalleV
            // 
            this.EliminarDetalleV.Location = new System.Drawing.Point(105, 91);
            this.EliminarDetalleV.Name = "EliminarDetalleV";
            this.EliminarDetalleV.Size = new System.Drawing.Size(75, 23);
            this.EliminarDetalleV.TabIndex = 9;
            this.EliminarDetalleV.Text = "Eliminar";
            this.EliminarDetalleV.UseVisualStyleBackColor = true;
            this.EliminarDetalleV.Click += new System.EventHandler(this.EliminarDetalleV_Click);
            // 
            // InsertarDetalleV
            // 
            this.InsertarDetalleV.Location = new System.Drawing.Point(6, 91);
            this.InsertarDetalleV.Name = "InsertarDetalleV";
            this.InsertarDetalleV.Size = new System.Drawing.Size(75, 23);
            this.InsertarDetalleV.TabIndex = 10;
            this.InsertarDetalleV.Text = "Insertar";
            this.InsertarDetalleV.UseVisualStyleBackColor = true;
            this.InsertarDetalleV.Click += new System.EventHandler(this.InsertarDetalleV_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(6, 57);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(61, 13);
            this.labelSubtotal.TabIndex = 14;
            this.labelSubtotal.Text = "Subtotal ($)";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(8, 57);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(46, 13);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Total ($)";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotal.Location = new System.Drawing.Point(62, 54);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 16;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubTotal.Location = new System.Drawing.Point(71, 54);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 17;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 389);
            this.Controls.Add(this.groupBoxDetalleVenta);
            this.Controls.Add(this.groupBoxVenta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBoxVenta.ResumeLayout(false);
            this.groupBoxVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.groupBoxDetalleVenta.ResumeLayout(false);
            this.groupBoxDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDetalleVenta;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.DateTimePicker dateTimePickerventa;
        private System.Windows.Forms.ComboBox comboBoxSuc_venta;
        private System.Windows.Forms.Button buttonActVenta;
        private System.Windows.Forms.Button buttonElimVenta;
        private System.Windows.Forms.Button buttonInsVenta;
        private System.Windows.Forms.DataGridView dataGridDetVenta;
        private System.Windows.Forms.ComboBox comboBoxIdEnvio_vnta;
        private System.Windows.Forms.ComboBox comboBoxIdVnta_Vnta;
        private System.Windows.Forms.Label labelIdVnta_Vnta;
        private System.Windows.Forms.Label IdVentaLabel;
        private System.Windows.Forms.Button ActualizarDetalleV;
        private System.Windows.Forms.Button EliminarDetalleV;
        private System.Windows.Forms.Button InsertarDetalleV;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label labelSubtotal;
    }
}