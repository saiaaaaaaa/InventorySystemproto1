using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystemproto1
{
    public partial class MainWindow : Form
    {
        Dashboard dashboard = new Dashboard();
        Inventory inventory = new Inventory();
        List<Button> tabs = new List<Button>();

        public MainWindow(Startup startup)
        {
            InitializeComponent();

            startup.Hide();

            tabs.Add(button1);
            tabs.Add(button2);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            ChangeColor(0);

            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;

            dashboard.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ChangeColor(0);

            inventory.Hide();
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;

            dashboard.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ChangeColor(1);

            dashboard.Hide();
            inventory.MdiParent = this;
            inventory.Dock = DockStyle.Fill;

            inventory.Show();
        }

        void ChangeColor(int activeForm)
        {
            tabs[activeForm].BackColor = Color.Green;
            tabs[activeForm].ForeColor = Color.White;
            foreach (Button b in tabs)
            {
                if (b != tabs[activeForm])
                {
                    b.BackColor = SystemColors.Control;
                    b.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}
