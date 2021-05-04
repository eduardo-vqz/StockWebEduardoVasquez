
namespace StockWebEduardoVasquez
{
    partial class frmMenu
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
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnElectrodomestico = new System.Windows.Forms.Button();
            this.btnSucursalElectrodomestico = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(12, 12);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(192, 64);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.Location = new System.Drawing.Point(12, 99);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(192, 64);
            this.btnSucursales.TabIndex = 1;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = true;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(12, 189);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(192, 64);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnElectrodomestico
            // 
            this.btnElectrodomestico.Location = new System.Drawing.Point(259, 99);
            this.btnElectrodomestico.Name = "btnElectrodomestico";
            this.btnElectrodomestico.Size = new System.Drawing.Size(192, 64);
            this.btnElectrodomestico.TabIndex = 3;
            this.btnElectrodomestico.Text = "Electrodomestico";
            this.btnElectrodomestico.UseVisualStyleBackColor = true;
            this.btnElectrodomestico.Click += new System.EventHandler(this.btnElectrodomestico_Click);
            // 
            // btnSucursalElectrodomestico
            // 
            this.btnSucursalElectrodomestico.Location = new System.Drawing.Point(259, 12);
            this.btnSucursalElectrodomestico.Name = "btnSucursalElectrodomestico";
            this.btnSucursalElectrodomestico.Size = new System.Drawing.Size(192, 64);
            this.btnSucursalElectrodomestico.TabIndex = 4;
            this.btnSucursalElectrodomestico.Text = "Sucursal Electrodomestico";
            this.btnSucursalElectrodomestico.UseVisualStyleBackColor = true;
            this.btnSucursalElectrodomestico.Click += new System.EventHandler(this.btnSucursalElectrodomestico_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(259, 189);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(192, 64);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnSucursalElectrodomestico);
            this.Controls.Add(this.btnElectrodomestico);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnSucursales);
            this.Controls.Add(this.btnCategorias);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnElectrodomestico;
        private System.Windows.Forms.Button btnSucursalElectrodomestico;
        private System.Windows.Forms.Button btnInventario;
    }
}