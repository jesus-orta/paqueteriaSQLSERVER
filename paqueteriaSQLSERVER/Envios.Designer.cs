namespace paqueteriaSQLSERVER
{
    partial class Envios
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EnviosDataGrid = new System.Windows.Forms.DataGridView();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Destinatario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CP = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.CiudadCombo = new System.Windows.Forms.ComboBox();
            this.ClienteCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.FechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.FechaRecibido = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnviosDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.FechaEntrega);
            this.groupBox7.Controls.Add(this.FechaRecibido);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.EnviosDataGrid);
            this.groupBox7.Controls.Add(this.Direccion);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.Destinatario);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.CP);
            this.groupBox7.Controls.Add(this.Telefono);
            this.groupBox7.Controls.Add(this.CiudadCombo);
            this.groupBox7.Controls.Add(this.ClienteCombo);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Location = new System.Drawing.Point(10, 10);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(592, 595);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Envios";
            // 
            // EnviosDataGrid
            // 
            this.EnviosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnviosDataGrid.Location = new System.Drawing.Point(9, 171);
            this.EnviosDataGrid.Name = "EnviosDataGrid";
            this.EnviosDataGrid.Size = new System.Drawing.Size(577, 418);
            this.EnviosDataGrid.TabIndex = 21;
            this.EnviosDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnviosDataGrid_MouseClick);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(101, 76);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(153, 20);
            this.Direccion.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dirección";
            // 
            // Destinatario
            // 
            this.Destinatario.Location = new System.Drawing.Point(361, 21);
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.Size = new System.Drawing.Size(139, 20);
            this.Destinatario.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Destinatario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Insertar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(101, 102);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(153, 20);
            this.CP.TabIndex = 12;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(361, 48);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(139, 20);
            this.Telefono.TabIndex = 11;
            // 
            // CiudadCombo
            // 
            this.CiudadCombo.FormattingEnabled = true;
            this.CiudadCombo.Location = new System.Drawing.Point(99, 47);
            this.CiudadCombo.Name = "CiudadCombo";
            this.CiudadCombo.Size = new System.Drawing.Size(155, 21);
            this.CiudadCombo.TabIndex = 8;
            // 
            // ClienteCombo
            // 
            this.ClienteCombo.FormattingEnabled = true;
            this.ClienteCombo.Location = new System.Drawing.Point(99, 20);
            this.ClienteCombo.Name = "ClienteCombo";
            this.ClienteCombo.Size = new System.Drawing.Size(155, 21);
            this.ClienteCombo.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "CP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(291, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Telefono";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(293, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Ciudad a enviar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Cliente remitente";
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.Location = new System.Drawing.Point(384, 109);
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Size = new System.Drawing.Size(155, 20);
            this.FechaEntrega.TabIndex = 25;
            this.FechaEntrega.Visible = false;
            // 
            // FechaRecibido
            // 
            this.FechaRecibido.Location = new System.Drawing.Point(384, 83);
            this.FechaRecibido.Name = "FechaRecibido";
            this.FechaRecibido.Size = new System.Drawing.Size(155, 20);
            this.FechaRecibido.TabIndex = 24;
            this.FechaRecibido.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Fecha entrega";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(291, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Fecha recibido";
            this.label18.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(608, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 593);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividades del Envio";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Historial De Envios";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(303, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "Envios Entregados";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(85, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(303, 35);
            this.button6.TabIndex = 0;
            this.button6.Text = "Envios A Entregar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 283);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(303, 35);
            this.button7.TabIndex = 0;
            this.button7.Text = "Envios a Regresar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(303, 35);
            this.button8.TabIndex = 0;
            this.button8.Text = "Visitas Por Envio";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(85, 472);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(303, 35);
            this.button9.TabIndex = 0;
            this.button9.Text = "Paquetes Por Envio";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Name = "Envios";
            this.Text = "Envios";
            this.Load += new System.EventHandler(this.Envios_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnviosDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView EnviosDataGrid;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Destinatario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.ComboBox CiudadCombo;
        private System.Windows.Forms.ComboBox ClienteCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker FechaEntrega;
        private System.Windows.Forms.DateTimePicker FechaRecibido;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}