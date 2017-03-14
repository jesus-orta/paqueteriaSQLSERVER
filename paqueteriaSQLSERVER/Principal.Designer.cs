namespace paqueteriaSQLSERVER
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.buttonSucursal = new System.Windows.Forms.Button();
            this.buttonCond = new System.Windows.Forms.Button();
            this.buttonEnvios = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSucursal
            // 
            this.buttonSucursal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSucursal.BackgroundImage")));
            this.buttonSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSucursal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSucursal.Location = new System.Drawing.Point(176, 76);
            this.buttonSucursal.Name = "buttonSucursal";
            this.buttonSucursal.Size = new System.Drawing.Size(140, 119);
            this.buttonSucursal.TabIndex = 0;
            this.buttonSucursal.Text = "Sucursales";
            this.buttonSucursal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSucursal.UseVisualStyleBackColor = true;
            this.buttonSucursal.Click += new System.EventHandler(this.buttonSucursal_Click);
            // 
            // buttonCond
            // 
            this.buttonCond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCond.BackgroundImage")));
            this.buttonCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCond.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCond.Location = new System.Drawing.Point(549, 76);
            this.buttonCond.Name = "buttonCond";
            this.buttonCond.Size = new System.Drawing.Size(140, 119);
            this.buttonCond.TabIndex = 1;
            this.buttonCond.Text = "Conductores Y Unidades";
            this.buttonCond.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCond.UseVisualStyleBackColor = true;
            this.buttonCond.Click += new System.EventHandler(this.buttonCond_Click);
            // 
            // buttonEnvios
            // 
            this.buttonEnvios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEnvios.BackgroundImage")));
            this.buttonEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnvios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEnvios.Location = new System.Drawing.Point(176, 228);
            this.buttonEnvios.Name = "buttonEnvios";
            this.buttonEnvios.Size = new System.Drawing.Size(140, 119);
            this.buttonEnvios.TabIndex = 2;
            this.buttonEnvios.Text = "Envios";
            this.buttonEnvios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnvios.UseVisualStyleBackColor = true;
            this.buttonEnvios.Click += new System.EventHandler(this.buttonEnvios_Click);
            // 
            // buttonVentas
            // 
            this.buttonVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVentas.BackgroundImage")));
            this.buttonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonVentas.Location = new System.Drawing.Point(549, 228);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(140, 119);
            this.buttonVentas.TabIndex = 3;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVentas.UseVisualStyleBackColor = true;
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClientes.BackgroundImage")));
            this.buttonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClientes.Location = new System.Drawing.Point(376, 132);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(140, 119);
            this.buttonClientes.TabIndex = 4;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(893, 382);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonVentas);
            this.Controls.Add(this.buttonEnvios);
            this.Controls.Add(this.buttonCond);
            this.Controls.Add(this.buttonSucursal);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Paquetería";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSucursal;
        private System.Windows.Forms.Button buttonCond;
        private System.Windows.Forms.Button buttonEnvios;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonClientes;
    }
}

