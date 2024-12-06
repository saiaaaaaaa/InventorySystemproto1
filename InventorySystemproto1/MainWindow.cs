using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;

namespace InventorySystemproto1
{
    public partial class MainWindow : Form
    {
        List<Form> forms = new List<Form>();
        List<Button> tabs = new List<Button>();
        bool typed = false;
        int currentForm = 0;

        Inventory inventory = new Inventory();
        Sales sales = new Sales();
        OrderHistory orderHistory = new OrderHistory();

        public MainWindow(Startup startup)
        {
            InitializeComponent();
            DoubleBuffered = true;
            startup.Hide();

            tabs.Add(button1);
            tabs.Add(button2);
            tabs.Add(button3);
            tabs.Add(button4);
            tabs.Add(button5);

            forms.Add(new Dashboard());
            forms.Add(inventory);
            forms.Add(sales);
            forms.Add(orderHistory);
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
            currentForm = activeForm;
            searchTerm = guna2TextBox1.Text;
            tabs[activeForm].BackColor = Color.Transparent;
            tabs[activeForm].ForeColor = Color.Black;
            
            foreach (Button b in tabs)
            {
                if (b != tabs[activeForm])
                {
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.White;
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

            switch (currentForm)
            {
                case 1:
                    inventory.RefreshData();
                    break;
                case 3:
                    orderHistory.BindData();
                    break;
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            ChangeForm(3);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            ChangeForm(4);
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            ChangeForm(0);
        }

        private void button2_Click_1(object sender, System.EventArgs e)
        {
            ChangeForm(1);
        }

        private void button3_Click_1(object sender, System.EventArgs e)
        {
            ChangeForm(2);
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!typed && (currentForm != 1 || currentForm != 2 || currentForm != 3))
            {
                ChangeForm(1);
                guna2TextBox1.Focus();
                typed = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            searchTerm = guna2TextBox1.Text;

            switch (currentForm)
            {
                case 1:
                    inventory.RefreshData();
                    break;
                case 3:
                    orderHistory.BindData();
                    break;
            }
        }
    }
}
