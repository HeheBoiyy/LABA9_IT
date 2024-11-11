using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA9_IT
{
    public partial class ShowSpecificShops : Form
    {
        public ShowSpecificShops()
        {
            InitializeComponent();
            LoadOwnersToComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxOwners.SelectedValue != null)
            {
                int selectedOwnerId = (int)comboBoxOwners.SelectedValue;

                using (ShopDataContext db = new ShopDataContext())
                {
                    var stores = from store in db.Stores
                                 where store.OwnerId == selectedOwnerId
                                 select new
                                 {
                                     store.Name,
                                     store.Profile,
                                     store.Capital
                                 };

                    dataGridView1.DataSource = stores.ToList();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите владельца.");
            }
        }
        private void LoadOwnersToComboBox()
        {
            using (ShopDataContext db = new ShopDataContext())
            {
                var owners = db.Owners.Select(o => new { o.Id, o.FullName }).ToList();
                comboBoxOwners.DataSource = owners;
                comboBoxOwners.DisplayMember = "FullName";
                comboBoxOwners.ValueMember = "Id";
            }
        }
    }
}
