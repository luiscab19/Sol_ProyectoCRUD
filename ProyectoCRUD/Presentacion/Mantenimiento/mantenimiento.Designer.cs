namespace ProyectoCRUD.Presentacion
{
    partial class mantenimiento
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
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.buttonMateria = new System.Windows.Forms.Button();
            this.buttonSeccion = new System.Windows.Forms.Button();
            this.buttonPersona = new System.Windows.Forms.Button();
            this.buttonCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(1229, 687);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(79, 29);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "label1";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(1244, 18);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(79, 29);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "label1";
            // 
            // buttonMateria
            // 
            this.buttonMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMateria.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMateria.Location = new System.Drawing.Point(72, 92);
            this.buttonMateria.Name = "buttonMateria";
            this.buttonMateria.Size = new System.Drawing.Size(219, 93);
            this.buttonMateria.TabIndex = 4;
            this.buttonMateria.Text = "Materia";
            this.buttonMateria.UseVisualStyleBackColor = false;
            this.buttonMateria.Click += new System.EventHandler(this.buttonMateria_Click);
            // 
            // buttonSeccion
            // 
            this.buttonSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeccion.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSeccion.Location = new System.Drawing.Point(72, 234);
            this.buttonSeccion.Name = "buttonSeccion";
            this.buttonSeccion.Size = new System.Drawing.Size(219, 93);
            this.buttonSeccion.TabIndex = 5;
            this.buttonSeccion.Text = "Seccion";
            this.buttonSeccion.UseVisualStyleBackColor = false;
            this.buttonSeccion.Click += new System.EventHandler(this.buttonSeccion_Click);
            // 
            // buttonPersona
            // 
            this.buttonPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersona.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPersona.Location = new System.Drawing.Point(72, 381);
            this.buttonPersona.Name = "buttonPersona";
            this.buttonPersona.Size = new System.Drawing.Size(219, 93);
            this.buttonPersona.TabIndex = 6;
            this.buttonPersona.Text = "Persona";
            this.buttonPersona.UseVisualStyleBackColor = false;
            this.buttonPersona.Click += new System.EventHandler(this.buttonPersona_Click);
            // 
            // buttonCurso
            // 
            this.buttonCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurso.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCurso.Location = new System.Drawing.Point(72, 528);
            this.buttonCurso.Name = "buttonCurso";
            this.buttonCurso.Size = new System.Drawing.Size(219, 93);
            this.buttonCurso.TabIndex = 7;
            this.buttonCurso.Text = "Curso";
            this.buttonCurso.UseVisualStyleBackColor = false;
            this.buttonCurso.Click += new System.EventHandler(this.buttonCurso_Click);
            // 
            // mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 734);
            this.Controls.Add(this.buttonCurso);
            this.Controls.Add(this.buttonPersona);
            this.Controls.Add(this.buttonSeccion);
            this.Controls.Add(this.buttonMateria);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Name = "mantenimiento";
            this.Text = "mantenimiento";
            this.Load += new System.EventHandler(this.mantenimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Button buttonMateria;
        private System.Windows.Forms.Button buttonSeccion;
        private System.Windows.Forms.Button buttonPersona;
        private System.Windows.Forms.Button buttonCurso;
    }
}