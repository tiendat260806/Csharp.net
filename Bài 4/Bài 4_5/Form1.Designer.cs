namespace Management_Form_Design
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TableLayoutPanel inputTable;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // Instantiate controls

            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.inputTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.listPanel = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form styling
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Management - Responsive Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // mainTable (fills the form)
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.ColumnCount = 2;
            this.mainTable.RowCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Padding = new System.Windows.Forms.Padding(12);

            // groupBoxInput (left column)
            this.groupBoxInput.Text = "Input";
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(10);

            // inputTable inside groupBox to align labels and textboxes
            this.inputTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTable.ColumnCount = 2;
            this.inputTable.RowCount = 6;
            this.inputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.inputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.inputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.inputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));

            // Labels and TextBoxes
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // arrange controls in inputTable
            this.inputTable.Controls.Add(this.lblName, 0, 0);
            this.inputTable.Controls.Add(this.txtName, 1, 0);
            this.inputTable.Controls.Add(this.lblEmail, 0, 1);
            this.inputTable.Controls.Add(this.txtEmail, 1, 1);
            this.inputTable.Controls.Add(this.lblPhone, 0, 2);
            this.inputTable.Controls.Add(this.txtPhone, 1, 2);

            // Add inputTable to groupBox
            this.groupBoxInput.Controls.Add(this.inputTable);

            // listPanel (right column)
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Padding = new System.Windows.Forms.Padding(8);

            // listView (fills most of right panel)
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.FullRowSelect = true;
            this.listView.MultiSelect = false;
            this.listView.HideSelection = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.Columns.Add("Name", 200);
            this.listView.Columns.Add("Email", 200);
            this.listView.Columns.Add("Phone", 120);

            // Buttons (anchored bottom-right)
            this.btnAdd.Text = "Add";
            this.btnEdit.Text = "Edit";
            this.btnDelete.Text = "Delete";

            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.Size = new System.Drawing.Size(90, 30);

            // modern flat style
            var buttons = new System.Windows.Forms.Button[] { this.btnAdd, this.btnEdit, this.btnDelete };
            foreach (var b in buttons)
            {
                b.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.BackColor = System.Drawing.Color.FromArgb(50, 115, 220);
                b.ForeColor = System.Drawing.Color.White;
                b.Margin = new System.Windows.Forms.Padding(6);
            }

            // position buttons inside a FlowLayoutPanel aligned to bottom-right
            var btnFlow = new System.Windows.Forms.FlowLayoutPanel();
            btnFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            btnFlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnFlow.AutoSize = true;
            btnFlow.Padding = new System.Windows.Forms.Padding(0);
            btnFlow.Controls.Add(this.btnDelete);
            btnFlow.Controls.Add(this.btnEdit);
            btnFlow.Controls.Add(this.btnAdd);

            // assemble listPanel
            this.listPanel.Controls.Add(this.listView);
            this.listPanel.Controls.Add(btnFlow);

            // add to mainTable
            this.mainTable.Controls.Add(this.groupBoxInput, 0, 0);
            this.mainTable.Controls.Add(this.listPanel, 1, 0);

            // add mainTable to form
            this.Controls.Add(this.mainTable);

            // wire up events
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
