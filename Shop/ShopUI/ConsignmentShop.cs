using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCardData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cardBinding = new BindingSource();
        
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cardBinding.DataSource = shoppingCardData;
            shopingCardListBox.DataSource = cardBinding;

            shopingCardListBox.DisplayMember = "Display";
            shopingCardListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolition",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Austin",
                Description = "A book about a girl",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });

            store.Name = "Seconds are Better";
        }

        private void addToCard_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCardData.Add(selectedItem);
            cardBinding.ResetBindings(false);
            
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCardData)
            {
                item.Sold = true;
            }
            shoppingCardData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            cardBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }


    }
}
