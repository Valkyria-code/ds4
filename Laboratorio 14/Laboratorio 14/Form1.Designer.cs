namespace Laboratorio_14
{
    partial class frm_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_nuevo = new System.Windows.Forms.ToolStripButton();
            this.tsb_guardar = new System.Windows.Forms.ToolStripButton();
            this.tsb_cancelar = new System.Windows.Forms.ToolStripButton();
            this.tsb_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsl_buscar = new System.Windows.Forms.ToolStripLabel();
            this.tst_id = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_buscar = new System.Windows.Forms.ToolStripButton();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_nuevo,
            this.tsb_guardar,
            this.tsb_cancelar,
            this.tsb_eliminar,
            this.toolStripSeparator1,
            this.tsl_buscar,
            this.tst_id,
            this.tsb_buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_nuevo
            // 
            this.tsb_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_nuevo.Image")));
            this.tsb_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_nuevo.Name = "tsb_nuevo";
            this.tsb_nuevo.Size = new System.Drawing.Size(23, 22);
            this.tsb_nuevo.Text = "Nuevo";
            this.tsb_nuevo.Click += new System.EventHandler(this.tsb_nuevo_Click);
            // 
            // tsb_guardar
            // 
            this.tsb_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_guardar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_guardar.Image")));
            this.tsb_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_guardar.Name = "tsb_guardar";
            this.tsb_guardar.Size = new System.Drawing.Size(23, 22);
            this.tsb_guardar.Text = "Guardar";
            this.tsb_guardar.Click += new System.EventHandler(this.tsb_guardar_Click);
            // 
            // tsb_cancelar
            // 
            this.tsb_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cancelar.Image")));
            this.tsb_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cancelar.Name = "tsb_cancelar";
            this.tsb_cancelar.Size = new System.Drawing.Size(23, 22);
            this.tsb_cancelar.Text = "Cancelar";
            this.tsb_cancelar.Click += new System.EventHandler(this.tsb_cancelar_Click);
            // 
            // tsb_eliminar
            // 
            this.tsb_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_eliminar.Image")));
            this.tsb_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_eliminar.Name = "tsb_eliminar";
            this.tsb_eliminar.Size = new System.Drawing.Size(23, 22);
            this.tsb_eliminar.Text = "Eliminar";
            this.tsb_eliminar.Click += new System.EventHandler(this.tsb_eliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsl_buscar
            // 
            this.tsl_buscar.Name = "tsl_buscar";
            this.tsl_buscar.Size = new System.Drawing.Size(80, 22);
            this.tsl_buscar.Text = "Buscar por ID:";
            this.tsl_buscar.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tst_id
            // 
            this.tst_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_id.Name = "tst_id";
            this.tst_id.Size = new System.Drawing.Size(100, 25);
            // 
            // tsb_buscar
            // 
            this.tsb_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_buscar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_buscar.Image")));
            this.tsb_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_buscar.Name = "tsb_buscar";
            this.tsb_buscar.Size = new System.Drawing.Size(23, 22);
            this.tsb_buscar.Text = "Buscar";
            this.tsb_buscar.Click += new System.EventHandler(this.tsb_buscar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(164, 50);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(164, 117);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(35, 13);
            this.lbl_stock.TabIndex = 2;
            this.lbl_stock.Text = "Stock";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(15, 117);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(15, 50);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(167, 72);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(380, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(18, 140);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(167, 140);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(18, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 8;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(18, 184);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(87, 32);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 225);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frm_productos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_nuevo;
        private System.Windows.Forms.ToolStripButton tsb_guardar;
        private System.Windows.Forms.ToolStripButton tsb_cancelar;
        private System.Windows.Forms.ToolStripButton tsb_eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsl_buscar;
        private System.Windows.Forms.ToolStripTextBox tst_id;
        private System.Windows.Forms.ToolStripButton tsb_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_salir;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

