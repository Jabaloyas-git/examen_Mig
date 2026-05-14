using System;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio1_Tienda
{
    public partial class FormResumen : Form
    {
        private double[] precios;
        private int cantidad;

        public FormResumen(double[] precios, int cantidad)
        {
            this.precios = precios;
            this.cantidad = cantidad;
            InitializeComponent();
            MostrarResumen();
        }

        private void MostrarResumen()
        {
            StringBuilder sb = new StringBuilder();
            double total = 0;

            for (int i = 0; i < cantidad; i++)
            {
                sb.AppendLine(string.Format("  Artículo {0}:   {1:F2} €", i + 1, precios[i]));
                total += precios[i];
            }

            lblDetalle.Text = sb.ToString();
            lblTotal.Text = string.Format("TOTAL A PAGAR:   {0:F2} €", total);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
