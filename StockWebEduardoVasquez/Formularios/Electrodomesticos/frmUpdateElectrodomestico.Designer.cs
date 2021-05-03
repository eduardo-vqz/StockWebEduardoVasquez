
namespace StockWebEduardoVasquez.Formularios.Electrodomesticos
{
    partial class frmUpdateElectrodomestico
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbHabilitar = new System.Windows.Forms.CheckBox();
            this.txtElectrodomestico = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(121, 60);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(264, 23);
            this.cbxCategoria.TabIndex = 14;
            // 
            // cbHabilitar
            // 
            this.cbHabilitar.AutoSize = true;
            this.cbHabilitar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbHabilitar.Location = new System.Drawing.Point(18, 107);
            this.cbHabilitar.Name = "cbHabilitar";
            this.cbHabilitar.Size = new System.Drawing.Size(71, 19);
            this.cbHabilitar.TabIndex = 13;
            this.cbHabilitar.Text = "Habilitar";
            this.cbHabilitar.UseVisualStyleBackColor = true;
            // 
            // txtElectrodomestico
            // 
            this.txtElectrodomestico.Location = new System.Drawing.Point(121, 12);
            this.txtElectrodomestico.Name = "txtElectrodomestico";
            this.txtElectrodomestico.Size = new System.Drawing.Size(264, 23);
            this.txtElectrodomestico.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 16);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(99, 15);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Electrodomestico";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(121, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmUpdateElectrodomestico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbHabilitar);
            this.Controls.Add(this.txtElectrodomestico);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmUpdateElectrodomestico";
            this.Text = "frmUpdateElectrodomestico";
            this.Load += new System.EventHandler(this.frmUpdateElectrodomestico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.CheckBox cbHabilitar;
        private System.Windows.Forms.TextBox txtElectrodomestico;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAgregar;
    }
}