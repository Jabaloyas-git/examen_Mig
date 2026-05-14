using System;
using System.Windows.Forms;

namespace Ejercicio1_Tienda
{
    public partial class FormPrincipal : Form
    {
        private double[] precios = new double[5];
        private int productoActual = 0;
        private const int MAX_PRODUCTOS = 5;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            if (productoActual >= MAX_PRODUCTOS)
            {
                MessageBox.Show("La cesta ya tiene 5 artículos.\nPulsa Finalizar compra.",
                    "Cesta llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double precio;
            string texto = txtPrecio.Text.Replace(',', '.');
            if (!double.TryParse(texto,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out precio) || precio < 0)
            {
                MessageBox.Show("Introduce un precio válido (número positivo).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }

            precios[productoActual] = precio;
            productoActual++;

            lstProductos.Items.Add(string.Format("  Artículo {0}:   {1:F2} €", productoActual, precio));
            lblContador.Text = string.Format("Productos escaneados: {0} / {1}", productoActual, MAX_PRODUCTOS);
            txtPrecio.Clear();
            txtPrecio.Focus();

            if (productoActual == MAX_PRODUCTOS)
            {
                btnEscanear.Enabled = false;
                lblContador.Text = "Cesta completa (5/5). Pulsa Finalizar compra.";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (productoActual == 0)
            {
                MessageBox.Show("No hay ningún producto en la cesta.",
                    "Cesta vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormResumen f = new FormResumen(precios, productoActual);
            f.ShowDialog();
        }
    }
}
