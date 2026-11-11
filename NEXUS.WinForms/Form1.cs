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
            MessageBox.Show("Módulo de entrenamiento (próximamente)", "NEXUS");
        }

        private void btnExploradores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro de exploradores (próximamente)", "NEXUS");
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
