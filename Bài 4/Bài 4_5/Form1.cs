namespace Management_Form_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            var item = new ListViewItem(new[] { name, email, phone });
            listView.Items.Add(item);

            // clear inputs
            txtName.Text = txtEmail.Text = txtPhone.Text = string.Empty;
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = listView.SelectedItems[0];
            var name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            sel.SubItems[0].Text = name;
            sel.SubItems[1].Text = txtEmail.Text.Trim();
            sel.SubItems[2].Text = txtPhone.Text.Trim();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                // no selection - clear inputs or leave as is
                return;
            }

            var sel = listView.SelectedItems[0];
            txtName.Text = sel.SubItems.Count > 0 ? sel.SubItems[0].Text : string.Empty;
            txtEmail.Text = sel.SubItems.Count > 1 ? sel.SubItems[1].Text : string.Empty;
            txtPhone.Text = sel.SubItems.Count > 2 ? sel.SubItems[2].Text : string.Empty;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select item(s) to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ok = MessageBox.Show("Delete selected item(s)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            foreach (ListViewItem it in listView.SelectedItems)
            {
                listView.Items.Remove(it);
            }
        }
    }
}
