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
            lblMozoDelDia = new Label();
            lblMozoGanador = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblDatosDeVenta
            // 
            lblDatosDeVenta.AutoSize = true;
            lblDatosDeVenta.BackColor = Color.White;
            lblDatosDeVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosDeVenta.ForeColor = Color.Black;
            lblDatosDeVenta.Location = new Point(25, 28);
            lblDatosDeVenta.Name = "lblDatosDeVenta";
            lblDatosDeVenta.Size = new Size(227, 32);
            lblDatosDeVenta.TabIndex = 0;
            lblDatosDeVenta.Text = "Ingrese Sus Ventas";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, ColBebidaAlc, ColBebidasSinAlc, ColPostres });
            dgvDatos.Location = new Point(25, 93);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(622, 200);
            dgvDatos.TabIndex = 1;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.MinimumWidth = 6;
            colMozos.Name = "colMozos";
            colMozos.Width = 125;
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.MinimumWidth = 6;
            colComidas.Name = "colComidas";
            colComidas.Width = 125;
            // 
            // ColBebidaAlc
            // 
            ColBebidaAlc.HeaderText = "Bebidas Con Alcohol";
            ColBebidaAlc.MinimumWidth = 6;
            ColBebidaAlc.Name = "ColBebidaAlc";
            ColBebidaAlc.Width = 125;
            // 
            // ColBebidasSinAlc
            // 
            ColBebidasSinAlc.HeaderText = "Bebidas Sin Alcohol";
            ColBebidasSinAlc.MinimumWidth = 6;
            ColBebidasSinAlc.Name = "ColBebidasSinAlc";
            ColBebidasSinAlc.Width = 125;
            // 
            // ColPostres
            // 
            ColPostres.HeaderText = "Postres";
            ColPostres.MinimumWidth = 6;
            ColPostres.Name = "ColPostres";
            ColPostres.Width = 125;
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.BackColor = Color.White;
            lblTotalGeneral.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGeneral.ForeColor = Color.Black;
            lblTotalGeneral.Location = new Point(307, 499);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(143, 28);
            lblTotalGeneral.TabIndex = 2;
            lblTotalGeneral.Text = "Total General:";
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.BackColor = Color.BurlyWood;
            btnValidarDatos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarDatos.ForeColor = Color.White;
            btnValidarDatos.Location = new Point(119, 313);
            btnValidarDatos.Margin = new Padding(3, 4, 3, 4);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(133, 49);
            btnValidarDatos.TabIndex = 3;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = false;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozo
            // 
            btnMozo.BackColor = Color.BurlyWood;
            btnMozo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMozo.ForeColor = Color.White;
            btnMozo.Location = new Point(25, 415);
            btnMozo.Margin = new Padding(3, 4, 3, 4);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(133, 49);
            btnMozo.TabIndex = 4;
            btnMozo.Text = "Mozo Del dia ";
            btnMozo.UseVisualStyleBackColor = false;
            // 
            // btnImporteTotal
            // 
            btnImporteTotal.BackColor = Color.BurlyWood;
            btnImporteTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImporteTotal.Location = new Point(25, 491);
            btnImporteTotal.Margin = new Padding(3, 4, 3, 4);
            btnImporteTotal.Name = "btnImporteTotal";
            btnImporteTotal.Size = new Size(133, 49);
            btnImporteTotal.TabIndex = 5;
            btnImporteTotal.Text = "Totales";
            btnImporteTotal.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.BurlyWood;
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(532, 560);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(115, 49);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMozoDelDia.ForeColor = Color.Black;
            lblMozoDelDia.Location = new Point(304, 436);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(146, 28);
            lblMozoDelDia.TabIndex = 8;
            lblMozoDelDia.Text = "Mozo Del Dia:";
            // 
            // lblMozoGanador
            // 
            lblMozoGanador.AutoSize = true;
            lblMozoGanador.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMozoGanador.ForeColor = Color.Black;
            lblMozoGanador.Location = new Point(473, 441);
            lblMozoGanador.Name = "lblMozoGanador";
            lblMozoGanador.Size = new Size(55, 23);
            lblMozoGanador.TabIndex = 9;
            lblMozoGanador.Text = ". . . . .";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(473, 504);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 23);
            lblTotal.TabIndex = 10;
            lblTotal.Text = ". . . . .";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 619);
            Controls.Add(lblTotal);
            Controls.Add(lblMozoGanador);
            Controls.Add(lblMozoDelDia);
            Controls.Add(btnCerrar);
            Controls.Add(btnImporteTotal);
            Controls.Add(btnMozo);
            Controls.Add(btnValidarDatos);
            Controls.Add(lblTotalGeneral);
            Controls.Add(dgvDatos);
            Controls.Add(lblDatosDeVenta);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicio";
            Text = "Ventas La Milanga";
            Load += frmInicio_Load;
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
        private Label lblMozoDelDia;
        private Label lblMozoGanador;
        private Label lblTotal;
    }
}
