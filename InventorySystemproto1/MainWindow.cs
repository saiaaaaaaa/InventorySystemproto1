using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystemproto1
{
    public partial class MainWindow : Form
    {
        List<Form> forms = new List<Form>();
        List<Button> tabs = new List<Button>();

        public MainWindow(Startup startup)
        {
            InitializeComponent();

            startup.Hide();

            tabs.Add(button1);
            tabs.Add(button2);
            tabs.Add(button3);
            tabs.Add(button4);
            tabs.Add(button5);

            forms.Add(new Dashboard());
            forms.Add(new Inventory());
            forms.Add(new Sales());
            forms.Add(new OrderHistory());
            forms.Add(new AboutUs());
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            ChangeForm(0);
        }

        void ChangeForm(int activeForm)
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

            foreach (Form f in forms)
            {
                if (f != forms[activeForm])
                {
                    f.Hide();
                }
                else
                {
                    f.MdiParent = this;
                    f.Dock = DockStyle.Fill;

                    f.Show();
                }

            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ChangeForm(0);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ChangeForm(1);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            ChangeForm(2);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            ChangeForm(3);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            ChangeForm(4);
        }
    }
}
