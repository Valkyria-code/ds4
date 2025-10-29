namespace Laboratorio_12
{
    partial class Form1
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_velocidad = new System.Windows.Forms.Label();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.lbl_distancia = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_velocidad = new System.Windows.Forms.TextBox();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.txt_distancia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(26, 173);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(98, 19);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(129, 20);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Distancia Total";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_velocidad
            // 
            this.lbl_velocidad.AutoSize = true;
            this.lbl_velocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_velocidad.Location = new System.Drawing.Point(23, 66);
            this.lbl_velocidad.Name = "lbl_velocidad";
            this.lbl_velocidad.Size = new System.Drawing.Size(138, 17);
            this.lbl_velocidad.TabIndex = 2;
            this.lbl_velocidad.Text = "Ingrese la velocidad:";
            this.lbl_velocidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo.Location = new System.Drawing.Point(23, 115);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(120, 17);
            this.lbl_tiempo.TabIndex = 3;
            this.lbl_tiempo.Text = "Ingrese el tiempo:";
            // 
            // lbl_distancia
            // 
            this.lbl_distancia.AutoSize = true;
            this.lbl_distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distancia.Location = new System.Drawing.Point(23, 229);
            this.lbl_distancia.Name = "lbl_distancia";
            this.lbl_distancia.Size = new System.Drawing.Size(162, 17);
            this.lbl_distancia.TabIndex = 4;
            this.lbl_distancia.Text = "La distancia total es de: ";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(130, 173);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(234, 173);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_velocidad
            // 
            this.txt_velocidad.Location = new System.Drawing.Point(209, 65);
            this.txt_velocidad.Name = "txt_velocidad";
            this.txt_velocidad.Size = new System.Drawing.Size(100, 20);
            this.txt_velocidad.TabIndex = 7;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Location = new System.Drawing.Point(209, 114);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(100, 20);
            this.txt_tiempo.TabIndex = 8;
            // 
            // txt_distancia
            // 
            this.txt_distancia.Location = new System.Drawing.Point(209, 228);
            this.txt_distancia.Name = "txt_distancia";
            this.txt_distancia.ReadOnly = true;
            this.txt_distancia.Size = new System.Drawing.Size(100, 20);
            this.txt_distancia.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 285);
            this.Controls.Add(this.txt_distancia);
            this.Controls.Add(this.txt_tiempo);
            this.Controls.Add(this.txt_velocidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_distancia);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.lbl_velocidad);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Distancia Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_velocidad;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label lbl_distancia;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_velocidad;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.TextBox txt_distancia;
    }
}

