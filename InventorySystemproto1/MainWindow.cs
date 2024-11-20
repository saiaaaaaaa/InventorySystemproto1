using System.Windows.Forms;

namespace InventorySystemproto1
{
    public partial class MainWindow : Form
    {
        Dashboard dashboard = new Dashboard();
        Inventory inventory = new Inventory();

        public MainWindow(Startup startup)
        {
            InitializeComponent();

            startup.Hide();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;

            dashboard.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            inventory.Hide();
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;

            dashboard.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            dashboard.Hide();
            inventory.MdiParent = this;
            inventory.Dock = DockStyle.Fill;

            inventory.Show();
        }
    }
}
