namespace pryGiovannettiSP4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        //Declaración de Matriz
        float[,] vecDatos = new float[5, 4];

        int fila = 0;
        int col = 0;
        int importeMozo = 0;
        string mozoVenta = "";
        int contador = 0;
        int totalCom = 0;
        int totalBebAlcohol = 0;
        int totalBebida = 0;
        int totalPostre = 0;
        int totalFinal = 0;
        int totalAux = 0;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add("Julio", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Esteban", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Javier", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Gonzalo", 0, 0, 0, 0);
            dgvDatos.Rows.Add("Alberto", 0, 0, 0, 0);
        }
        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private bool ValidarDatos()
        {
            float valorTemporal;
            bool datosCorrectos = true;

            //Recorrido de la grilla fila, columna
            for (fila = 0; fila < 5; fila++)
            {
                // Los datos de venta comienzan en la columna 1, por eso col = 1
                for (col = 1; col < 5; col++)
                {
                    object celda = dgvDatos.Rows[fila].Cells[col].Value;

                    //Convertir a string (si es nulo, usar cadena vacía)
                    string textoCelda = (celda == null) ? "" : celda.ToString();

                    //Intentar parsear a float (Validación numérica)
                    if (float.TryParse(textoCelda, out valorTemporal))
                    {
                        //Guardar en la matriz (la matriz va de 0 a 3, la grilla de 1 a 4)
                        vecDatos[fila, col - 1] = valorTemporal;
                        dgvDatos.Rows[fila].Cells[col].Style.BackColor = Color.White;
                    }
                    else
                    {
                        // Marcamos el error y resaltamos la celda
                        datosCorrectos = false;
                        dgvDatos.Rows[fila].Cells[col].Style.BackColor = Color.LightCoral;
                    }
                }
            }

            //Resultado final y control de botones (después de terminar los bucles)
            if (datosCorrectos)
            {
                MessageBox.Show("¡Datos válidos! Consultas habilitadas.", "Validación OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTotal.Enabled = true;
                btnMozo.Enabled = true;
                btnValidarDatos.Enabled = false;
                return true; // Retorno de éxito
            }
            else
            {
                MessageBox.Show("Error: Corrija los valores resaltados (deben ser numéricos).", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnTotal.Enabled = false;
                btnMozo.Enabled = false;
                return false; // Retorno de fallo
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            for (fila = 0; fila < 5; fila++)
            {
                contador = 0;
                for (col = 1; col < 5; col++)
                {
                    contador += Convert.ToInt32(dgvDatos.Rows[fila].Cells[col].Value);
                }

                if (contador > importeMozo)
                {
                    importeMozo = contador;
                    mozoVenta = Convert.ToString(dgvDatos.Rows[fila].Cells[0].Value);
                }
            }
            lblImporteTotal.Text = Convert.ToString(importeMozo);
            lblNombreMozo.Text = mozoVenta;
            importeMozo = 0;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            for (col = 1; col < 5; col++)
            {
                totalAux = 0;
                for (fila = 0; fila < 5; fila++)
                {
                    totalAux += Convert.ToInt32(dgvDatos.Rows[fila].Cells[col].Value);
                }
                switch (col)
                {
                    case 1:
                        totalCom = totalAux;
                        break;
                    case 2:
                        totalBebAlcohol = totalAux;
                        break;
                    case 3:
                        totalBebAlcohol = totalAux;
                        break;
                    case 4:
                        totalPostre = totalAux;
                        break;
                }
            }

            totalFinal = totalCom + totalBebAlcohol + totalPostre + totalBebAlcohol;

            //Limpiamos primero el contenido de la lbl
            lstResultado.Items.Clear();

            //Muestro el resultado
            lstResultado.Items.Add("Ventas por categoría:");
            lstResultado.Items.Add("-------------------------");
            lstResultado.Items.Add("Comida: " + totalCom);
            lstResultado.Items.Add("Bebidas con alcohol: " + totalBebAlcohol);
            lstResultado.Items.Add("Bebidas sin alcohol: " + totalBebAlcohol);
            lstResultado.Items.Add("Postres: " + totalPostre);
            lstResultado.Items.Add("-------------------------");
            lstResultado.Items.Add("TOTAL GENERAL: " + totalFinal);
        }
    }
}
