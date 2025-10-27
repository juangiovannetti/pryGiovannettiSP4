namespace pryGiovannettiSP4
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblDatosDeVenta = new Label();
            dgvDatos = new DataGridView();
            colMozos = new DataGridViewTextBoxColumn();
            colComidas = new DataGridViewTextBoxColumn();
            ColBebidaAlc = new DataGridViewTextBoxColumn();
            ColBebidasSinAlc = new DataGridViewTextBoxColumn();
            ColPostres = new DataGridViewTextBoxColumn();
            lblTotalGeneral = new Label();
            btnValidarDatos = new Button();
            btnMozo = new Button();
            btnImporteTotal = new Button();
            btnCerrar = new Button();
            lblTotal = new Label();
            lblMozoDelDia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblDatosDeVenta
            // 
            lblDatosDeVenta.AutoSize = true;
            lblDatosDeVenta.BackColor = Color.White;
            lblDatosDeVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosDeVenta.ForeColor = Color.Black;
            lblDatosDeVenta.Location = new Point(22, 21);
            lblDatosDeVenta.Name = "lblDatosDeVenta";
            lblDatosDeVenta.Size = new Size(178, 25);
            lblDatosDeVenta.TabIndex = 0;
            lblDatosDeVenta.Text = "Ingrese Sus Ventas";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, ColBebidaAlc, ColBebidasSinAlc, ColPostres });
            dgvDatos.Location = new Point(22, 70);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(544, 150);
            dgvDatos.TabIndex = 1;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.Name = "colMozos";
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.Name = "colComidas";
            // 
            // ColBebidaAlc
            // 
            ColBebidaAlc.HeaderText = "Bebidas Con Alcohol";
            ColBebidaAlc.Name = "ColBebidaAlc";
            // 
            // ColBebidasSinAlc
            // 
            ColBebidasSinAlc.HeaderText = "Bebidas Sin Alcohol";
            ColBebidasSinAlc.Name = "ColBebidasSinAlc";
            // 
            // ColPostres
            // 
            ColPostres.HeaderText = "Postres";
            ColPostres.Name = "ColPostres";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.BackColor = Color.White;
            lblTotalGeneral.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGeneral.ForeColor = Color.Black;
            lblTotalGeneral.Location = new Point(22, 271);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(115, 21);
            lblTotalGeneral.TabIndex = 2;
            lblTotalGeneral.Text = "Total General:";
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.BackColor = Color.BurlyWood;
            btnValidarDatos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarDatos.ForeColor = Color.White;
            btnValidarDatos.Location = new Point(161, 314);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(101, 37);
            btnValidarDatos.TabIndex = 3;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = false;
            // 
            // btnMozo
            // 
            btnMozo.BackColor = Color.BurlyWood;
            btnMozo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMozo.ForeColor = Color.White;
            btnMozo.Location = new Point(310, 314);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(101, 37);
            btnMozo.TabIndex = 4;
            btnMozo.Text = "Mozo Del dia ";
            btnMozo.UseVisualStyleBackColor = false;
            // 
            // btnImporteTotal
            // 
            btnImporteTotal.BackColor = Color.BurlyWood;
            btnImporteTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImporteTotal.Location = new Point(465, 314);
            btnImporteTotal.Name = "btnImporteTotal";
            btnImporteTotal.Size = new Size(101, 37);
            btnImporteTotal.TabIndex = 5;
            btnImporteTotal.Text = "Totales";
            btnImporteTotal.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.BurlyWood;
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(22, 314);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 37);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(140, 275);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 17);
            lblTotal.TabIndex = 7;
            lblTotal.Text = ". . . . . . .";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMozoDelDia.ForeColor = Color.Black;
            lblMozoDelDia.Location = new Point(20, 241);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(117, 21);
            lblMozoDelDia.TabIndex = 8;
            lblMozoDelDia.Text = "Mozo Del Dia:";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 413);
            Controls.Add(lblMozoDelDia);
            Controls.Add(lblTotal);
            Controls.Add(btnCerrar);
            Controls.Add(btnImporteTotal);
            Controls.Add(btnMozo);
            Controls.Add(btnValidarDatos);
            Controls.Add(lblTotalGeneral);
            Controls.Add(dgvDatos);
            Controls.Add(lblDatosDeVenta);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            Text = "Ventas La Milanga";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosDeVenta;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn ColBebidaAlc;
        private DataGridViewTextBoxColumn ColBebidasSinAlc;
        private DataGridViewTextBoxColumn ColPostres;
        private Label lblTotalGeneral;
        private Button btnValidarDatos;
        private Button btnMozo;
        private Button btnImporteTotal;
        private Button btnCerrar;
        private Label lblTotal;
        private Label lblMozoDelDia;
    }
}
