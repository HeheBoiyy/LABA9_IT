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
    public partial class AddOwner : Form
    {
        public AddOwner()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FIOBox.Text != string.Empty && AdressBOX.Text != string.Empty && PhoneBox.Text!=string.Empty 
                && MoneyBox.Text!= string.Empty && RegistrationNumBox.Text != string.Empty)
            {
                var t = new Owners()
                {
                    FullName = FIOBox.Text,
                    Address = AdressBOX.Text,
                    Phone = PhoneBox.Text,
                    Investment = Convert.ToDecimal(MoneyBox.Text),
                    RegistrationNumber = RegistrationNumBox.Text,
                    RegistrationDate = Convert.ToDateTime(RegDateBox.Text)
                };
                using (ShopDataContext db = new ShopDataContext())
                {
                    db.Owners.InsertOnSubmit(t);
                    db.SubmitChanges();
                }
                MessageBox.Show("Успешно!");
                this.Close();
            }
        }
    }
}
