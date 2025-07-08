namespace ProyectoCRUD.Presentacion.Mantenimiento.Seccion
{
    partial class seccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seccion));
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
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
            this.lblfecha.Location = new System.Drawing.Point(1227, 678);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(79, 29);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "label1";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(1242, 9);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(79, 29);
            this.lblhora.TabIndex = 4;
            this.lblhora.Text = "label1";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminar.Image = global::ProyectoCRUD.Properties.Resources.delete__1_;
            this.buttonEliminar.Location = new System.Drawing.Point(1233, 63);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(69, 59);
            this.buttonEliminar.TabIndex = 12;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1002, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Values";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(1140, 63);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(69, 59);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // seccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 734);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Name = "seccion";
            this.Text = "seccion";
            this.Load += new System.EventHandler(this.seccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAgregar;
    }
}