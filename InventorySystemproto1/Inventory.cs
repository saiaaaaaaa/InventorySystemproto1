using System.Collections.Generic;
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
            DoubleBuffered = true;

            RefreshData();
        }

        public void RefreshData()
        {
            bindingSource.Clear();

            List<InventoryItem> temp = new List<InventoryItem>();
            foreach (InventoryItem item in inventoryList)
            {
                if (searchTerm != string.Empty && (item.Brand.Contains(searchTerm.ToUpper()) || item.Model.Contains(searchTerm.ToUpper()) || item.Category.Contains(searchTerm.ToUpper())))
                {
                    temp.Add(item);
                }
                else if (searchTerm == string.Empty)
                {
                    temp.Add(item);
                }
            }
            if (temp.Count > 0)
            {
                foreach (InventoryItem item in temp)
                {
                    bindingSource.Add(item);
                }
                dataGridView1.DataSource = bindingSource;
            }
        }
    }
}
