namespace ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones
{
    partial class EliminarMateria
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreMateria = new System.Windows.Forms.Label();
            this.textBoxEliminarMateria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(168, 312);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(159, 77);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Eliminar Materia";
            // 
            // labelNombreMateria
            // 
            this.labelNombreMateria.AutoSize = true;
            this.labelNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMateria.Location = new System.Drawing.Point(59, 145);
            this.labelNombreMateria.Name = "labelNombreMateria";
            this.labelNombreMateria.Size = new System.Drawing.Size(372, 25);
            this.labelNombreMateria.TabIndex = 8;
            this.labelNombreMateria.Text = "Nombre de la materia que desea eliminar:";
            this.labelNombreMateria.Click += new System.EventHandler(this.labelNombreMateria_Click_1);
            // 
            // textBoxEliminarMateria
            // 
            this.textBoxEliminarMateria.Location = new System.Drawing.Point(52, 184);
            this.textBoxEliminarMateria.Multiline = true;
            this.textBoxEliminarMateria.Name = "textBoxEliminarMateria";
            this.textBoxEliminarMateria.Size = new System.Drawing.Size(419, 63);
            this.textBoxEliminarMateria.TabIndex = 6;
            this.textBoxEliminarMateria.TextChanged += new System.EventHandler(this.textBoxEliminarMateria_TextChanged);
            // 
            // EliminarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 411);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.textBoxEliminarMateria);
            this.Name = "EliminarMateria";
            this.Text = "EliminarMateria";
            this.Load += new System.EventHandler(this.EliminarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreMateria;
        private System.Windows.Forms.TextBox textBoxEliminarMateria;
    }
}