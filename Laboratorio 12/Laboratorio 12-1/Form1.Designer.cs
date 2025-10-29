namespace Laboratorio_12_1
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
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_promedio = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(111, 205);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 0;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_promedio
            // 
            this.btn_promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_promedio.Location = new System.Drawing.Point(14, 205);
            this.btn_promedio.Name = "btn_promedio";
            this.btn_promedio.Size = new System.Drawing.Size(75, 23);
            this.btn_promedio.TabIndex = 1;
            this.btn_promedio.Text = "Promedio";
            this.btn_promedio.UseVisualStyleBackColor = true;
            this.btn_promedio.Click += new System.EventHandler(this.btn_promedio_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(204, 205);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(76, 19);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(127, 20);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Nota Promedio";
            this.lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota1.Location = new System.Drawing.Point(37, 57);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(72, 17);
            this.lbl_nota1.TabIndex = 4;
            this.lbl_nota1.Text = "Nota No.1";
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota2.Location = new System.Drawing.Point(33, 108);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(76, 17);
            this.lbl_nota2.TabIndex = 5;
            this.lbl_nota2.Text = "Nota No. 2";
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota3.Location = new System.Drawing.Point(33, 157);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(76, 17);
            this.lbl_nota3.TabIndex = 6;
            this.lbl_nota3.Text = "Nota No. 3";
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.AutoSize = true;
            this.lbl_promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promedio.Location = new System.Drawing.Point(33, 258);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(111, 17);
            this.lbl_promedio.TabIndex = 7;
            this.lbl_promedio.Text = "Su promedio es:";
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(159, 105);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 20);
            this.txt_nota2.TabIndex = 8;
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(159, 156);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(100, 20);
            this.txt_nota3.TabIndex = 9;
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(159, 56);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 20);
            this.txt_nota1.TabIndex = 10;
            // 
            // txt_promedio
            // 
            this.txt_promedio.Location = new System.Drawing.Point(159, 257);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.ReadOnly = true;
            this.txt_promedio.Size = new System.Drawing.Size(100, 20);
            this.txt_promedio.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 293);
            this.Controls.Add(this.txt_promedio);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.lbl_promedio);
            this.Controls.Add(this.lbl_nota3);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lbl_nota1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_promedio);
            this.Controls.Add(this.btn_limpiar);
            this.Name = "Form1";
            this.Text = "Calcular Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_promedio;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.Label lbl_promedio;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.TextBox txt_promedio;
    }
}

