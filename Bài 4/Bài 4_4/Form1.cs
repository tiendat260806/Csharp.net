namespace Manage_Menu___Calculate_Total
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private class MenuItemModel
        {
            public string Name { get; set; }
            public int Price { get; set; } // price in thousands (k)
            public MenuItemModel(string name, int price)
            {
                Name = name;
                Price = price;
            }
            public override string ToString()
            {
                return $"{Name} - {Price}k";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Prepopulate the menu list
            lstMenu.Items.Clear();
            lstMenu.Items.Add(new MenuItemModel("Hamburger", 50));
            lstMenu.Items.Add(new MenuItemModel("Pizza", 120));
            lstMenu.Items.Add(new MenuItemModel("Gà Rán", 35));
            lstMenu.Items.Add(new MenuItemModel("Pepsi", 15));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem is MenuItemModel item)
            {
                // Add a copy to selected list
                lstSelected.Items.Add(new MenuItemModel(item.Name, item.Price));
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Please select an item from the menu to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedIndex >= 0)
            {
                lstSelected.Items.RemoveAt(lstSelected.SelectedIndex);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Please select an item from the selected list to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateTotal()
        {
            int total = 0;
            foreach (var obj in lstSelected.Items)
            {
                if (obj is MenuItemModel m)
                    total += m.Price;
            }
            lblTotal.Text = $"Total: {total}k";
        }
    }
}
