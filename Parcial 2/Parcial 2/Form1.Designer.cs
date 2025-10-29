namespace Parcial_2
{
    partial class ventana
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_hex = new System.Windows.Forms.Label();
            this.btn_hex = new System.Windows.Forms.Button();
            this.lbl_dec1 = new System.Windows.Forms.Label();
            this.lbl_oc = new System.Windows.Forms.Label();
            this.lbl_dec2 = new System.Windows.Forms.Label();
            this.tbx_hex = new System.Windows.Forms.TextBox();
            this.tbx_dec1 = new System.Windows.Forms.TextBox();
            this.tbx_dec2 = new System.Windows.Forms.TextBox();
            this.tbx_oc = new System.Windows.Forms.TextBox();
            this.tbx_messagehex = new System.Windows.Forms.TextBox();
            this.tbx_messagedec1 = new System.Windows.Forms.TextBox();
            this.tbx_messageoc = new System.Windows.Forms.TextBox();
            this.tbx_messagedec2 = new System.Windows.Forms.TextBox();
            this.btn_dec1 = new System.Windows.Forms.Button();
            this.btn_dec2 = new System.Windows.Forms.Button();
            this.btn_oc = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(152, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(237, 26);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Conversor Numérico ";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_hex
            // 
            this.lbl_hex.AutoSize = true;
            this.lbl_hex.Location = new System.Drawing.Point(24, 81);
            this.lbl_hex.Name = "lbl_hex";
            this.lbl_hex.Size = new System.Drawing.Size(118, 13);
            this.lbl_hex.TabIndex = 1;
            this.lbl_hex.Text = "Hexadecimal a Decimal";
            this.lbl_hex.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_hex
            // 
            this.btn_hex.Location = new System.Drawing.Point(314, 76);
            this.btn_hex.Name = "btn_hex";
            this.btn_hex.Size = new System.Drawing.Size(75, 23);
            this.btn_hex.TabIndex = 2;
            this.btn_hex.Text = "Convertir";
            this.btn_hex.UseVisualStyleBackColor = true;
            this.btn_hex.Click += new System.EventHandler(this.btn_hecdec_Click);
            // 
            // lbl_dec1
            // 
            this.lbl_dec1.AutoSize = true;
            this.lbl_dec1.Location = new System.Drawing.Point(24, 127);
            this.lbl_dec1.Name = "lbl_dec1";
            this.lbl_dec1.Size = new System.Drawing.Size(118, 13);
            this.lbl_dec1.TabIndex = 3;
            this.lbl_dec1.Text = "Decimal a Hexadecimal";
            // 
            // lbl_oc
            // 
            this.lbl_oc.AutoSize = true;
            this.lbl_oc.Location = new System.Drawing.Point(24, 175);
            this.lbl_oc.Name = "lbl_oc";
            this.lbl_oc.Size = new System.Drawing.Size(82, 13);
            this.lbl_oc.TabIndex = 4;
            this.lbl_oc.Text = "Octal a Decimal";
            // 
            // lbl_dec2
            // 
            this.lbl_dec2.AutoSize = true;
            this.lbl_dec2.Location = new System.Drawing.Point(24, 219);
            this.lbl_dec2.Name = "lbl_dec2";
            this.lbl_dec2.Size = new System.Drawing.Size(82, 13);
            this.lbl_dec2.TabIndex = 5;
            this.lbl_dec2.Text = "Decimal a Octal";
            // 
            // tbx_hex
            // 
            this.tbx_hex.Location = new System.Drawing.Point(165, 78);
            this.tbx_hex.Name = "tbx_hex";
            this.tbx_hex.Size = new System.Drawing.Size(100, 20);
            this.tbx_hex.TabIndex = 6;
            // 
            // tbx_dec1
            // 
            this.tbx_dec1.Location = new System.Drawing.Point(165, 124);
            this.tbx_dec1.Name = "tbx_dec1";
            this.tbx_dec1.Size = new System.Drawing.Size(100, 20);
            this.tbx_dec1.TabIndex = 7;
            // 
            // tbx_dec2
            // 
            this.tbx_dec2.Location = new System.Drawing.Point(165, 216);
            this.tbx_dec2.Name = "tbx_dec2";
            this.tbx_dec2.Size = new System.Drawing.Size(100, 20);
            this.tbx_dec2.TabIndex = 8;
            // 
            // tbx_oc
            // 
            this.tbx_oc.Location = new System.Drawing.Point(165, 172);
            this.tbx_oc.Name = "tbx_oc";
            this.tbx_oc.Size = new System.Drawing.Size(100, 20);
            this.tbx_oc.TabIndex = 9;
            // 
            // tbx_messagehex
            // 
            this.tbx_messagehex.Location = new System.Drawing.Point(437, 78);
            this.tbx_messagehex.Name = "tbx_messagehex";
            this.tbx_messagehex.ReadOnly = true;
            this.tbx_messagehex.Size = new System.Drawing.Size(100, 20);
            this.tbx_messagehex.TabIndex = 10;
            this.tbx_messagehex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_messagedec1
            // 
            this.tbx_messagedec1.Location = new System.Drawing.Point(437, 124);
            this.tbx_messagedec1.Name = "tbx_messagedec1";
            this.tbx_messagedec1.ReadOnly = true;
            this.tbx_messagedec1.Size = new System.Drawing.Size(100, 20);
            this.tbx_messagedec1.TabIndex = 11;
            this.tbx_messagedec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_messageoc
            // 
            this.tbx_messageoc.Location = new System.Drawing.Point(437, 172);
            this.tbx_messageoc.Name = "tbx_messageoc";
            this.tbx_messageoc.ReadOnly = true;
            this.tbx_messageoc.Size = new System.Drawing.Size(100, 20);
            this.tbx_messageoc.TabIndex = 12;
            this.tbx_messageoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_messagedec2
            // 
            this.tbx_messagedec2.Location = new System.Drawing.Point(437, 216);
            this.tbx_messagedec2.Name = "tbx_messagedec2";
            this.tbx_messagedec2.ReadOnly = true;
            this.tbx_messagedec2.Size = new System.Drawing.Size(100, 20);
            this.tbx_messagedec2.TabIndex = 13;
            this.tbx_messagedec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_dec1
            // 
            this.btn_dec1.Location = new System.Drawing.Point(314, 122);
            this.btn_dec1.Name = "btn_dec1";
            this.btn_dec1.Size = new System.Drawing.Size(75, 23);
            this.btn_dec1.TabIndex = 14;
            this.btn_dec1.Text = "Convertir";
            this.btn_dec1.UseVisualStyleBackColor = true;
            this.btn_dec1.Click += new System.EventHandler(this.btn_dechec_Click);
            // 
            // btn_dec2
            // 
            this.btn_dec2.Location = new System.Drawing.Point(314, 214);
            this.btn_dec2.Name = "btn_dec2";
            this.btn_dec2.Size = new System.Drawing.Size(75, 23);
            this.btn_dec2.TabIndex = 15;
            this.btn_dec2.Text = "Convertir";
            this.btn_dec2.UseVisualStyleBackColor = true;
            this.btn_dec2.Click += new System.EventHandler(this.btn_decoc_Click);
            // 
            // btn_oc
            // 
            this.btn_oc.Location = new System.Drawing.Point(314, 170);
            this.btn_oc.Name = "btn_oc";
            this.btn_oc.Size = new System.Drawing.Size(75, 23);
            this.btn_oc.TabIndex = 16;
            this.btn_oc.Text = "Convertir";
            this.btn_oc.UseVisualStyleBackColor = true;
            this.btn_oc.Click += new System.EventHandler(this.btn_ocdec_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 296);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(542, 150);
            this.dgvHistorial.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Historial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.btn_oc);
            this.Controls.Add(this.btn_dec2);
            this.Controls.Add(this.btn_dec1);
            this.Controls.Add(this.tbx_messagedec2);
            this.Controls.Add(this.tbx_messageoc);
            this.Controls.Add(this.tbx_messagedec1);
            this.Controls.Add(this.tbx_messagehex);
            this.Controls.Add(this.tbx_oc);
            this.Controls.Add(this.tbx_dec2);
            this.Controls.Add(this.tbx_dec1);
            this.Controls.Add(this.tbx_hex);
            this.Controls.Add(this.lbl_dec2);
            this.Controls.Add(this.lbl_oc);
            this.Controls.Add(this.lbl_dec1);
            this.Controls.Add(this.btn_hex);
            this.Controls.Add(this.lbl_hex);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "ventana";
            this.Text = "Conversor Numérico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_hex;
        private System.Windows.Forms.Button btn_hex;
        private System.Windows.Forms.Label lbl_dec1;
        private System.Windows.Forms.Label lbl_oc;
        private System.Windows.Forms.Label lbl_dec2;
        private System.Windows.Forms.TextBox tbx_hex;
        private System.Windows.Forms.TextBox tbx_dec1;
        private System.Windows.Forms.TextBox tbx_dec2;
        private System.Windows.Forms.TextBox tbx_oc;
        private System.Windows.Forms.TextBox tbx_messagehex;
        private System.Windows.Forms.TextBox tbx_messagedec1;
        private System.Windows.Forms.TextBox tbx_messageoc;
        private System.Windows.Forms.TextBox tbx_messagedec2;
        private System.Windows.Forms.Button btn_dec1;
        private System.Windows.Forms.Button btn_dec2;
        private System.Windows.Forms.Button btn_oc;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label1;
    }
}

