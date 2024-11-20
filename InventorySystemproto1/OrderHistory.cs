using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using static InventorySystemproto1.Customs;

namespace InventorySystemproto1
{
    public partial class OrderHistory : Form
    {
        BindingSource bindingSource = new BindingSource();

        public OrderHistory()
        {
            InitializeComponent();

            if (orderList.Count > 0)
            {
                foreach (OrderItem item in orderList)
                {
                    bindingSource.Add(item);
                }

                dataGridView1.DataSource = bindingSource;
            }
        }
    }
}
