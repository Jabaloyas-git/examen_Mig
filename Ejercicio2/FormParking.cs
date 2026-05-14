using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2_Parking
{
    public partial class FormParking : Form
    {
        // Matriz bidimensional 2 filas x 4 columnas
        private Button[,] plazas = new Button[2, 4];

        private const int FILAS    = 2;
        private const int COLUMNAS = 4;
        private const int BTN_W    = 120;
        private const int BTN_H    = 80;
        private const int ORIG_X   = 30;
        private const int ORIG_Y   = 90;
        private const int GAP_X    = 14;
        private const int GAP_Y    = 14;

        private static readonly Color COLOR_LIBRE   = Color.SeaGreen;
        private static readonly Color COLOR_OCUPADA = Color.Firebrick;

        public FormParking()
        {
            InitializeComponent();
            CrearBotonesPlazas();
        }

        private void CrearBotonesPlazas()
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int col = 0; col < COLUMNAS; col++)
                {
                    Button btn = new Button();
                    btn.Text      = string.Format("P-{0},{1}", fila, col);
                    btn.Size      = new Size(BTN_W, BTN_H);
                    btn.Location  = new Point(ORIG_X + col * (BTN_W + GAP_X),
                                              ORIG_Y + fila * (BTN_H + GAP_Y));
                    btn.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
                    btn.BackColor = COLOR_LIBRE;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Tag       = new int[] { fila, col };
                    btn.Click    += new EventHandler(Plaza_Click);

                    plazas[fila, col] = btn;
                    this.Controls.Add(btn);
                }
            }
            ActualizarContador();
        }

        private void Plaza_Click(object sender, EventArgs e)
        {
            Button btn    = (Button)sender;
            int[]  coords = (int[])btn.Tag;
            int    fila   = coords[0];
            int    col    = coords[1];

            if (btn.BackColor == COLOR_OCUPADA)
            {
                btn.BackColor = COLOR_LIBRE;
                btn.Text      = string.Format("P-{0},{1}", fila, col);
                MessageBox.Show(
                    string.Format("Plaza [{0},{1}] liberada correctamente.", fila, col),
                    "Plaza libre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn.BackColor = COLOR_OCUPADA;
                btn.Text      = string.Empty;
                MessageBox.Show(
                    string.Format("Vehículo aparcado correctamente en la plaza [{0},{1}]", fila, col),
                    "Plaza ocupada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ActualizarContador();
        }

        private void ActualizarContador()
        {
            int ocupadas = 0;
            for (int f = 0; f < FILAS; f++)
                for (int c = 0; c < COLUMNAS; c++)
                    if (plazas[f, c].BackColor == COLOR_OCUPADA)
                        ocupadas++;

            int total = FILAS * COLUMNAS;
            lblEstado.Text = string.Format(
                "Ocupadas: {0} / {1}   |   Libres: {2}", ocupadas, total, total - ocupadas);
        }
    }
}
