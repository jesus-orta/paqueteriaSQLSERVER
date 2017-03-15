namespace paqueteriaSQLSERVER
{
    partial class OpcionesEnvio
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
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.IdEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.Accion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Destino = new System.Windows.Forms.TextBox();
            this.G1_Insertar = new System.Windows.Forms.Button();
            this.G1_Actualizar = new System.Windows.Forms.Button();
            this.G1_Eliminar = new System.Windows.Forms.Button();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.Eliminar_Grupo2 = new System.Windows.Forms.Button();
            this.Actualizar_Grupo2 = new System.Windows.Forms.Button();
            this.Insertar_Grupo2 = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.IdEnvio2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.Grupo1.SuspendLayout();
            this.Grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(20, 185);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(662, 283);
            this.GridDatos.TabIndex = 0;
            this.GridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.G1_Eliminar);
            this.Grupo1.Controls.Add(this.G1_Actualizar);
            this.Grupo1.Controls.Add(this.G1_Insertar);
            this.Grupo1.Controls.Add(this.Destino);
            this.Grupo1.Controls.Add(this.label4);
            this.Grupo1.Controls.Add(this.label3);
            this.Grupo1.Controls.Add(this.Accion);
            this.Grupo1.Controls.Add(this.label2);
            this.Grupo1.Controls.Add(this.label1);
            this.Grupo1.Controls.Add(this.Ciudad);
            this.Grupo1.Controls.Add(this.IdEnvio);
            this.Grupo1.Location = new System.Drawing.Point(20, 10);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(662, 157);
            this.Grupo1.TabIndex = 1;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Historial de Envio";
            // 
            // IdEnvio
            // 
            this.IdEnvio.Location = new System.Drawing.Point(97, 22);
            this.IdEnvio.Name = "IdEnvio";
            this.IdEnvio.Size = new System.Drawing.Size(124, 20);
            this.IdEnvio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdEnvio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CiudadActual";
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(96, 63);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(124, 20);
            this.Ciudad.TabIndex = 0;
            // 
            // Accion
            // 
            this.Accion.FormattingEnabled = true;
            this.Accion.Items.AddRange(new object[] {
            "Logistica",
            "Entregado",
            "Visita (No Entregado)",
            "Visita (Entregado)",
            "Error en el Envio"});
            this.Accion.Location = new System.Drawing.Point(342, 22);
            this.Accion.Name = "Accion";
            this.Accion.Size = new System.Drawing.Size(121, 21);
            this.Accion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Accion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Destino";
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(342, 57);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(121, 20);
            this.Destino.TabIndex = 6;
            // 
            // G1_Insertar
            // 
            this.G1_Insertar.Location = new System.Drawing.Point(23, 113);
            this.G1_Insertar.Name = "G1_Insertar";
            this.G1_Insertar.Size = new System.Drawing.Size(75, 23);
            this.G1_Insertar.TabIndex = 7;
            this.G1_Insertar.Text = "Insertar";
            this.G1_Insertar.UseVisualStyleBackColor = true;
            this.G1_Insertar.Click += new System.EventHandler(this.G1_Insertar_Click);
            // 
            // G1_Actualizar
            // 
            this.G1_Actualizar.Location = new System.Drawing.Point(135, 113);
            this.G1_Actualizar.Name = "G1_Actualizar";
            this.G1_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.G1_Actualizar.TabIndex = 7;
            this.G1_Actualizar.Text = "Actualizar";
            this.G1_Actualizar.UseVisualStyleBackColor = true;
            this.G1_Actualizar.Click += new System.EventHandler(this.G1_Actualizar_Click);
            // 
            // G1_Eliminar
            // 
            this.G1_Eliminar.Location = new System.Drawing.Point(242, 113);
            this.G1_Eliminar.Name = "G1_Eliminar";
            this.G1_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.G1_Eliminar.TabIndex = 7;
            this.G1_Eliminar.Text = "Eliminar";
            this.G1_Eliminar.UseVisualStyleBackColor = true;
            this.G1_Eliminar.Click += new System.EventHandler(this.G1_Eliminar_Click);
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.Eliminar_Grupo2);
            this.Grupo2.Controls.Add(this.Actualizar_Grupo2);
            this.Grupo2.Controls.Add(this.Insertar_Grupo2);
            this.Grupo2.Controls.Add(this.Cliente);
            this.Grupo2.Controls.Add(this.label5);
            this.Grupo2.Controls.Add(this.label7);
            this.Grupo2.Controls.Add(this.label8);
            this.Grupo2.Controls.Add(this.Direccion);
            this.Grupo2.Controls.Add(this.IdEnvio2);
            this.Grupo2.Location = new System.Drawing.Point(20, 10);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(662, 157);
            this.Grupo2.TabIndex = 1;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Grupo2";
            // 
            // Eliminar_Grupo2
            // 
            this.Eliminar_Grupo2.Location = new System.Drawing.Point(242, 113);
            this.Eliminar_Grupo2.Name = "Eliminar_Grupo2";
            this.Eliminar_Grupo2.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_Grupo2.TabIndex = 7;
            this.Eliminar_Grupo2.Text = "Eliminar";
            this.Eliminar_Grupo2.UseVisualStyleBackColor = true;
            this.Eliminar_Grupo2.Click += new System.EventHandler(this.Eliminar_Grupo2_Click);
            // 
            // Actualizar_Grupo2
            // 
            this.Actualizar_Grupo2.Location = new System.Drawing.Point(135, 113);
            this.Actualizar_Grupo2.Name = "Actualizar_Grupo2";
            this.Actualizar_Grupo2.Size = new System.Drawing.Size(75, 23);
            this.Actualizar_Grupo2.TabIndex = 7;
            this.Actualizar_Grupo2.Text = "Actualizar";
            this.Actualizar_Grupo2.UseVisualStyleBackColor = true;
            this.Actualizar_Grupo2.Click += new System.EventHandler(this.Actualizar_Grupo2_Click);
            // 
            // Insertar_Grupo2
            // 
            this.Insertar_Grupo2.Location = new System.Drawing.Point(23, 113);
            this.Insertar_Grupo2.Name = "Insertar_Grupo2";
            this.Insertar_Grupo2.Size = new System.Drawing.Size(75, 23);
            this.Insertar_Grupo2.TabIndex = 7;
            this.Insertar_Grupo2.Text = "Insertar";
            this.Insertar_Grupo2.UseVisualStyleBackColor = true;
            this.Insertar_Grupo2.Click += new System.EventHandler(this.Insertar_Grupo2_Click);
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(336, 21);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(121, 20);
            this.Cliente.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "IdEnvio";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(96, 63);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(124, 20);
            this.Direccion.TabIndex = 0;
            // 
            // IdEnvio2
            // 
            this.IdEnvio2.Location = new System.Drawing.Point(97, 22);
            this.IdEnvio2.Name = "IdEnvio2";
            this.IdEnvio2.Size = new System.Drawing.Size(124, 20);
            this.IdEnvio2.TabIndex = 0;
            // 
            // OpcionesEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 480);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.Grupo1);
            this.Controls.Add(this.GridDatos);
            this.Name = "OpcionesEnvio";
            this.Text = "OpcionesEnvio";
            this.Load += new System.EventHandler(this.OpcionesEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdEnvio;
        private System.Windows.Forms.Button G1_Eliminar;
        private System.Windows.Forms.Button G1_Actualizar;
        private System.Windows.Forms.Button G1_Insertar;
        private System.Windows.Forms.TextBox Destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Accion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.Button Eliminar_Grupo2;
        private System.Windows.Forms.Button Actualizar_Grupo2;
        private System.Windows.Forms.Button Insertar_Grupo2;
        private System.Windows.Forms.TextBox Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox IdEnvio2;
    }
}