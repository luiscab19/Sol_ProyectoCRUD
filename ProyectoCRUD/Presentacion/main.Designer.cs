namespace ProyectoCRUD.Presentacion
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonNotas = new System.Windows.Forms.Button();
            this.buttonInscripcion = new System.Windows.Forms.Button();
            this.buttonMantenimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(1239, 27);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(79, 29);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "label1";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(1224, 696);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(79, 29);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "label1";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // buttonReporte
            // 
            this.buttonReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporte.ForeColor = System.Drawing.Color.Transparent;
            this.buttonReporte.Location = new System.Drawing.Point(58, 230);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(214, 89);
            this.buttonReporte.TabIndex = 3;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = false;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // buttonNotas
            // 
            this.buttonNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotas.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNotas.Location = new System.Drawing.Point(58, 538);
            this.buttonNotas.Name = "buttonNotas";
            this.buttonNotas.Size = new System.Drawing.Size(214, 89);
            this.buttonNotas.TabIndex = 5;
            this.buttonNotas.Text = "Notas";
            this.buttonNotas.UseVisualStyleBackColor = false;
            this.buttonNotas.Click += new System.EventHandler(this.buttonNotas_Click);
            // 
            // buttonInscripcion
            // 
            this.buttonInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscripcion.ForeColor = System.Drawing.Color.Transparent;
            this.buttonInscripcion.Location = new System.Drawing.Point(58, 69);
            this.buttonInscripcion.Name = "buttonInscripcion";
            this.buttonInscripcion.Size = new System.Drawing.Size(214, 93);
            this.buttonInscripcion.TabIndex = 6;
            this.buttonInscripcion.Text = "Inscripcion";
            this.buttonInscripcion.UseVisualStyleBackColor = false;
            this.buttonInscripcion.Click += new System.EventHandler(this.buttonInscripcion_Click);
            // 
            // buttonMantenimiento
            // 
            this.buttonMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMantenimiento.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMantenimiento.Location = new System.Drawing.Point(58, 387);
            this.buttonMantenimiento.Name = "buttonMantenimiento";
            this.buttonMantenimiento.Size = new System.Drawing.Size(214, 89);
            this.buttonMantenimiento.TabIndex = 7;
            this.buttonMantenimiento.Text = "Mantenimiento";
            this.buttonMantenimiento.UseVisualStyleBackColor = false;
            this.buttonMantenimiento.Click += new System.EventHandler(this.buttonMantenimiento_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 734);
            this.Controls.Add(this.buttonMantenimiento);
            this.Controls.Add(this.buttonInscripcion);
            this.Controls.Add(this.buttonNotas);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonNotas;
        private System.Windows.Forms.Button buttonInscripcion;
        private System.Windows.Forms.Button buttonMantenimiento;
    }
}