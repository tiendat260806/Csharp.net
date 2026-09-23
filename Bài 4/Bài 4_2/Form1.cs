using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistrationFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Populate courses (binding with DisplayMember and ValueMember)
            var courses = new List<Course>()
            {
                new Course { Id = 1, Name = "C# Basics" },
                new Course { Id = 2, Name = "WinForms Advanced" },
                new Course { Id = 3, Name = "ASP.NET Core" },
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";

            // Ensure birth date format shows dd/MM/yyyy
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // Set default phone mask placeholder (optional)
            mtxtPhone.Mask = "(000) 000-0000";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var phone = mtxtPhone.Text;
            var birth = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            var courseName = cboCourse.Text;
            var courseId = cboCourse.SelectedValue;
            var gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "Not specified";
            var agreed = chkAgree.Checked ? "Yes" : "No";

            var message = $"Registration information:\n" +
                          $"Name: {name}\n" +
                          $"Phone: {phone}\n" +
                          $"Birthdate: {birth}\n" +
                          $"Course: {courseName} (Id: {courseId})\n" +
                          $"Gender: {gender}\n" +
                          $"Agreed: {agreed}";

            MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }
    }
}
