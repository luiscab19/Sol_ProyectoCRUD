namespace ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones
{
    partial class AgregarMat
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
            this.textBoxAgregarMateria = new System.Windows.Forms.TextBox();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.labelNombreMateria = new System.Windows.Forms.Label();
            this.labelContenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAgregarMateria
            // 
            this.textBoxAgregarMateria.Location = new System.Drawing.Point(58, 176);
            this.textBoxAgregarMateria.Multiline = true;
            this.textBoxAgregarMateria.Name = "textBoxAgregarMateria";
            this.textBoxAgregarMateria.Size = new System.Drawing.Size(419, 63);
            this.textBoxAgregarMateria.TabIndex = 0;
            this.textBoxAgregarMateria.TextChanged += new System.EventHandler(this.textBoxAgregarMateria_TextChanged);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(58, 329);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(419, 147);
            this.textBoxContenido.TabIndex = 1;
            this.textBoxContenido.TextChanged += new System.EventHandler(this.textBoxContenido_TextChanged);
            // 
            // labelNombreMateria
            // 
            this.labelNombreMateria.AutoSize = true;
            this.labelNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMateria.Location = new System.Drawing.Point(58, 140);
            this.labelNombreMateria.Name = "labelNombreMateria";
            this.labelNombreMateria.Size = new System.Drawing.Size(203, 25);
            this.labelNombreMateria.TabIndex = 2;
            this.labelNombreMateria.Text = "Nombre de la materia:";
            this.labelNombreMateria.Click += new System.EventHandler(this.labelNombreMateria_Click);
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContenido.Location = new System.Drawing.Point(58, 287);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(108, 25);
            this.labelContenido.TabIndex = 3;
            this.labelContenido.Text = "Contenido:";
            this.labelContenido.Click += new System.EventHandler(this.labelContenido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Materia";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(176, 548);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(159, 77);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // AgregarMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 682);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelContenido);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.textBoxAgregarMateria);
            this.Name = "AgregarMat";
            this.Text = "AgregarMat";
            this.Load += new System.EventHandler(this.AgregarMat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAgregarMateria;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Label labelNombreMateria;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAceptar;
    }
}