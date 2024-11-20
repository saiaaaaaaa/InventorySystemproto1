using System.Linq;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using static InventorySystemproto1.Customs;

namespace InventorySystemproto1
{
    public partial class Inventory : Form
    {
        BindingSource bindingSource = new BindingSource();

        public Inventory()
        {
            InitializeComponent();

            if (inventoryList.Count > 0)
            {
                foreach (InventoryItem item in inventoryList)
                {
                    bindingSource.Add(item);
                }

                dataGridView1.DataSource = bindingSource;
                //dataGridView1.Columns[0].ReadOnly = true;
                //dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
            }
        }
    }
}
