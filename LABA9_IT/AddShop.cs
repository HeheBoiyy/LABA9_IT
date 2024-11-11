using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace LABA9_IT
{
    public partial class AddShop : Form
    {
        public AddShop()
        {
            InitializeComponent();
            LoadOwnersToComboBox();
        }
        private void LoadOwnersToComboBox()
        {
            using (var db = new ShopDataContext())
            {
                // Загружаем владельцев в ComboBox
                var owners = db.Owners.Select(o => new { o.Id, o.FullName }).ToList();
                OwnersComboBox.DataSource = owners;
                OwnersComboBox.DisplayMember = "FullName";
                OwnersComboBox.ValueMember = "Id";
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var db = new ShopDataContext())
            {
                // Получаем выбранный ID владельца из ComboBox
                int selectedOwnerId = (int)OwnersComboBox.SelectedValue;

                // Создаём объект нового магазина
                var newStore = new Stores
                {
                    Name = NameBox.Text,          // Название магазина
                    Address = AdressBOX.Text,    // Адрес магазина
                    Phone = PhoneBox.Text,        // Телефон магазина
                    Capital = decimal.Parse(MoneyBox.Text), // Уставной капитал
                    Profile = ProfileBox.Text,         // Профиль магазина
                    OwnerId = selectedOwnerId          // Устанавливаем ID владельца
                };

                // Добавляем магазин в базу данных
                db.Stores.InsertOnSubmit(newStore);
                db.SubmitChanges();

                MessageBox.Show("Магазин успешно добавлен!");  
            }
        }
    }
}
