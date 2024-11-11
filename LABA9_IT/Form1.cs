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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateTable()
        {
            using (var db = new ShopDataContext())
            {
                // Извлекаем данные о владельцах
                var owners = from o in db.Owners
                             select new
                             {
                                 Id = o.Id,
                                 FullName = o.FullName,
                                 Address = o.Address,
                                 Phone = o.Phone,
                                 Investment = o.Investment,
                                 RegistrationNumber = o.RegistrationNumber,
                                 RegistrationDate = o.RegistrationDate
                             };

                // Привязываем полученные данные к DataGridView
                dataGridView1.DataSource = owners.ToList();

            }
        }
        private void LoadShopsIntoDataGridView()
        {
            using (var db = new ShopDataContext())
            {
                var shops = from s in db.Stores
                            select new
                            {
                                Id = s.Id,
                                Name = s.Name,
                                Address = s.Address,
                                Phone = s.Phone,
                                Capital = s.Capital,
                                Profile = s.Profile,
                                OwnerId = s.OwnerId
                            };

                dataGridView2.DataSource = shops.ToList(); // Обновляем DataGridView магазинов
                dataGridView2.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Stores". При необходимости она может быть перемещена или удалена.
            this.storesTableAdapter.Fill(this.shopDataSet.Stores);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.Owners". При необходимости она может быть перемещена или удалена.
            this.ownersTableAdapter.Fill(this.shopDataSet.Owners);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddOwner();
            form.ShowDialog();
            UpdateTable();
            LoadShopsIntoDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранного владельца
                var selectedRow = dataGridView1.SelectedRows[0];
                int selectedOwnerId = (int)selectedRow.Cells["idDataGridViewTextBoxColumn"].Value; // Используйте имя столбца

                using (var db = new ShopDataContext())
                {
                    // Находим владельца
                    var ownerToDelete = db.Owners.SingleOrDefault(o => o.Id == selectedOwnerId);
                    if (ownerToDelete != null)
                    {
                        
                        // Удаляем владельца из базы данных
                        db.Owners.DeleteOnSubmit(ownerToDelete);

                        // Сохраняем изменения в базе данных
                        db.SubmitChanges();

                        // Обновляем DataGridView, если это необходимо
                        UpdateTable();
                        LoadShopsIntoDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите владельца для удаления.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new AddShop();
            form.ShowDialog();
            UpdateTable();
            LoadShopsIntoDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ShowSpecificShops();
            form.ShowDialog();
        }
    }
}
