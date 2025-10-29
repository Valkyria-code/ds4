namespace Laboratorio_12_2
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
            this.lbl_ladoa = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_ladob = new System.Windows.Forms.Label();
            this.lbl_semiperimetro = new System.Windows.Forms.Label();
            this.lbl_ladoc = new System.Windows.Forms.Label();
            this.btn_semiperimetro = new System.Windows.Forms.Button();
            this.btn_area = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_ladoa = new System.Windows.Forms.TextBox();
            this.txt_ladob = new System.Windows.Forms.TextBox();
            this.txt_semiperimetro = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_ladoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ladoa
            // 
            this.lbl_ladoa.AutoSize = true;
            this.lbl_ladoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ladoa.Location = new System.Drawing.Point(78, 65);
            this.lbl_ladoa.Name = "lbl_ladoa";
            this.lbl_ladoa.Size = new System.Drawing.Size(134, 17);
            this.lbl_ladoa.TabIndex = 0;
            this.lbl_ladoa.Text = "Longitud del lado A:";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(78, 300);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(124, 17);
            this.lbl_area.TabIndex = 1;
            this.lbl_area.Text = "Área del triángulo:";
            // 
            // lbl_ladob
            // 
            this.lbl_ladob.AutoSize = true;
            this.lbl_ladob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ladob.Location = new System.Drawing.Point(78, 110);
            this.lbl_ladob.Name = "lbl_ladob";
            this.lbl_ladob.Size = new System.Drawing.Size(134, 17);
            this.lbl_ladob.TabIndex = 2;
            this.lbl_ladob.Text = "Longitud del lado B:";
            // 
            // lbl_semiperimetro
            // 
            this.lbl_semiperimetro.AutoSize = true;
            this.lbl_semiperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semiperimetro.Location = new System.Drawing.Point(78, 253);
            this.lbl_semiperimetro.Name = "lbl_semiperimetro";
            this.lbl_semiperimetro.Size = new System.Drawing.Size(103, 17);
            this.lbl_semiperimetro.TabIndex = 3;
            this.lbl_semiperimetro.Text = "Semiperímetro:";
            // 
            // lbl_ladoc
            // 
            this.lbl_ladoc.AutoSize = true;
            this.lbl_ladoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ladoc.Location = new System.Drawing.Point(78, 155);
            this.lbl_ladoc.Name = "lbl_ladoc";
            this.lbl_ladoc.Size = new System.Drawing.Size(134, 17);
            this.lbl_ladoc.TabIndex = 4;
            this.lbl_ladoc.Text = "Longitud del lado C:";
            // 
            // btn_semiperimetro
            // 
            this.btn_semiperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semiperimetro.Location = new System.Drawing.Point(15, 204);
            this.btn_semiperimetro.Name = "btn_semiperimetro";
            this.btn_semiperimetro.Size = new System.Drawing.Size(107, 23);
            this.btn_semiperimetro.TabIndex = 5;
            this.btn_semiperimetro.Text = "Semiperímetro";
            this.btn_semiperimetro.UseVisualStyleBackColor = true;
            this.btn_semiperimetro.Click += new System.EventHandler(this.tn_semiperimetro_Click);
            // 
            // btn_area
            // 
            this.btn_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_area.Location = new System.Drawing.Point(139, 204);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(75, 23);
            this.btn_area.TabIndex = 6;
            this.btn_area.Text = "Área";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(233, 204);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(327, 204);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_ladoa
            // 
            this.txt_ladoa.Location = new System.Drawing.Point(233, 64);
            this.txt_ladoa.Name = "txt_ladoa";
            this.txt_ladoa.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoa.TabIndex = 9;
            // 
            // txt_ladob
            // 
            this.txt_ladob.Location = new System.Drawing.Point(233, 109);
            this.txt_ladob.Name = "txt_ladob";
            this.txt_ladob.Size = new System.Drawing.Size(100, 20);
            this.txt_ladob.TabIndex = 10;
            // 
            // txt_semiperimetro
            // 
            this.txt_semiperimetro.Location = new System.Drawing.Point(233, 252);
            this.txt_semiperimetro.Name = "txt_semiperimetro";
            this.txt_semiperimetro.Size = new System.Drawing.Size(100, 20);
            this.txt_semiperimetro.TabIndex = 11;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(233, 299);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 12;
            // 
            // txt_ladoc
            // 
            this.txt_ladoc.Location = new System.Drawing.Point(233, 154);
            this.txt_ladoc.Name = "txt_ladoc";
            this.txt_ladoc.Size = new System.Drawing.Size(100, 20);
            this.txt_ladoc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Semiperímetro y Área de un Triángulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ladoc);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.txt_semiperimetro);
            this.Controls.Add(this.txt_ladob);
            this.Controls.Add(this.txt_ladoa);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.btn_semiperimetro);
            this.Controls.Add(this.lbl_ladoc);
            this.Controls.Add(this.lbl_semiperimetro);
            this.Controls.Add(this.lbl_ladob);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_ladoa);
            this.Name = "Form1";
            this.Text = "Cálculos con Triángulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ladoa;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_ladob;
        private System.Windows.Forms.Label lbl_semiperimetro;
        private System.Windows.Forms.Label lbl_ladoc;
        private System.Windows.Forms.Button btn_semiperimetro;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_ladoa;
        private System.Windows.Forms.TextBox txt_ladob;
        private System.Windows.Forms.TextBox txt_semiperimetro;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_ladoc;
        private System.Windows.Forms.Label label6;
    }
}

