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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            btnTotal = new Button();
            btnCerrar = new Button();
            lblMozoDelDia = new Label();
            lblNombreMozo = new Label();
            lblImporteTotal = new Label();
            lstResultado = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblDatosDeVenta
            // 
            lblDatosDeVenta.AutoSize = true;
            lblDatosDeVenta.BackColor = Color.White;
            lblDatosDeVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosDeVenta.ForeColor = Color.Black;
            lblDatosDeVenta.Location = new Point(10, 7);
            lblDatosDeVenta.Name = "lblDatosDeVenta";
            lblDatosDeVenta.Size = new Size(178, 25);
            lblDatosDeVenta.TabIndex = 0;
            lblDatosDeVenta.Text = "Ingrese Sus Ventas";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, ColBebidaAlc, ColBebidasSinAlc, ColPostres });
            dgvDatos.Location = new Point(10, 56);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(544, 150);
            dgvDatos.TabIndex = 1;
            // 
            // colMozos
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            colMozos.DefaultCellStyle = dataGridViewCellStyle2;
            colMozos.HeaderText = "Mozos";
            colMozos.MinimumWidth = 6;
            colMozos.Name = "colMozos";
            colMozos.Width = 125;
            // 
            // colComidas
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            colComidas.DefaultCellStyle = dataGridViewCellStyle3;
            colComidas.HeaderText = "Comidas";
            colComidas.MinimumWidth = 6;
            colComidas.Name = "colComidas";
            colComidas.Width = 125;
            // 
            // ColBebidaAlc
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            ColBebidaAlc.DefaultCellStyle = dataGridViewCellStyle4;
            ColBebidaAlc.HeaderText = "Bebidas Con Alcohol";
            ColBebidaAlc.MinimumWidth = 6;
            ColBebidaAlc.Name = "ColBebidaAlc";
            ColBebidaAlc.Width = 125;
            // 
            // ColBebidasSinAlc
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            ColBebidasSinAlc.DefaultCellStyle = dataGridViewCellStyle5;
            ColBebidasSinAlc.HeaderText = "Bebidas Sin Alcohol";
            ColBebidasSinAlc.MinimumWidth = 6;
            ColBebidasSinAlc.Name = "ColBebidasSinAlc";
            ColBebidasSinAlc.Width = 125;
            // 
            // ColPostres
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            ColPostres.DefaultCellStyle = dataGridViewCellStyle6;
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
            lblTotalGeneral.Location = new Point(10, 267);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(115, 21);
            lblTotalGeneral.TabIndex = 2;
            lblTotalGeneral.Text = "Total General:";
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.BackColor = Color.Peru;
            btnValidarDatos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarDatos.ForeColor = Color.White;
            btnValidarDatos.Location = new Point(146, 338);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(116, 37);
            btnValidarDatos.TabIndex = 3;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = false;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozo
            // 
            btnMozo.BackColor = Color.Peru;
            btnMozo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMozo.ForeColor = Color.White;
            btnMozo.Location = new Point(296, 338);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(116, 37);
            btnMozo.TabIndex = 4;
            btnMozo.Text = "Mozo Del dia ";
            btnMozo.UseVisualStyleBackColor = false;
            btnMozo.Click += btnMozo_Click;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.Peru;
            btnTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotal.Location = new Point(438, 338);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(116, 37);
            btnTotal.TabIndex = 5;
            btnTotal.Text = "Totales";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Peru;
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(10, 338);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 37);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMozoDelDia.ForeColor = Color.Black;
            lblMozoDelDia.Location = new Point(10, 226);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(117, 21);
            lblMozoDelDia.TabIndex = 8;
            lblMozoDelDia.Text = "Mozo Del Dia:";
            // 
            // lblNombreMozo
            // 
            lblNombreMozo.AutoSize = true;
            lblNombreMozo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreMozo.ForeColor = Color.Black;
            lblNombreMozo.Location = new Point(146, 230);
            lblNombreMozo.Name = "lblNombreMozo";
            lblNombreMozo.Size = new Size(45, 19);
            lblNombreMozo.TabIndex = 9;
            lblNombreMozo.Text = ". . . . .";
            // 
            // lblImporteTotal
            // 
            lblImporteTotal.AutoSize = true;
            lblImporteTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImporteTotal.ForeColor = Color.Black;
            lblImporteTotal.Location = new Point(217, 230);
            lblImporteTotal.Name = "lblImporteTotal";
            lblImporteTotal.Size = new Size(45, 19);
            lblImporteTotal.TabIndex = 10;
            lblImporteTotal.Text = ". . . . .";
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(146, 267);
            lstResultado.Margin = new Padding(3, 2, 3, 2);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(229, 49);
            lstResultado.TabIndex = 11;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 404);
            Controls.Add(lstResultado);
            Controls.Add(lblImporteTotal);
            Controls.Add(lblNombreMozo);
            Controls.Add(lblMozoDelDia);
            Controls.Add(btnCerrar);
            Controls.Add(btnTotal);
            Controls.Add(btnMozo);
            Controls.Add(btnValidarDatos);
            Controls.Add(lblTotalGeneral);
            Controls.Add(dgvDatos);
            Controls.Add(lblDatosDeVenta);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas La Milanga";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosDeVenta;
        private DataGridView dgvDatos;
        private Label lblTotalGeneral;
        private Button btnValidarDatos;
        private Button btnMozo;
        private Button btnTotal;
        private Button btnCerrar;
        private Label lblMozoDelDia;
        private Label lblNombreMozo;
        private Label lblImporteTotal;
        private ListBox lstResultado;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn ColBebidaAlc;
        private DataGridViewTextBoxColumn ColBebidasSinAlc;
        private DataGridViewTextBoxColumn ColPostres;
    }
}
