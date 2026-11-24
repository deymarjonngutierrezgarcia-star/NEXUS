using Misión_2_Nexus_V2._0;
namespace NEXUS.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Escribe tu nombre para iniciar la partida.", "NEXUS");
                txtNombre.Focus();
                return;
            }
            if (nombre.Length < 3 || nombre.Length > 20)
            {
                MessageBox.Show("El nombre debe tener entre 3 y 20 caracteres.", "NEXUS");
                txtNombre.Focus();
                txtNombre.SelectAll();
                return;
            }
            try
            {
                var bd = new ConexionBD();
                int id = bd.GuardarPartida(nombre, 1, 100, "En curso");
                MessageBox.Show($"Partida guardada con ID: {id}", "NEXUS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la partida:\n" + ex.Message, "NEXUS");
            }
        }

        private void btnExploradores_Click(object sender, EventArgs e)
        {
            try
            {
                var bd = new ConexionBD();
                var partidas = bd.ObtenerPartidas();

                if (partidas.Count == 0)
                {
                    MessageBox.Show("No hay partidas guardadas.", "NEXUS");
                    return;
                }

                var sb = new System.Text.StringBuilder();
                int max = Math.Min(partidas.Count, 10);
                for (int i = 0; i < max; i++)
                {
                    var p = partidas[i];
                    sb.AppendLine($"#{p.IdPartida} | {p.NombreJugador} | Nivel {p.Nivel} | {p.Puntuacion} pts | {p.EstadoActual} | {p.FechaGuardado:dd/MM/yyyy HH:mm}");
                }

                MessageBox.Show(sb.ToString(), "NEXUS - Últimas partidas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con SQL Server:\n" + ex.Message, "NEXUS");
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEXUS - Versión Windows Forms 1.0\nAutor: Jhonn Deymar Gutierrez Garcia",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
